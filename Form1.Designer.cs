using System.Drawing;
using System.Windows.Forms;

namespace Forms_TakiLetra
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTitleBar;
        private FlowLayoutPanel flpTitleButtons;
        private Button btnClose;
        private Button btnMinimize;
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.flpTitleButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.flpTitleButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.pnlTitleBar.Controls.Add(this.flpTitleButtons);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(800, 32);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // flpTitleButtons
            // 
            this.flpTitleButtons.Controls.Add(this.btnClose);
            this.flpTitleButtons.Controls.Add(this.btnMinimize);
            this.flpTitleButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpTitleButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpTitleButtons.Location = new System.Drawing.Point(680, 0);
            this.flpTitleButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitleButtons.Name = "flpTitleButtons";
            this.flpTitleButtons.Size = new System.Drawing.Size(120, 32);
            this.flpTitleButtons.TabIndex = 0;
            this.flpTitleButtons.WrapContents = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(76, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(28, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 28);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(26, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "App";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "Form1";
            this.Text = "App";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.flpTitleButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

