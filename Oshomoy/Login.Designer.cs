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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            System.Windows.Forms.Button btLogin;
            this.logPanel = new System.Windows.Forms.Panel();
            this.lbGetStart = new System.Windows.Forms.Label();
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbLogin2 = new System.Windows.Forms.TextBox();
            this.lbForgPass = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbWelcometext = new System.Windows.Forms.Label();
            btLogin = new System.Windows.Forms.Button();
            this.logPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.logPanel.Controls.Add(this.lbWelcometext);
            this.logPanel.Controls.Add(this.linkLabel1);
            this.logPanel.Controls.Add(this.lbForgPass);
            this.logPanel.Controls.Add(btLogin);
            this.logPanel.Controls.Add(this.lbPass);
            this.logPanel.Controls.Add(this.tbLogin2);
            this.logPanel.Controls.Add(this.lbUsername);
            this.logPanel.Controls.Add(this.tbLogin);
            this.logPanel.Controls.Add(this.lbGetStart);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.logPanel.Location = new System.Drawing.Point(668, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(332, 500);
            this.logPanel.TabIndex = 0;
            this.logPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logPanel_Paint_1);
            // 
            // lbGetStart
            // 
            this.lbGetStart.AutoSize = true;
            this.lbGetStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGetStart.ForeColor = System.Drawing.Color.White;
            this.lbGetStart.Location = new System.Drawing.Point(46, 49);
            this.lbGetStart.Name = "lbGetStart";
            this.lbGetStart.Size = new System.Drawing.Size(243, 34);
            this.lbGetStart.TabIndex = 0;
            this.lbGetStart.Text = "Welcome Back!";
            // 
            // loginImage
            // 
            this.loginImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginImage.BackgroundImage")));
            this.loginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginImage.Location = new System.Drawing.Point(0, 0);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(668, 500);
            this.loginImage.TabIndex = 1;
            this.loginImage.TabStop = false;
            this.loginImage.Click += new System.EventHandler(this.loginImage_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(45, 165);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(250, 30);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(42, 138);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(90, 18);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(42, 218);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(87, 18);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password";
            // 
            // tbLogin2
            // 
            this.tbLogin2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLogin2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin2.Location = new System.Drawing.Point(45, 245);
            this.tbLogin2.Multiline = true;
            this.tbLogin2.Name = "tbLogin2";
            this.tbLogin2.PasswordChar = '•';
            this.tbLogin2.Size = new System.Drawing.Size(250, 30);
            this.tbLogin2.TabIndex = 3;
            // 
            // btLogin
            // 
            btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btLogin.ForeColor = System.Drawing.Color.White;
            btLogin.Location = new System.Drawing.Point(61, 310);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(223, 42);
            btLogin.TabIndex = 6;
            btLogin.Text = "Sign In";
            btLogin.UseVisualStyleBackColor = false;
            // 
            // lbForgPass
            // 
            this.lbForgPass.ActiveLinkColor = System.Drawing.Color.White;
            this.lbForgPass.AutoSize = true;
            this.lbForgPass.ForeColor = System.Drawing.Color.White;
            this.lbForgPass.LinkColor = System.Drawing.Color.White;
            this.lbForgPass.Location = new System.Drawing.Point(111, 367);
            this.lbForgPass.Name = "lbForgPass";
            this.lbForgPass.Size = new System.Drawing.Size(130, 16);
            this.lbForgPass.TabIndex = 7;
            this.lbForgPass.TabStop = true;
            this.lbForgPass.Text = "Forgot password?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(65, 416);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(219, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an accoun? Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbWelcometext
            // 
            this.lbWelcometext.AutoSize = true;
            this.lbWelcometext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcometext.ForeColor = System.Drawing.Color.White;
            this.lbWelcometext.Location = new System.Drawing.Point(79, 84);
            this.lbWelcometext.Name = "lbWelcometext";
            this.lbWelcometext.Size = new System.Drawing.Size(166, 15);
            this.lbWelcometext.TabIndex = 9;
            this.lbWelcometext.Text = "We are happy to see you.";
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
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.Login_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.Label lbGetStart;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbLogin2;
        private System.Windows.Forms.LinkLabel lbForgPass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbWelcometext;
    }
}
