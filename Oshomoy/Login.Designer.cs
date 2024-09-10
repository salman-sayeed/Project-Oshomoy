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
            this.linklbForgotPass = new System.Windows.Forms.LinkLabel();
            this.linklbNoAccount = new System.Windows.Forms.LinkLabel();
            this.btLogLogin = new System.Windows.Forms.Button();
            this.tbLogPass = new System.Windows.Forms.TextBox();
            this.lbLogPass = new System.Windows.Forms.Label();
            this.tbLogUsername = new System.Windows.Forms.TextBox();
            this.lbLogUsername = new System.Windows.Forms.Label();
            this.lbLog1 = new System.Windows.Forms.Label();
            this.logPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logPanel.Controls.Add(this.linklbForgotPass);
            this.logPanel.Controls.Add(this.linklbNoAccount);
            this.logPanel.Controls.Add(this.btLogLogin);
            this.logPanel.Controls.Add(this.tbLogPass);
            this.logPanel.Controls.Add(this.lbLogPass);
            this.logPanel.Controls.Add(this.tbLogUsername);
            this.logPanel.Controls.Add(this.lbLogUsername);
            this.logPanel.Controls.Add(this.lbLog1);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.Location = new System.Drawing.Point(781, 0);
            this.logPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(419, 565);
            this.logPanel.TabIndex = 0;
            // 
            // linklbForgotPass
            // 
            this.linklbForgotPass.AutoSize = true;
            this.linklbForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.linklbForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbForgotPass.LinkColor = System.Drawing.Color.Gray;
            this.linklbForgotPass.Location = new System.Drawing.Point(145, 372);
            this.linklbForgotPass.Name = "linklbForgotPass";
            this.linklbForgotPass.Size = new System.Drawing.Size(148, 20);
            this.linklbForgotPass.TabIndex = 4;
            this.linklbForgotPass.TabStop = true;
            this.linklbForgotPass.Text = "Forgot Password";
            this.linklbForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbForgotPass.VisitedLinkColor = System.Drawing.Color.DimGray;
            // 
            // linklbNoAccount
            // 
            this.linklbNoAccount.AutoSize = true;
            this.linklbNoAccount.BackColor = System.Drawing.Color.Transparent;
            this.linklbNoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbNoAccount.LinkColor = System.Drawing.Color.Gray;
            this.linklbNoAccount.Location = new System.Drawing.Point(123, 410);
            this.linklbNoAccount.Name = "linklbNoAccount";
            this.linklbNoAccount.Size = new System.Drawing.Size(199, 20);
            this.linklbNoAccount.TabIndex = 5;
            this.linklbNoAccount.TabStop = true;
            this.linklbNoAccount.Text = "Don\'t have an account?";
            this.linklbNoAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLogLogin
            // 
            this.btLogLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btLogLogin.Location = new System.Drawing.Point(104, 310);
            this.btLogLogin.Name = "btLogLogin";
            this.btLogLogin.Size = new System.Drawing.Size(230, 46);
            this.btLogLogin.TabIndex = 3;
            this.btLogLogin.Text = "Login";
            this.btLogLogin.UseVisualStyleBackColor = true;
            // 
            // tbLogPass
            // 
            this.tbLogPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLogPass.Location = new System.Drawing.Point(78, 238);
            this.tbLogPass.Multiline = true;
            this.tbLogPass.Name = "tbLogPass";
            this.tbLogPass.PasswordChar = '•';
            this.tbLogPass.Size = new System.Drawing.Size(286, 31);
            this.tbLogPass.TabIndex = 2;
            // 
            // lbLogPass
            // 
            this.lbLogPass.AutoSize = true;
            this.lbLogPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLogPass.Location = new System.Drawing.Point(74, 213);
            this.lbLogPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogPass.Name = "lbLogPass";
            this.lbLogPass.Size = new System.Drawing.Size(90, 20);
            this.lbLogPass.TabIndex = 11;
            this.lbLogPass.Text = "Password";
            // 
            // tbLogUsername
            // 
            this.tbLogUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLogUsername.Location = new System.Drawing.Point(78, 155);
            this.tbLogUsername.Multiline = true;
            this.tbLogUsername.Name = "tbLogUsername";
            this.tbLogUsername.Size = new System.Drawing.Size(286, 31);
            this.tbLogUsername.TabIndex = 1;
            // 
            // lbLogUsername
            // 
            this.lbLogUsername.AutoSize = true;
            this.lbLogUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLogUsername.Location = new System.Drawing.Point(74, 130);
            this.lbLogUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogUsername.Name = "lbLogUsername";
            this.lbLogUsername.Size = new System.Drawing.Size(93, 20);
            this.lbLogUsername.TabIndex = 10;
            this.lbLogUsername.Text = "Username";
            this.lbLogUsername.Click += new System.EventHandler(this.lbLogUsername_Click);
            // 
            // lbLog1
            // 
            this.lbLog1.AutoSize = true;
            this.lbLog1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLog1.Location = new System.Drawing.Point(71, 58);
            this.lbLog1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLog1.Name = "lbLog1";
            this.lbLog1.Size = new System.Drawing.Size(204, 38);
            this.lbLog1.TabIndex = 0;
            this.lbLog1.Text = "Get Started";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1200, 565);
            this.Load += new System.EventHandler(this.Login_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label lbLogUsername;
        private System.Windows.Forms.Label lbLog1;
        private System.Windows.Forms.TextBox tbLogUsername;
        private System.Windows.Forms.TextBox tbLogPass;
        private System.Windows.Forms.Label lbLogPass;
        private System.Windows.Forms.Button btLogLogin;
        private System.Windows.Forms.LinkLabel linklbNoAccount;
        private System.Windows.Forms.LinkLabel linklbForgotPass;
    }
}
