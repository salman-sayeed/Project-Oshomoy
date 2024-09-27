namespace Oshomoy
{
    partial class Adm2Panel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAddUser = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.addUserPanel = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btUpdateUser = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(721, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // btAddUser
            // 
            this.btAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.btAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.btAddUser.FlatAppearance.BorderSize = 0;
            this.btAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(179)))));
            this.btAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddUser.ForeColor = System.Drawing.Color.White;
            this.btAddUser.Location = new System.Drawing.Point(24, 144);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(91, 30);
            this.btAddUser.TabIndex = 1;
            this.btAddUser.TabStop = false;
            this.btAddUser.Text = "Add";
            this.btAddUser.UseVisualStyleBackColor = false;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(106, 46);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(150, 19);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TabStop = false;
            // 
            // addUserPanel
            // 
            this.addUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.addUserPanel.Controls.Add(this.label1);
            this.addUserPanel.Controls.Add(this.lbId);
            this.addUserPanel.Controls.Add(this.tbUserId);
            this.addUserPanel.Controls.Add(this.btUpdateUser);
            this.addUserPanel.Controls.Add(this.lbPassword);
            this.addUserPanel.Controls.Add(this.lbEmail);
            this.addUserPanel.Controls.Add(this.lbUsername);
            this.addUserPanel.Controls.Add(this.tbPassword);
            this.addUserPanel.Controls.Add(this.btAddUser);
            this.addUserPanel.Controls.Add(this.tbEmail);
            this.addUserPanel.Controls.Add(this.tbUsername);
            this.addUserPanel.Location = new System.Drawing.Point(471, 22);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(264, 188);
            this.addUserPanel.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(8, 107);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(92, 18);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(44, 76);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 18);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(8, 46);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(95, 18);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(106, 107);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(150, 19);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(106, 76);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 19);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.TabStop = false;
            // 
            // btUpdateUser
            // 
            this.btUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.btUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(199)))));
            this.btUpdateUser.FlatAppearance.BorderSize = 0;
            this.btUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(179)))));
            this.btUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.btUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdateUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btUpdateUser.Location = new System.Drawing.Point(152, 144);
            this.btUpdateUser.Name = "btUpdateUser";
            this.btUpdateUser.Size = new System.Drawing.Size(91, 30);
            this.btUpdateUser.TabIndex = 8;
            this.btUpdateUser.TabStop = false;
            this.btUpdateUser.Text = "Update";
            this.btUpdateUser.UseVisualStyleBackColor = false;
            this.btUpdateUser.Click += new System.EventHandler(this.btUpdateUser_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(28, 17);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(72, 18);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "User ID:";
            // 
            // tbUserId
            // 
            this.tbUserId.BackColor = System.Drawing.Color.White;
            this.tbUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserId.Location = new System.Drawing.Point(106, 16);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(150, 19);
            this.tbUserId.TabIndex = 9;
            this.tbUserId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "or";
            // 
            // Adm2Panel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.addUserPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Adm2Panel";
            this.Size = new System.Drawing.Size(750, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Button btUpdateUser;
    }
}
