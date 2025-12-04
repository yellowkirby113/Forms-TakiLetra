namespace Forms_TakiLetra.Controls
{
    partial class books
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackToMain;

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(339, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Livros";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.AutoSize = true;
            this.btnBackToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBackToMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnBackToMain.Location = new System.Drawing.Point(329, 190);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(98, 45);
            this.btnBackToMain.TabIndex = 1;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // books
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(2)))), ((int)(((byte)(112)))));
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Minecrafter", 8.25F, System.Drawing.FontStyle.Regular);
            this.Name = "books";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}