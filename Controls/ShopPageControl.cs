using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public class ShopPageControl : UserControl
    {
        public event EventHandler LogoutRequested;

        public ShopPageControl()
        {
            this.BackColor = Color.White;

            var lblTitle = new Label
            {
                AutoSize = true,
                Text = "Shop",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Location = new Point(20, 20)
            };

            var lblInfo = new Label
            {
                AutoSize = true,
                Text = "Bem-vindo � loja!",
                Location = new Point(24, 60)
            };

            var btnLogout = new Button
            {
                Text = "Sair",
                AutoSize = true,
                Location = new Point(24, 90)
            };
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);

            Controls.Add(lblTitle);
            Controls.Add(lblInfo);
            Controls.Add(btnLogout);
        }
    }
}