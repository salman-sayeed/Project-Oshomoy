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
            this.admPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // admPanel
            // 
            this.admPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.admPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.admPanel.Location = new System.Drawing.Point(0, 0);
            this.admPanel.Name = "admPanel";
            this.admPanel.Size = new System.Drawing.Size(248, 500);
            this.admPanel.TabIndex = 0;
            // 
            // AdminDb
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.admPanel);
            this.Name = "AdminDb";
            this.Size = new System.Drawing.Size(1000, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admPanel;
    }
}
