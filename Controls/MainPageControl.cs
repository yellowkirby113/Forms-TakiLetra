using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public class MainPageControl : UserControl
    {
        public event EventHandler LoginRequested;

        private readonly Button btnGoToLogin;
        private readonly Label lblTitle;

        public MainPageControl()
        {
            this.BackColor = Color.White;

            lblTitle = new Label
            {
                AutoSize = true,
                Text = "Main Page",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Location = new Point(20, 20)
            };

            btnGoToLogin = new Button
            {
                Text = "Ir para Login",
                AutoSize = true,
                Location = new Point(24, 70)
            };
            btnGoToLogin.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);

            Controls.Add(lblTitle);
            Controls.Add(btnGoToLogin);
        }
    }
}