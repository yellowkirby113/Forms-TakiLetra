using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    partial class MainPageControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnGoToLogin;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.btnlogo = new System.Windows.Forms.Button();
            this.btnacc = new System.Windows.Forms.Button();
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnEBooks = new System.Windows.Forms.Button();
            this.btnAbooks = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(339, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Main Page";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.AutoSize = true;
            this.btnGoToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnGoToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGoToLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnGoToLogin.Location = new System.Drawing.Point(344, 258);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(98, 45);
            this.btnGoToLogin.TabIndex = 1;
            this.btnGoToLogin.Text = "Login";
            this.btnGoToLogin.UseVisualStyleBackColor = false;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
            // 
            // btnlogo
            // 
            this.btnlogo.AutoSize = true;
            this.btnlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnlogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnlogo.Location = new System.Drawing.Point(-10, 29);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(92, 66);
            this.btnlogo.TabIndex = 2;
            this.btnlogo.Text = "LOGO";
            this.btnlogo.UseVisualStyleBackColor = false;
            this.btnlogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnacc
            // 
            this.btnacc.AutoSize = true;
            this.btnacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnacc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnacc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnacc.Location = new System.Drawing.Point(728, 29);
            this.btnacc.Name = "btnacc";
            this.btnacc.Size = new System.Drawing.Size(95, 66);
            this.btnacc.TabIndex = 4;
            this.btnacc.Text = "Acc";
            this.btnacc.UseVisualStyleBackColor = false;
            this.btnacc.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnbooks
            // 
            this.btnbooks.AutoSize = true;
            this.btnbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbooks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooks.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnbooks.Location = new System.Drawing.Point(68, 29);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(198, 66);
            this.btnbooks.TabIndex = 6;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = false;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnEBooks
            // 
            this.btnEBooks.AutoSize = true;
            this.btnEBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnEBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEBooks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEBooks.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnEBooks.Location = new System.Drawing.Point(465, 29);
            this.btnEBooks.Name = "btnEBooks";
            this.btnEBooks.Size = new System.Drawing.Size(200, 66);
            this.btnEBooks.TabIndex = 7;
            this.btnEBooks.Text = "EBooks";
            this.btnEBooks.UseVisualStyleBackColor = false;
            this.btnEBooks.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAbooks
            // 
            this.btnAbooks.AutoSize = true;
            this.btnAbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnAbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbooks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbooks.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnAbooks.Location = new System.Drawing.Point(265, 29);
            this.btnAbooks.Name = "btnAbooks";
            this.btnAbooks.Size = new System.Drawing.Size(207, 66);
            this.btnAbooks.TabIndex = 8;
            this.btnAbooks.Text = "Audiobooks";
            this.btnAbooks.UseVisualStyleBackColor = false;
            this.btnAbooks.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.AutoSize = true;
            this.btnsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsetting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnsetting.Image = global::Forms_TakiLetra.Properties.Resources.settings_42dp_E3E3E3_FILL0_wght500_GRAD200_opsz48;
            this.btnsetting.Location = new System.Drawing.Point(663, 29);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(70, 66);
            this.btnsetting.TabIndex = 5;
            this.btnsetting.UseVisualStyleBackColor = false;
            this.btnsetting.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(2)))), ((int)(((byte)(112)))));
            this.Controls.Add(this.btnAbooks);
            this.Controls.Add(this.btnEBooks);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnacc);
            this.Controls.Add(this.btnlogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGoToLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainPageControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnlogo;
        private Button btnacc;
        private Button btnsetting;
        private Button btnbooks;
        private Button btnEBooks;
        private Button btnAbooks;
    }
}