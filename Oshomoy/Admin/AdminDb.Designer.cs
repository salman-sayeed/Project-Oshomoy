namespace Oshomoy
{
    partial class AdminDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDb));
            this.admPanel = new System.Windows.Forms.Panel();
            this.indicator1 = new System.Windows.Forms.Panel();
            this.admBtn1 = new System.Windows.Forms.Button();
            this.btSignout = new System.Windows.Forms.Button();
            this.indicator2 = new System.Windows.Forms.Panel();
            this.admBtn2 = new System.Windows.Forms.Button();
            this.showEmail = new System.Windows.Forms.Button();
            this.showUsername = new System.Windows.Forms.Button();
            this.admPfp = new System.Windows.Forms.PictureBox();
            this.adm2Panel1 = new Oshomoy.Adm2Panel();
            this.adm1Panel1 = new Oshomoy.Admin.Adm1Panel();
            this.admPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admPfp)).BeginInit();
            this.SuspendLayout();
            // 
            // admPanel
            // 
            this.admPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admPanel.Controls.Add(this.indicator1);
            this.admPanel.Controls.Add(this.admBtn1);
            this.admPanel.Controls.Add(this.btSignout);
            this.admPanel.Controls.Add(this.indicator2);
            this.admPanel.Controls.Add(this.admBtn2);
            this.admPanel.Controls.Add(this.showEmail);
            this.admPanel.Controls.Add(this.showUsername);
            this.admPanel.Controls.Add(this.admPfp);
            this.admPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.admPanel.Location = new System.Drawing.Point(0, 0);
            this.admPanel.Name = "admPanel";
            this.admPanel.Size = new System.Drawing.Size(250, 500);
            this.admPanel.TabIndex = 0;
            // 
            // indicator1
            // 
            this.indicator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.indicator1.Location = new System.Drawing.Point(0, 289);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(5, 40);
            this.indicator1.TabIndex = 40;
            // 
            // admBtn1
            // 
            this.admBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn1.FlatAppearance.BorderSize = 0;
            this.admBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admBtn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBtn1.ForeColor = System.Drawing.Color.White;
            this.admBtn1.Image = ((System.Drawing.Image)(resources.GetObject("admBtn1.Image")));
            this.admBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admBtn1.Location = new System.Drawing.Point(0, 289);
            this.admBtn1.Name = "admBtn1";
            this.admBtn1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.admBtn1.Size = new System.Drawing.Size(250, 40);
            this.admBtn1.TabIndex = 39;
            this.admBtn1.TabStop = false;
            this.admBtn1.Text = "     Payments";
            this.admBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admBtn1.UseVisualStyleBackColor = false;
            this.admBtn1.Click += new System.EventHandler(this.admBtn1_Click);
            // 
            // btSignout
            // 
            this.btSignout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.btSignout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.btSignout.FlatAppearance.BorderSize = 0;
            this.btSignout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(179)))));
            this.btSignout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.btSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btSignout.Image = ((System.Drawing.Image)(resources.GetObject("btSignout.Image")));
            this.btSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSignout.Location = new System.Drawing.Point(50, 437);
            this.btSignout.Name = "btSignout";
            this.btSignout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btSignout.Size = new System.Drawing.Size(150, 25);
            this.btSignout.TabIndex = 38;
            this.btSignout.TabStop = false;
            this.btSignout.Text = "      Sign Out";
            this.btSignout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSignout.UseVisualStyleBackColor = false;
            this.btSignout.Click += new System.EventHandler(this.btSignout_Click);
            // 
            // indicator2
            // 
            this.indicator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.indicator2.Location = new System.Drawing.Point(0, 237);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(5, 40);
            this.indicator2.TabIndex = 36;
            // 
            // admBtn2
            // 
            this.admBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn2.FlatAppearance.BorderSize = 0;
            this.admBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admBtn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBtn2.ForeColor = System.Drawing.Color.White;
            this.admBtn2.Image = ((System.Drawing.Image)(resources.GetObject("admBtn2.Image")));
            this.admBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admBtn2.Location = new System.Drawing.Point(0, 237);
            this.admBtn2.Name = "admBtn2";
            this.admBtn2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.admBtn2.Size = new System.Drawing.Size(250, 40);
            this.admBtn2.TabIndex = 33;
            this.admBtn2.TabStop = false;
            this.admBtn2.Text = "     User Control";
            this.admBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admBtn2.UseVisualStyleBackColor = false;
            this.admBtn2.Click += new System.EventHandler(this.admBtn2_Click);
            // 
            // showEmail
            // 
            this.showEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showEmail.FlatAppearance.BorderSize = 0;
            this.showEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEmail.ForeColor = System.Drawing.Color.White;
            this.showEmail.Location = new System.Drawing.Point(3, 176);
            this.showEmail.Name = "showEmail";
            this.showEmail.Size = new System.Drawing.Size(245, 25);
            this.showEmail.TabIndex = 31;
            this.showEmail.TabStop = false;
            this.showEmail.Text = "Email";
            this.showEmail.UseVisualStyleBackColor = true;
            // 
            // showUsername
            // 
            this.showUsername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showUsername.FlatAppearance.BorderSize = 0;
            this.showUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsername.ForeColor = System.Drawing.Color.White;
            this.showUsername.Location = new System.Drawing.Point(3, 150);
            this.showUsername.Name = "showUsername";
            this.showUsername.Size = new System.Drawing.Size(245, 30);
            this.showUsername.TabIndex = 30;
            this.showUsername.TabStop = false;
            this.showUsername.Text = "Username";
            this.showUsername.UseVisualStyleBackColor = true;
            // 
            // admPfp
            // 
            this.admPfp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admPfp.BackgroundImage")));
            this.admPfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.admPfp.ErrorImage = null;
            this.admPfp.Location = new System.Drawing.Point(75, 40);
            this.admPfp.Name = "admPfp";
            this.admPfp.Size = new System.Drawing.Size(100, 100);
            this.admPfp.TabIndex = 0;
            this.admPfp.TabStop = false;
            // 
            // adm2Panel1
            // 
            this.adm2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.adm2Panel1.Location = new System.Drawing.Point(250, 0);
            this.adm2Panel1.Name = "adm2Panel1";
            this.adm2Panel1.Size = new System.Drawing.Size(750, 500);
            this.adm2Panel1.TabIndex = 2;
            // 
            // adm1Panel1
            // 
            this.adm1Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.adm1Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adm1Panel1.Location = new System.Drawing.Point(250, 0);
            this.adm1Panel1.Name = "adm1Panel1";
            this.adm1Panel1.Size = new System.Drawing.Size(750, 500);
            this.adm1Panel1.TabIndex = 3;
            // 
            // AdminDb
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.adm1Panel1);
            this.Controls.Add(this.admPanel);
            this.Controls.Add(this.adm2Panel1);
            this.Name = "AdminDb";
            this.Size = new System.Drawing.Size(1000, 500);
            this.admPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admPfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admPanel;
        private System.Windows.Forms.PictureBox admPfp;
        private System.Windows.Forms.Button showUsername;
        private System.Windows.Forms.Button showEmail;
        private System.Windows.Forms.Button admBtn2;
        private System.Windows.Forms.Panel indicator2;
        private System.Windows.Forms.Button btSignout;
        private Adm2Panel adm2Panel1;
        private System.Windows.Forms.Panel indicator1;
        private System.Windows.Forms.Button admBtn1;
        private Admin.Adm1Panel adm1Panel1;
    }
}
