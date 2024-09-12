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
            this.logPanel = new System.Windows.Forms.Panel();
            this.loginImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.logPanel.Location = new System.Drawing.Point(668, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(332, 500);
            this.logPanel.TabIndex = 0;
            this.logPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logPanel_Paint_1);
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
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.logPanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.PictureBox loginImage;
    }
}
