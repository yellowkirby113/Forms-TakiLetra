using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class SignUpPageControl : UserControl
    {
        public event EventHandler SignUpSucceeded;
        public event EventHandler CancelRequested;
        public event EventHandler LoginRequested;

        public SignUpPageControl()
        {
            InitializeComponent();
            if (btnCreateAccount != null)
                btnCreateAccount.Click += (s, e) => TryCreateAccount();
            if (btnBack != null)
                btnBack.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            if (btnBackRight != null)
                btnBackRight.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            if (txtNewUsername != null)
                txtNewUsername.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) TryCreateAccount(); };
            if (txtNewPassword != null)
                txtNewPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) TryCreateAccount(); };

        }

        private void TryCreateAccount()
        {
            var user = txtNewUsername?.Text ?? string.Empty;
            var pass = txtNewPassword?.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Informe o nome de usuário.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewUsername?.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Informe a senha.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword?.Focus();
                return;
            }

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt");
            try
            {
                if (!File.Exists(path))
                    File.WriteAllText(path, string.Empty);

                var lines = File.ReadAllLines(path)
                    .Select(l => l.Trim())
                    .Where(l => l.Length > 0 && l.Contains(":"))
                    .Select(l => l.Split(new[] { ':' }, 3))
                    .ToList();

                var exists = lines.Any(p => p.Length >= 1 && p[0].Equals(user, StringComparison.OrdinalIgnoreCase));
                if (exists)
                {
                    MessageBox.Show("Usuário já existe.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Adiciona o novo usuário ao arquivo
                File.AppendAllText(path, $"{user}:{pass}\n");

                MessageBox.Show("Conta criada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignUpSucceeded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbacktologin_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}