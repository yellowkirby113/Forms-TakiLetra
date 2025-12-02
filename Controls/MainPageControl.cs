using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class MainPageControl : UserControl
    {
        public event EventHandler LoginRequested;
        public event EventHandler BooksRequested;

        public MainPageControl()
        {
            InitializeComponent();
            btnGoToLogin.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);
            btnsetting.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);
            btnbooks.Click += (s, e) => BooksRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //should take to the main page no matter the page
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //in main page takes to login,maybe subtituite the pfp with the login button
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //in main page takes to login,maybe subtituite the pfp with the login button
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            // 1) Prefer letting any subscriber handle navigation
            var handlers = BooksRequested;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
                return;
            }

            // 2) No subscribers - attempt to locate and open a Books view by convention
            try
            {
                var asm = System.Reflection.Assembly.GetExecutingAssembly();
                Type target = null;
                foreach (var t in asm.GetTypes())
                {
                    if (string.Equals(t.Name, "Books", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(t.Name, "BooksForm", StringComparison.OrdinalIgnoreCase))
                    {
                        target = t;
                        break;
                    }
                }

                if (target == null)
                {
                    // No type found; nothing to do.
                    return;
                }

                var instance = Activator.CreateInstance(target);

                // If it's a Form, show it
                if (instance is Form frm)
                {
                    frm.Show();
                    return;
                }

                // If it's a UserControl, replace host contents
                if (instance is UserControl uc)
                {
                    Control host = this.Parent ?? this.FindForm() as Control;
                    if (host != null)
                    {
                        host.Controls.Clear();
                        uc.Dock = DockStyle.Fill;
                        host.Controls.Add(uc);
                    }
                    return;
                }

                // Type found but not a Form/UserControl - nothing to do
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Books view: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}