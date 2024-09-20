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
            this.admPfp = new System.Windows.Forms.PictureBox();
            this.admDbPanel = new System.Windows.Forms.Panel();
            this.showUsername = new System.Windows.Forms.Button();
            this.showEmail = new System.Windows.Forms.Button();
            this.admPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admPfp)).BeginInit();
            this.SuspendLayout();
            // 
            // admPanel
            // 
            this.admPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admPanel.Controls.Add(this.showEmail);
            this.admPanel.Controls.Add(this.showUsername);
            this.admPanel.Controls.Add(this.admPfp);
            this.admPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.admPanel.Location = new System.Drawing.Point(0, 0);
            this.admPanel.Name = "admPanel";
            this.admPanel.Size = new System.Drawing.Size(250, 500);
            this.admPanel.TabIndex = 0;
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
            // admDbPanel
            // 
            this.admDbPanel.BackColor = System.Drawing.Color.DimGray;
            this.admDbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admDbPanel.Location = new System.Drawing.Point(250, 0);
            this.admDbPanel.Name = "admDbPanel";
            this.admDbPanel.Size = new System.Drawing.Size(750, 500);
            this.admDbPanel.TabIndex = 1;
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
            // AdminDb
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.admDbPanel);
            this.Controls.Add(this.admPanel);
            this.Name = "AdminDb";
            this.Size = new System.Drawing.Size(1000, 500);
            this.admPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admPfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admPanel;
        private System.Windows.Forms.PictureBox admPfp;
        private System.Windows.Forms.Panel admDbPanel;
        private System.Windows.Forms.Button showUsername;
        private System.Windows.Forms.Button showEmail;
    }
}
