namespace Oshomoy
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.userMidPanel = new System.Windows.Forms.Panel();
            this.userSidePanel = new System.Windows.Forms.Panel();
            this.showEmail = new System.Windows.Forms.Button();
            this.showUsername = new System.Windows.Forms.Button();
            this.userPfp = new System.Windows.Forms.PictureBox();
            this.userSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPfp)).BeginInit();
            this.SuspendLayout();
            // 
            // userMidPanel
            // 
            this.userMidPanel.BackColor = System.Drawing.Color.DimGray;
            this.userMidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMidPanel.Location = new System.Drawing.Point(250, 0);
            this.userMidPanel.Name = "userMidPanel";
            this.userMidPanel.Size = new System.Drawing.Size(750, 500);
            this.userMidPanel.TabIndex = 3;
            // 
            // userSidePanel
            // 
            this.userSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.userSidePanel.Controls.Add(this.showEmail);
            this.userSidePanel.Controls.Add(this.showUsername);
            this.userSidePanel.Controls.Add(this.userPfp);
            this.userSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userSidePanel.Location = new System.Drawing.Point(0, 0);
            this.userSidePanel.Name = "userSidePanel";
            this.userSidePanel.Size = new System.Drawing.Size(250, 500);
            this.userSidePanel.TabIndex = 2;
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
            // userPfp
            // 
            this.userPfp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPfp.BackgroundImage")));
            this.userPfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userPfp.ErrorImage = null;
            this.userPfp.Location = new System.Drawing.Point(75, 40);
            this.userPfp.Name = "userPfp";
            this.userPfp.Size = new System.Drawing.Size(100, 100);
            this.userPfp.TabIndex = 0;
            this.userPfp.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.userMidPanel);
            this.Controls.Add(this.userSidePanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1000, 500);
            this.userSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userMidPanel;
        private System.Windows.Forms.Panel userSidePanel;
        private System.Windows.Forms.Button showEmail;
        private System.Windows.Forms.Button showUsername;
        private System.Windows.Forms.PictureBox userPfp;
    }
}
