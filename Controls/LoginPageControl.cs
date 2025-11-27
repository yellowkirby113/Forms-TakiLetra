using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public class LoginPageControl : UserControl
    {
        public event EventHandler LoginSucceeded;
        public event EventHandler CancelRequested;

        private readonly TextBox txtUser;
        private readonly TextBox txtPass;
        private readonly Button btnLogin;
        private readonly Button btnCancel;

        public LoginPageControl()
        {
            this.BackColor = Color.White;

            var lblTitle = new Label
            {
                AutoSize = true,
                Text = "Login",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Location = new Point(20, 20)
            };

            var lblUser = new Label { Text = "Usuário:", AutoSize = true, Location = new Point(24, 80) };
            txtUser = new TextBox { Width = 200, Location = new Point(100, 76) };

            var lblPass = new Label { Text = "Senha:", AutoSize = true, Location = new Point(24, 115) };
            txtPass = new TextBox { Width = 200, Location = new Point(100, 111), UseSystemPasswordChar = true };

            btnLogin = new Button { Text = "Entrar", AutoSize = true, Location = new Point(100, 150) };
            btnCancel = new Button { Text = "Cancelar", AutoSize = true, Location = new Point(170, 150) };

            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);

            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Informe o usuário.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return;
            }
            // Aqui você poderia validar credenciais de verdade
            LoginSucceeded?.Invoke(this, EventArgs.Empty);
        }
    }
}