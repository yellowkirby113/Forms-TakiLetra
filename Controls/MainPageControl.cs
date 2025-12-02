using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class MainPageControl : UserControl
    {
        public event EventHandler LoginRequested;

        public MainPageControl()
        {
            InitializeComponent();
            btnGoToLogin.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);
            btnsetting.Click += (s, e) => LoginRequested?.Invoke(this, EventArgs.Empty);
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
    }
}