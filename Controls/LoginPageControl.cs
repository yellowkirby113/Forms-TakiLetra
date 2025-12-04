using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Forms_TakiLetra.Models;

namespace Forms_TakiLetra.Controls
{
    public partial class LoginPageControl : UserControl
    {
        public event EventHandler LoginSucceeded;
        public event EventHandler AdminLoginSucceeded;
        public event EventHandler CancelRequested;

        /// <summary>
        /// Evento disparado quando o usuário clica no logo desejando voltar à página principal.
        /// O container que hospeda este controle deve tratar o evento e exibir a página principal.
        /// </summary>
        public event EventHandler MainPageRequested;

        /// <summary>
        /// Evento disparado quando o usuário solicita a página de cadastro.
        /// </summary>
        public event EventHandler SignUpRequested;

        /// <summary>
        /// Último papel (role) do usuário que fez login com sucesso ("Admin" ou "User").
        /// </summary>
        public string LoggedRole { get; private set; } = "User";

        public LoginPageControl()
        {
            InitializeComponent();

            if (txtUsername != null)
                txtUsername.KeyDown += TxtUsername_KeyDown;

            if (btnlogo != null)
                btnlogo.Click += (s, e) => TryLogin();
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o som de "ding" no Windows
                TryLogin();
            }
        }

        private void TryLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userData = UserData.LoadUsers().FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);

            if (userData != null)
            {
                LoggedRole = userData.Role;
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtUsername.Clear();
                txtPassword.Clear();

                if (userData.Role == "Admin") // Verifica a propriedade Role
                {
                    AdminLoginSucceeded?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    LoginSucceeded?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbooks_Click(object sender, EventArgs e)
        {
        }

        private void btnEBooks_Click(object sender, EventArgs e)
        {
        }

        private void btnacc_Click(object sender, EventArgs e)
        {
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
        }

        private void btnlogo_Click(object sender, EventArgs e)
        {
            MainPageRequested?.Invoke(this, EventArgs.Empty);
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sign up button
            SignUpRequested?.Invoke(this, EventArgs.Empty);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TryLogin();
        }
    }
}