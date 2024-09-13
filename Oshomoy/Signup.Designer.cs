namespace Oshomoy
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            System.Windows.Forms.Button btRegister;
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.logPanel = new System.Windows.Forms.Panel();
            this.lbWelcometext = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbSignPass = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbSignUserName = new System.Windows.Forms.TextBox();
            this.lbGetStart = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            btRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.logPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginImage
            // 
            this.loginImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginImage.BackgroundImage")));
            this.loginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginImage.Location = new System.Drawing.Point(0, 0);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(668, 500);
            this.loginImage.TabIndex = 3;
            this.loginImage.TabStop = false;
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.logPanel.Controls.Add(this.lbConfirmPass);
            this.logPanel.Controls.Add(this.tbConfirmPass);
            this.logPanel.Controls.Add(this.lbEmail);
            this.logPanel.Controls.Add(this.textBox1);
            this.logPanel.Controls.Add(this.lbWelcometext);
            this.logPanel.Controls.Add(this.linkLabel1);
            this.logPanel.Controls.Add(btRegister);
            this.logPanel.Controls.Add(this.lbPass);
            this.logPanel.Controls.Add(this.tbSignPass);
            this.logPanel.Controls.Add(this.lbUsername);
            this.logPanel.Controls.Add(this.tbSignUserName);
            this.logPanel.Controls.Add(this.lbGetStart);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.logPanel.Location = new System.Drawing.Point(668, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(332, 500);
            this.logPanel.TabIndex = 2;
            // 
            // lbWelcometext
            // 
            this.lbWelcometext.AutoSize = true;
            this.lbWelcometext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcometext.ForeColor = System.Drawing.Color.White;
            this.lbWelcometext.Location = new System.Drawing.Point(95, 54);
            this.lbWelcometext.Name = "lbWelcometext";
            this.lbWelcometext.Size = new System.Drawing.Size(140, 15);
            this.lbWelcometext.TabIndex = 9;
            this.lbWelcometext.Text = "Create your account";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(70, 452);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(211, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an accoun? Login.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btRegister
            // 
            btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            btRegister.FlatAppearance.BorderSize = 0;
            btRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            btRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btRegister.ForeColor = System.Drawing.Color.White;
            btRegister.Location = new System.Drawing.Point(61, 394);
            btRegister.Name = "btRegister";
            btRegister.Size = new System.Drawing.Size(223, 42);
            btRegister.TabIndex = 6;
            btRegister.Text = "Sign Up";
            btRegister.UseVisualStyleBackColor = false;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(42, 228);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(87, 18);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password";
            // 
            // tbSignPass
            // 
            this.tbSignPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSignPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSignPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignPass.Location = new System.Drawing.Point(45, 255);
            this.tbSignPass.Multiline = true;
            this.tbSignPass.Name = "tbSignPass";
            this.tbSignPass.PasswordChar = '•';
            this.tbSignPass.Size = new System.Drawing.Size(250, 30);
            this.tbSignPass.TabIndex = 3;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(42, 89);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(90, 18);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // tbSignUserName
            // 
            this.tbSignUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSignUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSignUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUserName.Location = new System.Drawing.Point(45, 116);
            this.tbSignUserName.Multiline = true;
            this.tbSignUserName.Name = "tbSignUserName";
            this.tbSignUserName.Size = new System.Drawing.Size(250, 30);
            this.tbSignUserName.TabIndex = 1;
            // 
            // lbGetStart
            // 
            this.lbGetStart.AutoSize = true;
            this.lbGetStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGetStart.ForeColor = System.Drawing.Color.White;
            this.lbGetStart.Location = new System.Drawing.Point(72, 19);
            this.lbGetStart.Name = "lbGetStart";
            this.lbGetStart.Size = new System.Drawing.Size(186, 34);
            this.lbGetStart.TabIndex = 0;
            this.lbGetStart.Text = "Get Started";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(40, 157);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 18);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 10;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.ForeColor = System.Drawing.Color.White;
            this.lbConfirmPass.Location = new System.Drawing.Point(40, 298);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(87, 18);
            this.lbConfirmPass.TabIndex = 13;
            this.lbConfirmPass.Text = "Password";
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPass.Location = new System.Drawing.Point(43, 325);
            this.tbConfirmPass.Multiline = true;
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '•';
            this.tbConfirmPass.Size = new System.Drawing.Size(250, 30);
            this.tbConfirmPass.TabIndex = 12;
            // 
            // Signup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.logPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(1000, 500);
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label lbWelcometext;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbSignPass;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbSignUserName;
        private System.Windows.Forms.Label lbGetStart;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.TextBox tbConfirmPass;
    }
}
