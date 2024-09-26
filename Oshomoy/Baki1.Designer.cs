namespace Oshomoy
{
    partial class Baki1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baki1));
            this.lbWarnBakiAmount = new System.Windows.Forms.Label();
            this.tbBakiAmount = new System.Windows.Forms.TextBox();
            this.lblBakiAmount = new System.Windows.Forms.Button();
            this.lbWarnBakiPhone = new System.Windows.Forms.Label();
            this.btBakiNext = new System.Windows.Forms.Button();
            this.lblBakiPhoneNumber = new System.Windows.Forms.Label();
            this.tbBakiPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWarnBakiAmount
            // 
            this.lbWarnBakiAmount.AutoSize = true;
            this.lbWarnBakiAmount.BackColor = System.Drawing.Color.White;
            this.lbWarnBakiAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWarnBakiAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarnBakiAmount.ForeColor = System.Drawing.Color.Red;
            this.lbWarnBakiAmount.Location = new System.Drawing.Point(463, 275);
            this.lbWarnBakiAmount.Name = "lbWarnBakiAmount";
            this.lbWarnBakiAmount.Size = new System.Drawing.Size(69, 19);
            this.lbWarnBakiAmount.TabIndex = 25;
            this.lbWarnBakiAmount.Text = "Test Text";
            // 
            // tbBakiAmount
            // 
            this.tbBakiAmount.Location = new System.Drawing.Point(457, 250);
            this.tbBakiAmount.Name = "tbBakiAmount";
            this.tbBakiAmount.Size = new System.Drawing.Size(180, 22);
            this.tbBakiAmount.TabIndex = 24;
            // 
            // lblBakiAmount
            // 
            this.lblBakiAmount.Location = new System.Drawing.Point(357, 249);
            this.lblBakiAmount.Name = "lblBakiAmount";
            this.lblBakiAmount.Size = new System.Drawing.Size(75, 23);
            this.lblBakiAmount.TabIndex = 23;
            this.lblBakiAmount.Text = "Amount";
            this.lblBakiAmount.UseVisualStyleBackColor = true;
            // 
            // lbWarnBakiPhone
            // 
            this.lbWarnBakiPhone.AutoSize = true;
            this.lbWarnBakiPhone.BackColor = System.Drawing.Color.White;
            this.lbWarnBakiPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWarnBakiPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarnBakiPhone.ForeColor = System.Drawing.Color.Red;
            this.lbWarnBakiPhone.Location = new System.Drawing.Point(463, 202);
            this.lbWarnBakiPhone.Name = "lbWarnBakiPhone";
            this.lbWarnBakiPhone.Size = new System.Drawing.Size(69, 19);
            this.lbWarnBakiPhone.TabIndex = 22;
            this.lbWarnBakiPhone.Text = "Test Text";
            // 
            // btBakiNext
            // 
            this.btBakiNext.Location = new System.Drawing.Point(457, 331);
            this.btBakiNext.Name = "btBakiNext";
            this.btBakiNext.Size = new System.Drawing.Size(75, 23);
            this.btBakiNext.TabIndex = 21;
            this.btBakiNext.Text = "Next";
            this.btBakiNext.UseVisualStyleBackColor = true;
            this.btBakiNext.Click += new System.EventHandler(this.btBakiNext_Click);
            // 
            // lblBakiPhoneNumber
            // 
            this.lblBakiPhoneNumber.AutoSize = true;
            this.lblBakiPhoneNumber.Location = new System.Drawing.Point(354, 177);
            this.lblBakiPhoneNumber.Name = "lblBakiPhoneNumber";
            this.lblBakiPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lblBakiPhoneNumber.TabIndex = 20;
            this.lblBakiPhoneNumber.Text = "Phone Number";
            // 
            // tbBakiPhoneNumber
            // 
            this.tbBakiPhoneNumber.Location = new System.Drawing.Point(457, 177);
            this.tbBakiPhoneNumber.Multiline = true;
            this.tbBakiPhoneNumber.Name = "tbBakiPhoneNumber";
            this.tbBakiPhoneNumber.Size = new System.Drawing.Size(190, 22);
            this.tbBakiPhoneNumber.TabIndex = 19;
            // 
            // Baki1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.lbWarnBakiAmount);
            this.Controls.Add(this.tbBakiAmount);
            this.Controls.Add(this.lblBakiAmount);
            this.Controls.Add(this.lbWarnBakiPhone);
            this.Controls.Add(this.btBakiNext);
            this.Controls.Add(this.lblBakiPhoneNumber);
            this.Controls.Add(this.tbBakiPhoneNumber);
            this.DoubleBuffered = true;
            this.Name = "Baki1";
            this.Size = new System.Drawing.Size(1000, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWarnBakiAmount;
        private System.Windows.Forms.TextBox tbBakiAmount;
        private System.Windows.Forms.Button lblBakiAmount;
        private System.Windows.Forms.Label lbWarnBakiPhone;
        private System.Windows.Forms.Button btBakiNext;
        private System.Windows.Forms.Label lblBakiPhoneNumber;
        private System.Windows.Forms.TextBox tbBakiPhoneNumber;
    }
}
