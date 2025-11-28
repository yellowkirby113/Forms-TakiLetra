using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class LoginPageControl : UserControl
    {
        public event EventHandler LoginSucceeded;
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
                TryLogin();
        }

        private void TryLogin()
        {
            LoggedRole = "User";
            var user = txtUsername?.Text ?? string.Empty;
            var pass = txtPassword?.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(user))
            {
                txtUsername?.Focus();
                txtUsername?.Clear();

                return;
            }

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt");
            if (!File.Exists(path))
            {
                MessageBox.Show("Arquivo de usuários não encontrado: " + path, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var lines = File.ReadAllLines(path);
                var match = lines
                    .Select(l => l.Trim())
                    .Where(l => l.Length > 0 && l.Contains(":"))
                    .Select(l => l.Split(new[] { ':' }, 3))
                    .FirstOrDefault(parts => parts.Length >= 2 && parts[0] == user && parts[1] == pass);

                if (match != null)
                {
                    if (match.Length >= 3 && !string.IsNullOrWhiteSpace(match[2]))
                        LoggedRole = match[2];
                    LoginSucceeded?.Invoke(this, EventArgs.Empty);
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                    MessageBox.Show("Credenciais inválidas.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler arquivo de usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}