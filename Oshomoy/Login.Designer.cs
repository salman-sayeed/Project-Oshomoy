namespace Oshomoy
{
    partial class Login
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog1 = new System.Windows.Forms.Label();
            this.lbLogUsername = new System.Windows.Forms.Label();
            this.logPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.Controls.Add(this.lbLogUsername);
            this.logPanel.Controls.Add(this.label1);
            this.logPanel.Controls.Add(this.lbLog1);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.Location = new System.Drawing.Point(893, 0);
            this.logPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(757, 706);
            this.logPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbLog1
            // 
            this.lbLog1.AutoSize = true;
            this.lbLog1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLog1.Location = new System.Drawing.Point(25, 59);
            this.lbLog1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLog1.Name = "lbLog1";
            this.lbLog1.Size = new System.Drawing.Size(208, 39);
            this.lbLog1.TabIndex = 0;
            this.lbLog1.Text = "Get Started";
            // 
            // lbLogUsername
            // 
            this.lbLogUsername.AutoSize = true;
            this.lbLogUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLogUsername.Location = new System.Drawing.Point(28, 133);
            this.lbLogUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogUsername.Name = "lbLogUsername";
            this.lbLogUsername.Size = new System.Drawing.Size(93, 20);
            this.lbLogUsername.TabIndex = 2;
            this.lbLogUsername.Text = "Username";
            this.lbLogUsername.Click += new System.EventHandler(this.lbLogUsername_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1650, 706);
            this.Load += new System.EventHandler(this.Login_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLogUsername;
        private System.Windows.Forms.Label lbLog1;
    }
}
