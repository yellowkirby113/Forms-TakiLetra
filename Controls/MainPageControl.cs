using System;
using System.ComponentModel;
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

            // Prevent runtime-only code from executing inside the WinForms Designer.
            // LicenseManager.UsageMode is reliable here (DesignMode is unreliable inside ctor).
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            try
            {
                btnGoToLogin.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);
                btnsetting.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);

                // raise BooksRequested when the Books button is clicked
                btnbooks.Click += (s, e) => BooksRequested?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                // Swallow exceptions so the designer can load. At runtime these should not occur;
                // use Debug.WriteLine to help diagnostics without throwing in design-time.
                System.Diagnostics.Debug.WriteLine($"MainPageControl ctor suppressed exception: {ex}");
            }
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
    }
}