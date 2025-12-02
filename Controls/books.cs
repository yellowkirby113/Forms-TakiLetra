using System;
using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    public partial class books : UserControl
    {
        // Event the host (Form1) can subscribe to in order to navigate to the Main page.
        public event EventHandler MainPageRequested;

        public books()
        {
            InitializeComponent();
        }

        private void books_Load(object sender, System.EventArgs e)
        {

        }

        // Raised by the Designer-wired button click.
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPageRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}