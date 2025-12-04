using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class books : UserControl
    {
        public event EventHandler MainPageRequested;

        private Button btnBackToMain;

        public books()
        {
            InitializeComponent();
            CreateBackButton();
        }

        private void CreateBackButton()
        {
            btnBackToMain = new Button
            {
                Name = "btnBackToMain",
                Text = "Back",
                AutoSize = true,
                BackColor = Color.FromArgb(111, 0, 255),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Calibri", 11.25F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 241, 241),
                Location = new Point(90, 40),
            };

            btnBackToMain.Click += BtnBackToMain_Click;

            this.Controls.Add(btnBackToMain);
            btnBackToMain.BringToFront();
        }

        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            MainPageRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}