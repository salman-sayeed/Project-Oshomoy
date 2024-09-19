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
            this.showUsername = new System.Windows.Forms.Label();
            this.showEmail = new System.Windows.Forms.Label();
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
            this.admPanel.Size = new System.Drawing.Size(248, 500);
            this.admPanel.TabIndex = 0;
            // 
            // admPfp
            // 
            this.admPfp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admPfp.BackgroundImage")));
            this.admPfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.admPfp.ErrorImage = null;
            this.admPfp.Location = new System.Drawing.Point(20, 20);
            this.admPfp.Name = "admPfp";
            this.admPfp.Size = new System.Drawing.Size(80, 80);
            this.admPfp.TabIndex = 0;
            this.admPfp.TabStop = false;
            // 
            // showUsername
            // 
            this.showUsername.AutoSize = true;
            this.showUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsername.ForeColor = System.Drawing.Color.White;
            this.showUsername.Location = new System.Drawing.Point(106, 33);
            this.showUsername.Name = "showUsername";
            this.showUsername.Size = new System.Drawing.Size(90, 18);
            this.showUsername.TabIndex = 1;
            this.showUsername.Text = "Username";
            // 
            // showEmail
            // 
            this.showEmail.AutoSize = true;
            this.showEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEmail.ForeColor = System.Drawing.Color.White;
            this.showEmail.Location = new System.Drawing.Point(106, 51);
            this.showEmail.Name = "showEmail";
            this.showEmail.Size = new System.Drawing.Size(105, 16);
            this.showEmail.TabIndex = 2;
            this.showEmail.Text = "user@email.com";
            // 
            // AdminDb
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.admPanel);
            this.Name = "AdminDb";
            this.Size = new System.Drawing.Size(1000, 500);
            this.admPanel.ResumeLayout(false);
            this.admPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admPfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admPanel;
        private System.Windows.Forms.PictureBox admPfp;
        private System.Windows.Forms.Label showUsername;
        private System.Windows.Forms.Label showEmail;
    }
}
