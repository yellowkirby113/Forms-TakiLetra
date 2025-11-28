using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class MainPageControl : UserControl
    {
        public event EventHandler LoginRequested;
        public event EventHandler SettingsRequested;

        private bool _isLoggedIn;
        private string _username = string.Empty;
        private string _accDefaultText;

        public MainPageControl()
        {
            InitializeComponent();

            // guarda o texto padrão do botão de conta
            _accDefaultText = btnacc.Text;

            btnGoToLogin.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);

            // Acc: se não logado, vai para login
            btnacc.Click += (s, e) =>
            {
                if (!_isLoggedIn)
                    LoginRequested?.Invoke(this, EventArgs.Empty);
            };

            // Settings: se logado vai para settings, senão pede login
            btnsetting.Click += (s, e) =>
            {
                if (_isLoggedIn)
                    SettingsRequested?.Invoke(this, EventArgs.Empty);
                else
                    LoginRequested?.Invoke(this, EventArgs.Empty);
            };
        }

        public void ApplySession(string username)
        {
            _isLoggedIn = !string.IsNullOrEmpty(username);
            _username = username ?? string.Empty;
            btnacc.Text = _isLoggedIn ? _username : _accDefaultText;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}