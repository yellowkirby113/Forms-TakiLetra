using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class MainPageControl : UserControl
    {
        public event EventHandler LoginRequested;
<<<<<<< Updated upstream
        public event EventHandler BooksRequested;
=======
        private bool isDarkMode = true; // Modo escuro por padrão
>>>>>>> Stashed changes

        public MainPageControl()
        {
            InitializeComponent();
<<<<<<< Updated upstream

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
=======
            btnGoToLogin.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);
            // Modificar o botão de settings para alternar o tema
            btnsetting.Click += (s, e) => ToggleTheme();
        }

        /// <summary>
        /// Alterna entre modo claro e escuro
        /// </summary>
        public void ToggleTheme()
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                // Modo Escuro (tema atual)
                this.BackColor = Color.FromArgb(59, 2, 112);
                lblTitle.ForeColor = Color.FromArgb(255, 241, 241);
                
                // Botões da barra superior
                Color darkButtonBg = Color.FromArgb(90, 1, 200);
                Color lightText = Color.FromArgb(251, 241, 241);
                
                btnlogo.BackColor = darkButtonBg;
                btnlogo.ForeColor = lightText;
                btnbooks.BackColor = darkButtonBg;
                btnbooks.ForeColor = lightText;
                btnAbooks.BackColor = darkButtonBg;
                btnAbooks.ForeColor = lightText;
                btnEBooks.BackColor = darkButtonBg;
                btnEBooks.ForeColor = lightText;
                btnsetting.BackColor = darkButtonBg;
                btnsetting.ForeColor = lightText;
                btnacc.BackColor = darkButtonBg;
                btnacc.ForeColor = lightText;
                
                // Botão de login
                btnGoToLogin.BackColor = Color.FromArgb(111, 0, 255);
                btnGoToLogin.ForeColor = Color.FromArgb(255, 241, 241);
            }
            else
            {
                // Modo Claro
                this.BackColor = Color.White;
                lblTitle.ForeColor = Color.FromArgb(59, 2, 112);
                
                // Botões da barra superior
                Color lightButtonBg = Color.FromArgb(200, 180, 255);
                Color darkText = Color.FromArgb(59, 2, 112);
                
                btnlogo.BackColor = lightButtonBg;
                btnlogo.ForeColor = darkText;
                btnbooks.BackColor = lightButtonBg;
                btnbooks.ForeColor = darkText;
                btnAbooks.BackColor = lightButtonBg;
                btnAbooks.ForeColor = darkText;
                btnEBooks.BackColor = lightButtonBg;
                btnEBooks.ForeColor = darkText;
                btnsetting.BackColor = lightButtonBg;
                btnsetting.ForeColor = darkText;
                btnacc.BackColor = lightButtonBg;
                btnacc.ForeColor = darkText;
                
                // Botão de login
                btnGoToLogin.BackColor = Color.FromArgb(111, 0, 255);
                btnGoToLogin.ForeColor = Color.White;
>>>>>>> Stashed changes
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