using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Forms_TakiLetra
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private enum ScreenId { Main, Login, SignUp, Shop }

        private readonly Dictionary<ScreenId, UserControl> _screens = new Dictionary<ScreenId, UserControl>();
        private ScreenId? _current;

        // Declaração do painel de conteúdo usado para trocar telas
        private Panel contentPanel;

        public Form1()
        {
            InitializeComponent();

            // Remova a borda padrão (pode também ser definido no Designer)
            this.FormBorderStyle = FormBorderStyle.None;

            // Inicialize o painel de conteúdo se não estiver criado via Designer
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(contentPanel);

            // Eventos: arrastar pela barra customizada e botões
            pnlTitleBar.MouseDown += TitleBar_MouseDown;
            lblTitle.MouseDown += TitleBar_MouseDown; // arrastar também clicando no título
            flpTitleButtons.MouseDown += TitleBar_MouseDown;

            btnClose.Click += (s, e) => this.Close();
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Garantir que a aplicação comece na MainPage
            Navigate(ScreenId.Main);
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mantido vazio porque a navegação já ocorre no construtor
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
                    login.MainPageRequested += (s, e) => Navigate(ScreenId.Main);
                    login.SignUpRequested += (s, e) => Navigate(ScreenId.SignUp);
                    created = login;
                    break;
                }
                case ScreenId.SignUp:
                {
                    var sign = new Controls.SignUpPageControl();
                    sign.SignUpSucceeded += (s, e) => Navigate(ScreenId.Login);
                    sign.CancelRequested += (s, e) => Navigate(ScreenId.Login);
                    created = sign;
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
