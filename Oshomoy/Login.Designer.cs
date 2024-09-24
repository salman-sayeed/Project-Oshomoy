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
            System.Windows.Forms.Button btLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.logPanel = new System.Windows.Forms.Panel();
            this.linkedIn = new System.Windows.Forms.PictureBox();
            this.faceBook = new System.Windows.Forms.PictureBox();
            this.gitHub = new System.Windows.Forms.PictureBox();
            this.paassImg2 = new System.Windows.Forms.PictureBox();
            this.paassImg = new System.Windows.Forms.PictureBox();
            this.lbWarn2 = new System.Windows.Forms.Label();
            this.lbWarn1 = new System.Windows.Forms.Label();
            this.lbWelcometext = new System.Windows.Forms.Label();
            this.lbLinkSign = new System.Windows.Forms.LinkLabel();
            this.lbForgPass = new System.Windows.Forms.LinkLabel();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbGetStart = new System.Windows.Forms.Label();
            this.loginImage = new System.Windows.Forms.PictureBox();
            btLogin = new System.Windows.Forms.Button();
            this.logPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paassImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paassImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btLogin.ForeColor = System.Drawing.Color.White;
            btLogin.Location = new System.Drawing.Point(61, 321);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(223, 42);
            btLogin.TabIndex = 2;
            btLogin.Text = "Sign In";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.White;
            this.logPanel.Controls.Add(this.linkedIn);
            this.logPanel.Controls.Add(this.faceBook);
            this.logPanel.Controls.Add(this.gitHub);
            this.logPanel.Controls.Add(this.paassImg2);
            this.logPanel.Controls.Add(this.paassImg);
            this.logPanel.Controls.Add(this.lbWarn2);
            this.logPanel.Controls.Add(this.lbWarn1);
            this.logPanel.Controls.Add(this.lbWelcometext);
            this.logPanel.Controls.Add(this.lbLinkSign);
            this.logPanel.Controls.Add(this.lbForgPass);
            this.logPanel.Controls.Add(btLogin);
            this.logPanel.Controls.Add(this.lbPass);
            this.logPanel.Controls.Add(this.tbPassword);
            this.logPanel.Controls.Add(this.lbUsername);
            this.logPanel.Controls.Add(this.tbUsername);
            this.logPanel.Controls.Add(this.lbGetStart);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.logPanel.Location = new System.Drawing.Point(662, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(332, 503);
            this.logPanel.TabIndex = 0;
            // 
            // linkedIn
            // 
            this.linkedIn.BackColor = System.Drawing.Color.White;
            this.linkedIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("linkedIn.BackgroundImage")));
            this.linkedIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.linkedIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedIn.Location = new System.Drawing.Point(213, 455);
            this.linkedIn.Name = "linkedIn";
            this.linkedIn.Size = new System.Drawing.Size(25, 25);
            this.linkedIn.TabIndex = 21;
            this.linkedIn.TabStop = false;
            this.linkedIn.Click += new System.EventHandler(this.linkedIn_Click);
            // 
            // faceBook
            // 
            this.faceBook.BackColor = System.Drawing.Color.White;
            this.faceBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("faceBook.BackgroundImage")));
            this.faceBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.faceBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faceBook.Location = new System.Drawing.Point(169, 455);
            this.faceBook.Name = "faceBook";
            this.faceBook.Size = new System.Drawing.Size(25, 25);
            this.faceBook.TabIndex = 20;
            this.faceBook.TabStop = false;
            this.faceBook.Click += new System.EventHandler(this.faceBook_Click);
            // 
            // gitHub
            // 
            this.gitHub.BackColor = System.Drawing.Color.White;
            this.gitHub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gitHub.BackgroundImage")));
            this.gitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitHub.Location = new System.Drawing.Point(125, 455);
            this.gitHub.Name = "gitHub";
            this.gitHub.Size = new System.Drawing.Size(25, 25);
            this.gitHub.TabIndex = 19;
            this.gitHub.TabStop = false;
            this.gitHub.Click += new System.EventHandler(this.gitHub_Click);
            // 
            // paassImg2
            // 
            this.paassImg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paassImg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paassImg2.BackgroundImage")));
            this.paassImg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paassImg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paassImg2.Location = new System.Drawing.Point(264, 248);
            this.paassImg2.Name = "paassImg2";
            this.paassImg2.Size = new System.Drawing.Size(25, 25);
            this.paassImg2.TabIndex = 18;
            this.paassImg2.TabStop = false;
            this.paassImg2.Click += new System.EventHandler(this.paassImg2_Click);
            // 
            // paassImg
            // 
            this.paassImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paassImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paassImg.BackgroundImage")));
            this.paassImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paassImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paassImg.Location = new System.Drawing.Point(264, 248);
            this.paassImg.Name = "paassImg";
            this.paassImg.Size = new System.Drawing.Size(25, 25);
            this.paassImg.TabIndex = 17;
            this.paassImg.TabStop = false;
            this.paassImg.Click += new System.EventHandler(this.paassImg_Click);
            // 
            // lbWarn2
            // 
            this.lbWarn2.AutoSize = true;
            this.lbWarn2.BackColor = System.Drawing.Color.White;
            this.lbWarn2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarn2.ForeColor = System.Drawing.Color.Red;
            this.lbWarn2.Location = new System.Drawing.Point(42, 278);
            this.lbWarn2.Name = "lbWarn2";
            this.lbWarn2.Size = new System.Drawing.Size(69, 19);
            this.lbWarn2.TabIndex = 15;
            this.lbWarn2.Text = "Test Text";
            // 
            // lbWarn1
            // 
            this.lbWarn1.AutoSize = true;
            this.lbWarn1.BackColor = System.Drawing.Color.White;
            this.lbWarn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWarn1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarn1.ForeColor = System.Drawing.Color.Red;
            this.lbWarn1.Location = new System.Drawing.Point(42, 197);
            this.lbWarn1.Name = "lbWarn1";
            this.lbWarn1.Size = new System.Drawing.Size(69, 19);
            this.lbWarn1.TabIndex = 14;
            this.lbWarn1.Text = "Test Text";
            // 
            // lbWelcometext
            // 
            this.lbWelcometext.AutoSize = true;
            this.lbWelcometext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcometext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbWelcometext.Location = new System.Drawing.Point(84, 85);
            this.lbWelcometext.Name = "lbWelcometext";
            this.lbWelcometext.Size = new System.Drawing.Size(212, 20);
            this.lbWelcometext.TabIndex = 11;
            this.lbWelcometext.Text = "We are happy to see you.";
            // 
            // lbLinkSign
            // 
            this.lbLinkSign.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbLinkSign.AutoSize = true;
            this.lbLinkSign.BackColor = System.Drawing.Color.Transparent;
            this.lbLinkSign.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbLinkSign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbLinkSign.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbLinkSign.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbLinkSign.Location = new System.Drawing.Point(57, 418);
            this.lbLinkSign.Name = "lbLinkSign";
            this.lbLinkSign.Size = new System.Drawing.Size(279, 20);
            this.lbLinkSign.TabIndex = 5;
            this.lbLinkSign.TabStop = true;
            this.lbLinkSign.Text = "Don\'t have an account? Register!";
            this.lbLinkSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbForgPass
            // 
            this.lbForgPass.ActiveLinkColor = System.Drawing.Color.White;
            this.lbForgPass.AutoSize = true;
            this.lbForgPass.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbForgPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbForgPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbForgPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbForgPass.Location = new System.Drawing.Point(98, 382);
            this.lbForgPass.Name = "lbForgPass";
            this.lbForgPass.Size = new System.Drawing.Size(158, 20);
            this.lbForgPass.TabIndex = 4;
            this.lbForgPass.TabStop = true;
            this.lbForgPass.Text = "Forgot password?";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbPass.Location = new System.Drawing.Point(42, 221);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(107, 23);
            this.lbPass.TabIndex = 13;
            this.lbPass.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(45, 245);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(250, 30);
            this.tbPassword.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(109)))));
            this.lbUsername.Location = new System.Drawing.Point(42, 141);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(111, 23);
            this.lbUsername.TabIndex = 12;
            this.lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(45, 165);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(250, 30);
            this.tbUsername.TabIndex = 0;
            // 
            // lbGetStart
            // 
            this.lbGetStart.AutoSize = true;
            this.lbGetStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGetStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.lbGetStart.Location = new System.Drawing.Point(37, 47);
            this.lbGetStart.Name = "lbGetStart";
            this.lbGetStart.Size = new System.Drawing.Size(338, 49);
            this.lbGetStart.TabIndex = 10;
            this.lbGetStart.Text = "Welcome Back!";
            // 
            // loginImage
            // 
            this.loginImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginImage.BackgroundImage")));
            this.loginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginImage.Location = new System.Drawing.Point(0, 0);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(662, 503);
            this.loginImage.TabIndex = 1;
            this.loginImage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.logPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(994, 503);
            this.Load += new System.EventHandler(this.Login_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paassImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paassImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.Label lbGetStart;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.LinkLabel lbForgPass;
        private System.Windows.Forms.LinkLabel lbLinkSign;
        private System.Windows.Forms.Label lbWelcometext;
        private System.Windows.Forms.Label lbWarn1;
        private System.Windows.Forms.Label lbWarn2;
        private System.Windows.Forms.PictureBox paassImg;
        private System.Windows.Forms.PictureBox paassImg2;
        private System.Windows.Forms.PictureBox gitHub;
        private System.Windows.Forms.PictureBox linkedIn;
        private System.Windows.Forms.PictureBox faceBook;
    }
}
