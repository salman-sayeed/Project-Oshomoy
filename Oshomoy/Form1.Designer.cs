namespace Oshomoy
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.signup1 = new Oshomoy.Signup();
            this.login1 = new Oshomoy.Login();
            this.adminDb1 = new Oshomoy.AdminDb();
            this.signup2 = new Oshomoy.Signup();
            this.login2 = new Oshomoy.Login();
            this.adminDb2 = new Oshomoy.AdminDb();
            this.dashboard1 = new Oshomoy.Dashboard();
            this.login3 = new Oshomoy.Login();
            this.signup3 = new Oshomoy.Signup();
            this.adminDb3 = new Oshomoy.AdminDb();
            this.signup4 = new Oshomoy.Signup();
            this.login4 = new Oshomoy.Login();
            this.dashboard2 = new Oshomoy.Dashboard();
            this.login5 = new Oshomoy.Login();
            this.signup5 = new Oshomoy.Signup();
            this.adminDb4 = new Oshomoy.AdminDb();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBox.BackgroundImage")));
            this.closeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBox.Location = new System.Drawing.Point(962, 6);
            this.closeBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 1;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBox.BackgroundImage")));
            this.minimizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBox.Location = new System.Drawing.Point(923, 6);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(20, 20);
            this.minimizeBox.TabIndex = 2;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "OSHOMOY";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.minimizeBox);
            this.topPanel.Controls.Add(this.closeBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1000, 30);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // signup1
            // 
            this.signup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup1.ForeColor = System.Drawing.Color.White;
            this.signup1.Location = new System.Drawing.Point(0, 0);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(1000, 530);
            this.signup1.TabIndex = 2;
            // 
            // login1
            // 
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.ForeColor = System.Drawing.SystemColors.Control;
            this.login1.Location = new System.Drawing.Point(0, 30);
            this.login1.Margin = new System.Windows.Forms.Padding(4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1000, 500);
            this.login1.TabIndex = 1;
            this.login1.Load += new System.EventHandler(this.login1_Load_2);
            // 
            // adminDb1
            // 
            this.adminDb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDb1.Location = new System.Drawing.Point(0, 30);
            this.adminDb1.Name = "adminDb1";
            this.adminDb1.Size = new System.Drawing.Size(1000, 500);
            this.adminDb1.TabIndex = 3;
            // 
            // signup2
            // 
            this.signup2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup2.ForeColor = System.Drawing.Color.White;
            this.signup2.Location = new System.Drawing.Point(12, 105);
            this.signup2.Name = "signup2";
            this.signup2.Size = new System.Drawing.Size(1000, 500);
            this.signup2.TabIndex = 4;
            // 
            // login2
            // 
            this.login2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login2.ForeColor = System.Drawing.SystemColors.Control;
            this.login2.Location = new System.Drawing.Point(0, 30);
            this.login2.Margin = new System.Windows.Forms.Padding(4);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(1000, 500);
            this.login2.TabIndex = 5;
            // 
            // adminDb2
            // 
            this.adminDb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDb2.Location = new System.Drawing.Point(0, 30);
            this.adminDb2.Name = "adminDb2";
            this.adminDb2.Size = new System.Drawing.Size(1000, 500);
            this.adminDb2.TabIndex = 6;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.Control;
            this.dashboard1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1000, 500);
            this.dashboard1.TabIndex = 7;
            // 
            // login3
            // 
            this.login3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login3.ForeColor = System.Drawing.SystemColors.Control;
            this.login3.Location = new System.Drawing.Point(0, 0);
            this.login3.Margin = new System.Windows.Forms.Padding(4);
            this.login3.Name = "login3";
            this.login3.Size = new System.Drawing.Size(1000, 500);
            this.login3.TabIndex = 8;
            // 
            // signup3
            // 
            this.signup3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup3.ForeColor = System.Drawing.Color.White;
            this.signup3.Location = new System.Drawing.Point(0, 0);
            this.signup3.Name = "signup3";
            this.signup3.Size = new System.Drawing.Size(1000, 500);
            this.signup3.TabIndex = 9;
            // 
            // adminDb3
            // 
            this.adminDb3.Location = new System.Drawing.Point(0, 0);
            this.adminDb3.Name = "adminDb3";
            this.adminDb3.Size = new System.Drawing.Size(1000, 500);
            this.adminDb3.TabIndex = 10;
            // 
            // signup4
            // 
            this.signup4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup4.ForeColor = System.Drawing.Color.White;
            this.signup4.Location = new System.Drawing.Point(0, 30);
            this.signup4.Name = "signup4";
            this.signup4.Size = new System.Drawing.Size(1000, 500);
            this.signup4.TabIndex = 11;
            // 
            // login4
            // 
            this.login4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login4.ForeColor = System.Drawing.SystemColors.Control;
            this.login4.Location = new System.Drawing.Point(0, 30);
            this.login4.Margin = new System.Windows.Forms.Padding(4);
            this.login4.Name = "login4";
            this.login4.Size = new System.Drawing.Size(1000, 500);
            this.login4.TabIndex = 12;
            // 
            // dashboard2
            // 
            this.dashboard2.BackColor = System.Drawing.SystemColors.Control;
            this.dashboard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard2.Location = new System.Drawing.Point(0, 30);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(1000, 500);
            this.dashboard2.TabIndex = 13;
            // 
            // login5
            // 
            this.login5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login5.ForeColor = System.Drawing.SystemColors.Control;
            this.login5.Location = new System.Drawing.Point(0, 30);
            this.login5.Margin = new System.Windows.Forms.Padding(4);
            this.login5.Name = "login5";
            this.login5.Size = new System.Drawing.Size(1000, 500);
            this.login5.TabIndex = 14;
            // 
            // signup5
            // 
            this.signup5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup5.ForeColor = System.Drawing.Color.White;
            this.signup5.Location = new System.Drawing.Point(0, 30);
            this.signup5.Name = "signup5";
            this.signup5.Size = new System.Drawing.Size(1000, 500);
            this.signup5.TabIndex = 15;
            // 
            // adminDb4
            // 
            this.adminDb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDb4.Location = new System.Drawing.Point(0, 30);
            this.adminDb4.Name = "adminDb4";
            this.adminDb4.Size = new System.Drawing.Size(1000, 500);
            this.adminDb4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1000, 530);
            this.Controls.Add(this.adminDb4);
            this.Controls.Add(this.signup5);
            this.Controls.Add(this.login5);
            this.Controls.Add(this.dashboard2);
            this.Controls.Add(this.login4);
            this.Controls.Add(this.signup4);
            this.Controls.Add(this.adminDb2);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.signup2);
            this.Controls.Add(this.adminDb1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.signup1);
            this.Controls.Add(this.adminDb3);
            this.Controls.Add(this.signup3);
            this.Controls.Add(this.login3);
            this.Controls.Add(this.dashboard1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel topPanel;
        private Signup signup1;
        private Login login1;
        private AdminDb adminDb1;
        private Signup signup2;
        private Login login2;
        private AdminDb adminDb2;
        private Dashboard dashboard1;
        private Login login3;
        private Signup signup3;
        private AdminDb adminDb3;
        private Signup signup4;
        private Login login4;
        private Dashboard dashboard2;
        private Login login5;
        private Signup signup5;
        private AdminDb adminDb4;
        private System.Windows.Forms.PictureBox logo;
    }
}

