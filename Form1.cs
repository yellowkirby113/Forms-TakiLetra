using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms_TakiLetra
{
    public partial class Form1 : Form
    {
        private enum ScreenId { Main, Login, Shop }

        private readonly Dictionary<ScreenId, UserControl> _screens = new Dictionary<ScreenId, UserControl>();
        private ScreenId? _current;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Navigate(ScreenId.Main);
        }

        private void Navigate(ScreenId screen)
        {
            if (_current == screen) return;

            var control = GetOrCreateScreen(screen);
            control.Dock = DockStyle.Fill;

            contentPanel.SuspendLayout();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(control);
            contentPanel.ResumeLayout();

            _current = screen;
        }

        private UserControl GetOrCreateScreen(ScreenId screen)
        {
            if (_screens.TryGetValue(screen, out var cached))
                return cached;

            UserControl created;
            switch (screen)
            {
                case ScreenId.Main:
                {
                    var main = new Controls.MainPageControl();
                    main.LoginRequested += (s, e) => Navigate(ScreenId.Login);
                    created = main;
                    break;
                }
                case ScreenId.Login:
                {
                    var login = new Controls.LoginPageControl();
                    login.LoginSucceeded += (s, e) => Navigate(ScreenId.Shop);
                    login.CancelRequested += (s, e) => Navigate(ScreenId.Main);
                    created = login;
                    break;
                }
                case ScreenId.Shop:
                default:
                {
                    var shop = new Controls.ShopPageControl();
                    shop.LogoutRequested += (s, e) => Navigate(ScreenId.Main);
                    created = shop;
                    break;
                }
            }

            _screens[screen] = created;
            return created;
        }
    }
}
