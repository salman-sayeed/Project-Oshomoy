namespace Oshomoy
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tbObonotiPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblObonotiPhoneNumber = new System.Windows.Forms.Label();
            this.btObonotiNext = new System.Windows.Forms.Button();
            this.lbWarnObonotiPhone = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbWarnAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbObonotiPhoneNumber
            // 
            this.tbObonotiPhoneNumber.Location = new System.Drawing.Point(461, 185);
            this.tbObonotiPhoneNumber.Multiline = true;
            this.tbObonotiPhoneNumber.Name = "tbObonotiPhoneNumber";
            this.tbObonotiPhoneNumber.Size = new System.Drawing.Size(190, 22);
            this.tbObonotiPhoneNumber.TabIndex = 0;
            // 
            // lblObonotiPhoneNumber
            // 
            this.lblObonotiPhoneNumber.AutoSize = true;
            this.lblObonotiPhoneNumber.Location = new System.Drawing.Point(358, 188);
            this.lblObonotiPhoneNumber.Name = "lblObonotiPhoneNumber";
            this.lblObonotiPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lblObonotiPhoneNumber.TabIndex = 2;
            this.lblObonotiPhoneNumber.Text = "Phone Number";
            // 
            // btObonotiNext
            // 
            this.btObonotiNext.Location = new System.Drawing.Point(461, 336);
            this.btObonotiNext.Name = "btObonotiNext";
            this.btObonotiNext.Size = new System.Drawing.Size(75, 23);
            this.btObonotiNext.TabIndex = 5;
            this.btObonotiNext.Text = "Next";
            this.btObonotiNext.UseVisualStyleBackColor = true;
            // 
            // lbWarnObonotiPhone
            // 
            this.lbWarnObonotiPhone.AutoSize = true;
            this.lbWarnObonotiPhone.BackColor = System.Drawing.Color.White;
            this.lbWarnObonotiPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWarnObonotiPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarnObonotiPhone.ForeColor = System.Drawing.Color.Red;
            this.lbWarnObonotiPhone.Location = new System.Drawing.Point(467, 210);
            this.lbWarnObonotiPhone.Name = "lbWarnObonotiPhone";
            this.lbWarnObonotiPhone.Size = new System.Drawing.Size(69, 19);
            this.lbWarnObonotiPhone.TabIndex = 15;
            this.lbWarnObonotiPhone.Text = "Test Text";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(361, 254);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 23);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount";
            this.lblAmount.UseVisualStyleBackColor = true;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(461, 254);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(180, 22);
            this.tbAmount.TabIndex = 17;
            // 
            // lbWarnAmount
            // 
            this.lbWarnAmount.AutoSize = true;
            this.lbWarnAmount.BackColor = System.Drawing.Color.White;
            this.lbWarnAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbWarnAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarnAmount.ForeColor = System.Drawing.Color.Red;
            this.lbWarnAmount.Location = new System.Drawing.Point(467, 279);
            this.lbWarnAmount.Name = "lbWarnAmount";
            this.lbWarnAmount.Size = new System.Drawing.Size(69, 19);
            this.lbWarnAmount.TabIndex = 18;
            this.lbWarnAmount.Text = "Test Text";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.lbWarnAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbWarnObonotiPhone);
            this.Controls.Add(this.btObonotiNext);
            this.Controls.Add(this.lblObonotiPhoneNumber);
            this.Controls.Add(this.tbObonotiPhoneNumber);
            this.DoubleBuffered = true;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1000, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbObonotiPhoneNumber;
        private System.Windows.Forms.Label lblObonotiPhoneNumber;
        private System.Windows.Forms.Button btObonotiNext;
        private System.Windows.Forms.Label lbWarnObonotiPhone;
        private System.Windows.Forms.Button lblAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbWarnAmount;
    }
}
