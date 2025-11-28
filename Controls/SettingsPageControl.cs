    using System;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public class SettingsPageControl : UserControl
    {
        public event EventHandler CloseRequested;

        private readonly Button _btnBack;
        private readonly Label _lblTitle;

        public SettingsPageControl()
        {
            this.BackColor = System.Drawing.Color.FromArgb(59, 2, 112);
            this.Dock = DockStyle.Fill;

            _lblTitle = new Label
            {
                Text = "Settings",
                AutoSize = true,
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold),
                Left = 20,
                Top = 20
            };
            Controls.Add(_lblTitle);

            _btnBack = new Button
            {
                Text = "←",
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(59, 2, 122),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Left = 20,
                Top = 60
            };
            _btnBack.FlatAppearance.BorderSize = 0;
            _btnBack.Click += (s, e) => CloseRequested?.Invoke(this, EventArgs.Empty);
            Controls.Add(_btnBack);
        }
    }
}