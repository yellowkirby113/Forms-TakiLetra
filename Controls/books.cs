using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class books : UserControl
    {
        public event EventHandler MainPageRequested;

        // runtime-only controls (not declared in Designer)
        private ListView lvProducts;
        private Label lblStatus;

        public books()
        {
            InitializeComponent();

            // don't run runtime UI initialization inside the WinForms designer
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            CreateStatusLabel();
            CreateListView();

            // optionally load default products file on creation
            LoadProducts();
        }

        private void CreateListView()
        {
            lvProducts = new ListView
            {
                Name = "lvProducts",
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Location = new Point(16, 60),
                Size = new Size(768, 320),
                BackColor = Color.FromArgb(59, 2, 112),
                ForeColor = Color.FromArgb(255, 241, 241),
                Font = new Font("Calibri", 10F, FontStyle.Regular),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            lvProducts.Columns.Add("Title", 320);
            lvProducts.Columns.Add("Author", 180);
            lvProducts.Columns.Add("Category", 120);
            lvProducts.Columns.Add("Stock", 60);
            lvProducts.Columns.Add("Price", 80);

            this.Controls.Add(lvProducts);
            lvProducts.BringToFront();
        }

        private void CreateStatusLabel()
        {
            lblStatus = new Label
            {
                AutoSize = true,
                Location = new Point(16, 28),
                ForeColor = Color.FromArgb(255, 241, 241),
                Font = new Font("Calibri", 9f, FontStyle.Italic),
                Text = string.Empty
            };

            this.Controls.Add(lblStatus);
            lblStatus.BringToFront();
        }

        // Public API: load products from filePath and apply optional args (key=value)
        // Supported keys: minStock, maxStock, category, search, sort (title|stock|price), limit
        // NOTE: parsing uses ':' as the field separator in products.txt and is robust to field order.
        public void LoadProducts(string filePath = null, params string[] args)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            try
            {
                string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.txt");
                string path = string.IsNullOrWhiteSpace(filePath) ? defaultPath : filePath;

                if (!File.Exists(path))
                {
                    lblStatus.Text = $"products file not found: {Path.GetFileName(path)}";
                    lvProducts.Items.Clear();
                    return;
                }

                var options = ParseArgs(args);
                var lines = File.ReadAllLines(path)
                                .Select(l => l.Trim())
                                .Where(l => !string.IsNullOrWhiteSpace(l) && !l.StartsWith("#"))
                                .ToList();

                // Detect and skip header if present
                if (lines.Count > 0 && IsHeaderLine(lines[0]))
                    lines = lines.Skip(1).ToList();

                var products = new List<Product>();
                foreach (var line in lines)
                {
                    var p = ParseProductLine(line);
                    if (p != null)
                        products.Add(p);
                }

                // Apply filters
                if (options.MinStock.HasValue)
                    products = products.Where(p => p.Stock >= options.MinStock.Value).ToList();
                if (options.MaxStock.HasValue)
                    products = products.Where(p => p.Stock <= options.MaxStock.Value).ToList();
                if (!string.IsNullOrWhiteSpace(options.Category))
                    products = products.Where(p => string.Equals(p.Category, options.Category, StringComparison.OrdinalIgnoreCase)).ToList();
                if (!string.IsNullOrWhiteSpace(options.Search))
                    products = products.Where(p =>
                        (p.Title ?? string.Empty).IndexOf(options.Search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        (p.Author ?? string.Empty).IndexOf(options.Search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                // Sorting
                switch (options.Sort?.ToLowerInvariant())
                {
                    case "title":
                        products = products.OrderBy(p => p.Title).ToList();
                        break;
                    case "stock":
                        products = products.OrderByDescending(p => p.Stock).ToList();
                        break;
                    case "price":
                        products = products.OrderBy(p => p.Price).ToList();
                        break;
                }

                // Limit
                if (options.Limit.HasValue)
                    products = products.Take(options.Limit.Value).ToList();

                // Fill ListView
                lvProducts.BeginUpdate();
                lvProducts.Items.Clear();
                foreach (var p in products)
                {
                    var item = new ListViewItem(p.Title ?? string.Empty);
                    item.SubItems.Add(p.Author ?? string.Empty);
                    item.SubItems.Add(p.Category ?? string.Empty);
                    item.SubItems.Add(p.Stock.ToString());
                    item.SubItems.Add(p.Price == 0 ? string.Empty : p.Price.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

                    if (p.Stock <= 0)
                        item.ForeColor = Color.LightSalmon;

                    lvProducts.Items.Add(item);
                }
                lvProducts.EndUpdate();

                lblStatus.Text = $"Loaded {products.Count} products from {Path.GetFileName(path)}";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error loading products: {ex.Message}";
            }
        }

        // Heuristic parser: splits by ':' and finds numeric fields for stock/price.
        private Product ParseProductLine(string line)
        {
            var parts = line.Split(new[] { ':' }, StringSplitOptions.None)
                            .Select(p => p.Trim())
                            .Where(p => p.Length > 0)
                            .ToArray();

            if (parts.Length == 0) return null;

            int stockIndex = -1;
            int stockVal = 0;
            int priceIndex = -1;
            decimal priceVal = 0m;

            // detect stock (integer) and price (decimal with comma/dot)
            for (int i = 0; i < parts.Length; i++)
            {
                var s = parts[i];

                if (stockIndex == -1 && int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var si))
                {
                    stockIndex = i;
                    stockVal = si;
                    continue;
                }

                // Try parse decimal with pt-BR (comma) then invariant (dot)
                if (priceIndex == -1)
                {
                    if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.GetCultureInfo("pt-BR"), out var pd))
                    {
                        priceIndex = i;
                        priceVal = pd;
                        continue;
                    }
                    if (decimal.TryParse(s.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out var pd2))
                    {
                        priceIndex = i;
                        priceVal = pd2;
                        continue;
                    }
                }

                // fallback: sometimes stock may be written with no culture parsing (e.g., "37")
                if (stockIndex == -1 && int.TryParse(s, NumberStyles.Integer, CultureInfo.GetCultureInfo("pt-BR"), out var si2))
                {
                    stockIndex = i;
                    stockVal = si2;
                }
            }

            // Build title/author/category from non-numeric parts, skipping indices used for stock/price
            var textParts = new List<string>();
            for (int i = 0; i < parts.Length; i++)
            {
                if (i == stockIndex || i == priceIndex) continue;
                // treat entries that are clearly numeric as skipped
                if (int.TryParse(parts[i], out _) || decimal.TryParse(parts[i].Replace(',', '.'), out _)) continue;
                textParts.Add(parts[i]);
            }

            string title = textParts.ElementAtOrDefault(0) ?? string.Empty;
            string author = textParts.ElementAtOrDefault(1) ?? string.Empty;
            string category = textParts.ElementAtOrDefault(2) ?? string.Empty;

            // If no stock found, attempt to guess from typical position (4th)
            if (stockIndex == -1 && parts.Length >= 4 && int.TryParse(parts[3], out var guessedStock))
            {
                stockVal = guessedStock;
            }

            return new Product
            {
                Title = title,
                Author = author,
                Category = category,
                Stock = stockVal,
                Price = priceVal
            };
        }

        private bool IsHeaderLine(string line)
        {
            var lower = line.ToLowerInvariant();
            return lower.Contains("title") || (lower.Contains("author") && (lower.Contains("stock") || lower.Contains("price")));
        }

        private Options ParseArgs(string[] args)
        {
            var opt = new Options();

            foreach (var a in (args ?? Array.Empty<string>()))
            {
                if (string.IsNullOrWhiteSpace(a)) continue;
                var kv = a.Split(new[] { '=' }, 2);
                if (kv.Length == 0) continue;

                string key = kv[0].Trim().ToLowerInvariant();
                string val = kv.Length > 1 ? kv[1].Trim() : string.Empty;

                if (key == "minstock" && int.TryParse(val, out var mi)) opt.MinStock = mi;
                else if (key == "maxstock" && int.TryParse(val, out var ma)) opt.MaxStock = ma;
                else if (key == "category") opt.Category = val;
                else if (key == "search") opt.Search = val;
                else if (key == "sort") opt.Sort = val;
                else if (key == "limit" && int.TryParse(val, out var lm)) opt.Limit = lm;
            }

            return opt;
        }

        private class Options
        {
            public int? MinStock { get; set; }
            public int? MaxStock { get; set; }
            public string Category { get; set; }
            public string Search { get; set; }
            public string Sort { get; set; }
            public int? Limit { get; set; }
        }

        private class Product
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Stock { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }

        // Back button handler (wired in books.Designer.cs)
        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            MainPageRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}