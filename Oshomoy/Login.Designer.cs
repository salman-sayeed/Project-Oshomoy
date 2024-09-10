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
            this.tbLogUsername = new System.Windows.Forms.TextBox();
            this.lbLogUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog1 = new System.Windows.Forms.Label();
            this.tbLogPass = new System.Windows.Forms.TextBox();
            this.lbLogPass = new System.Windows.Forms.Label();
            this.btLogLogin = new System.Windows.Forms.Button();
            this.linklbNoAccount = new System.Windows.Forms.LinkLabel();
            this.linklbForgotPass = new System.Windows.Forms.LinkLabel();
            this.logPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.Controls.Add(this.linklbForgotPass);
            this.logPanel.Controls.Add(this.linklbNoAccount);
            this.logPanel.Controls.Add(this.btLogLogin);
            this.logPanel.Controls.Add(this.tbLogPass);
            this.logPanel.Controls.Add(this.lbLogPass);
            this.logPanel.Controls.Add(this.tbLogUsername);
            this.logPanel.Controls.Add(this.lbLogUsername);
            this.logPanel.Controls.Add(this.label1);
            this.logPanel.Controls.Add(this.lbLog1);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.Location = new System.Drawing.Point(875, 0);
            this.logPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(757, 659);
            this.logPanel.TabIndex = 0;
            // 
            // tbLogUsername
            // 
            this.tbLogUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLogUsername.Location = new System.Drawing.Point(32, 156);
            this.tbLogUsername.Multiline = true;
            this.tbLogUsername.Name = "tbLogUsername";
            this.tbLogUsername.Size = new System.Drawing.Size(305, 31);
            this.tbLogUsername.TabIndex = 3;
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
            this.lbLog1.Size = new System.Drawing.Size(204, 38);
            this.lbLog1.TabIndex = 0;
            this.lbLog1.Text = "Get Started";
            // 
            // tbLogPass
            // 
            this.tbLogPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLogPass.Location = new System.Drawing.Point(32, 229);
            this.tbLogPass.Multiline = true;
            this.tbLogPass.Name = "tbLogPass";
            this.tbLogPass.Size = new System.Drawing.Size(305, 31);
            this.tbLogPass.TabIndex = 5;
            // 
            // lbLogPass
            // 
            this.lbLogPass.AutoSize = true;
            this.lbLogPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLogPass.Location = new System.Drawing.Point(28, 206);
            this.lbLogPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogPass.Name = "lbLogPass";
            this.lbLogPass.Size = new System.Drawing.Size(90, 20);
            this.lbLogPass.TabIndex = 4;
            this.lbLogPass.Text = "Password";
            // 
            // btLogLogin
            // 
            this.btLogLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btLogLogin.Location = new System.Drawing.Point(109, 288);
            this.btLogLogin.Name = "btLogLogin";
            this.btLogLogin.Size = new System.Drawing.Size(168, 46);
            this.btLogLogin.TabIndex = 6;
            this.btLogLogin.Text = "Login";
            this.btLogLogin.UseVisualStyleBackColor = true;
            // 
            // linklbNoAccount
            // 
            this.linklbNoAccount.AutoSize = true;
            this.linklbNoAccount.BackColor = System.Drawing.SystemColors.Control;
            this.linklbNoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbNoAccount.LinkColor = System.Drawing.Color.Gray;
            this.linklbNoAccount.Location = new System.Drawing.Point(118, 397);
            this.linklbNoAccount.Name = "linklbNoAccount";
            this.linklbNoAccount.Size = new System.Drawing.Size(199, 20);
            this.linklbNoAccount.TabIndex = 9;
            this.linklbNoAccount.TabStop = true;
            this.linklbNoAccount.Text = "Don\'t have an account?";
            // 
            // linklbForgotPass
            // 
            this.linklbForgotPass.AutoSize = true;
            this.linklbForgotPass.BackColor = System.Drawing.SystemColors.Control;
            this.linklbForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbForgotPass.LinkColor = System.Drawing.Color.Gray;
            this.linklbForgotPass.Location = new System.Drawing.Point(132, 360);
            this.linklbForgotPass.Name = "linklbForgotPass";
            this.linklbForgotPass.Size = new System.Drawing.Size(148, 20);
            this.linklbForgotPass.TabIndex = 10;
            this.linklbForgotPass.TabStop = true;
            this.linklbForgotPass.Text = "Forgot Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 659);
            this.Controls.Add(this.logPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
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
        private System.Windows.Forms.TextBox tbLogUsername;
        private System.Windows.Forms.TextBox tbLogPass;
        private System.Windows.Forms.Label lbLogPass;
        private System.Windows.Forms.Button btLogLogin;
        private System.Windows.Forms.LinkLabel linklbNoAccount;
        private System.Windows.Forms.LinkLabel linklbForgotPass;
    }
}
