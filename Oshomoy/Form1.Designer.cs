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
            this.login1 = new Oshomoy.Login();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBox.BackgroundImage")));
            this.closeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBox.Location = new System.Drawing.Point(964, 6);
            this.closeBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(19, 20);
            this.closeBox.TabIndex = 1;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBox.BackgroundImage")));
            this.minimizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBox.Location = new System.Drawing.Point(928, 6);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(19, 20);
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
            this.lblTitle.Location = new System.Drawing.Point(28, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "OSHOMOY";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.minimizeBox);
            this.topPanel.Controls.Add(this.closeBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1000, 31);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // login1
            // 
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.ForeColor = System.Drawing.SystemColors.Control;
            this.login1.Location = new System.Drawing.Point(0, 31);
            this.login1.Margin = new System.Windows.Forms.Padding(4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1000, 469);
            this.login1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel topPanel;
        private Login login1;
    }
}

