using System.Windows.Forms;

namespace Forms_TakiLetra.Controls
{
    partial class LoginPageControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnlogo;

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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnlogo = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btnacc = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAbooks = new System.Windows.Forms.Button();
            this.btnEBooks = new System.Windows.Forms.Button();
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnsignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(371, 125);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblPassword.Location = new System.Drawing.Point(244, 239);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtUsername.Location = new System.Drawing.Point(321, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 25);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtPassword.Location = new System.Drawing.Point(321, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(167, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnlogo
            // 
            this.btnlogo.AutoSize = true;
            this.btnlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnlogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnlogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnlogo.Location = new System.Drawing.Point(-10, 29);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(92, 66);
            this.btnlogo.TabIndex = 7;
            this.btnlogo.Text = "LOGO";
            this.btnlogo.UseVisualStyleBackColor = false;
            this.btnlogo.Click += new System.EventHandler(this.btnlogo_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.AutoSize = true;
            this.btnsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsetting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Bombardier", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnsetting.Image = global::Forms_TakiLetra.Properties.Resources.settings_42dp_E3E3E3_FILL0_wght500_GRAD200_opsz48;
            this.btnsetting.Location = new System.Drawing.Point(663, 29);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(70, 66);
            this.btnsetting.TabIndex = 10;
            this.btnsetting.UseVisualStyleBackColor = false;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
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
            this.btnacc.TabIndex = 9;
            this.btnacc.Text = "Acc";
            this.btnacc.UseVisualStyleBackColor = false;
            this.btnacc.Click += new System.EventHandler(this.btnacc_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnLogin.Location = new System.Drawing.Point(350, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 38);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
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
            this.btnAbooks.TabIndex = 14;
            this.btnAbooks.Text = "Audiobooks";
            this.btnAbooks.UseVisualStyleBackColor = false;
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
            this.btnEBooks.TabIndex = 13;
            this.btnEBooks.Text = "EBooks";
            this.btnEBooks.UseVisualStyleBackColor = false;
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
            this.btnbooks.TabIndex = 12;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = false;
            // 
            // btnsignup
            // 
            this.btnsignup.AutoSize = true;
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(2)))), ((int)(((byte)(112)))));
            this.btnsignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnsignup.FlatAppearance.BorderSize = 0;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(179)))), ((int)(((byte)(251)))));
            this.btnsignup.Location = new System.Drawing.Point(365, 285);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(69, 25);
            this.btnsignup.TabIndex = 15;
            this.btnsignup.Text = "Sign up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(337, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(244, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(2)))), ((int)(((byte)(112)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.btnAbooks);
            this.Controls.Add(this.btnEBooks);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnacc);
            this.Controls.Add(this.btnlogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Minecrafter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginPageControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btnsetting;
        private Button btnacc;
        private Button btnLogin;
        private Button btnAbooks;
        private Button btnEBooks;
        private Button btnbooks;
        private Button btnsignup;
        private Label label1;
        private Label label2;
    }
}