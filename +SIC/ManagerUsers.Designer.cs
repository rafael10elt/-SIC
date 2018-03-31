namespace _SIC
{
    partial class ManagerUsers
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
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbUserInformation = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.lblRetypePass = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbUserList = new System.Windows.Forms.GroupBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAdm = new System.Windows.Forms.Label();
            this.rdbYES = new System.Windows.Forms.RadioButton();
            this.rdbNO = new System.Windows.Forms.RadioButton();
            this.grbUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbUserList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(101, 67);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(154, 21);
            this.txtJobTitle.TabIndex = 19;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(12, 72);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(69, 16);
            this.lblJobTitle.TabIndex = 18;
            this.lblJobTitle.Text = "Job Title";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(367, 65);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.PasswordChar = '*';
            this.txtEmployeeId.Size = new System.Drawing.Size(80, 21);
            this.txtEmployeeId.TabIndex = 17;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(264, 70);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(97, 16);
            this.lblEmployeeId.TabIndex = 16;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 21);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(347, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '*';
            this.txtLastName.Size = new System.Drawing.Size(154, 21);
            this.txtLastName.TabIndex = 15;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 16);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // grbUserInformation
            // 
            this.grbUserInformation.Controls.Add(this.rdbNO);
            this.grbUserInformation.Controls.Add(this.rdbYES);
            this.grbUserInformation.Controls.Add(this.lblAdm);
            this.grbUserInformation.Controls.Add(this.btnClear);
            this.grbUserInformation.Controls.Add(this.txtUserId);
            this.grbUserInformation.Controls.Add(this.lblUserId);
            this.grbUserInformation.Controls.Add(this.btnClose);
            this.grbUserInformation.Controls.Add(this.txtJobTitle);
            this.grbUserInformation.Controls.Add(this.lblJobTitle);
            this.grbUserInformation.Controls.Add(this.txtEmployeeId);
            this.grbUserInformation.Controls.Add(this.lblEmployeeId);
            this.grbUserInformation.Controls.Add(this.txtFirstName);
            this.grbUserInformation.Controls.Add(this.txtLastName);
            this.grbUserInformation.Controls.Add(this.lblFirstName);
            this.grbUserInformation.Controls.Add(this.lblLastName);
            this.grbUserInformation.Controls.Add(this.btnDelete);
            this.grbUserInformation.Controls.Add(this.txtRetypePass);
            this.grbUserInformation.Controls.Add(this.lblRetypePass);
            this.grbUserInformation.Controls.Add(this.btnUpdate);
            this.grbUserInformation.Controls.Add(this.txtEmail);
            this.grbUserInformation.Controls.Add(this.txtPassword);
            this.grbUserInformation.Controls.Add(this.lblEmail);
            this.grbUserInformation.Controls.Add(this.lblPassword);
            this.grbUserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserInformation.Location = new System.Drawing.Point(12, 260);
            this.grbUserInformation.Name = "grbUserInformation";
            this.grbUserInformation.Size = new System.Drawing.Size(733, 246);
            this.grbUserInformation.TabIndex = 11;
            this.grbUserInformation.TabStop = false;
            this.grbUserInformation.Text = "User Information";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(264, 34);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 16);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Last Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(275, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Location = new System.Drawing.Point(148, 139);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.PasswordChar = '*';
            this.txtRetypePass.Size = new System.Drawing.Size(154, 21);
            this.txtRetypePass.TabIndex = 10;
            // 
            // lblRetypePass
            // 
            this.lblRetypePass.AutoSize = true;
            this.lblRetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePass.Location = new System.Drawing.Point(12, 139);
            this.lblRetypePass.Name = "lblRetypePass";
            this.lblRetypePass.Size = new System.Drawing.Size(130, 16);
            this.lblRetypePass.TabIndex = 9;
            this.lblRetypePass.Text = "Retype Password";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(173, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(347, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(154, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(264, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 191);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(446, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grbUserList
            // 
            this.grbUserList.Controls.Add(this.dataGridView1);
            this.grbUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserList.Location = new System.Drawing.Point(12, 12);
            this.grbUserList.Name = "grbUserList";
            this.grbUserList.Size = new System.Drawing.Size(733, 221);
            this.grbUserList.TabIndex = 21;
            this.grbUserList.TabStop = false;
            this.grbUserList.Text = "Users List";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(573, 31);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '*';
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(61, 21);
            this.txtUserId.TabIndex = 22;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(507, 34);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(60, 16);
            this.lblUserId.TabIndex = 21;
            this.lblUserId.Text = "User ID";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(358, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 30);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.Location = new System.Drawing.Point(453, 68);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(41, 16);
            this.lblAdm.TabIndex = 24;
            this.lblAdm.Text = "ADM";
            // 
            // rdbYES
            // 
            this.rdbYES.AutoSize = true;
            this.rdbYES.Location = new System.Drawing.Point(500, 66);
            this.rdbYES.Name = "rdbYES";
            this.rdbYES.Size = new System.Drawing.Size(51, 19);
            this.rdbYES.TabIndex = 25;
            this.rdbYES.TabStop = true;
            this.rdbYES.Text = "YES";
            this.rdbYES.UseVisualStyleBackColor = true;
            // 
            // rdbNO
            // 
            this.rdbNO.AutoSize = true;
            this.rdbNO.Location = new System.Drawing.Point(557, 66);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(45, 19);
            this.rdbNO.TabIndex = 26;
            this.rdbNO.TabStop = true;
            this.rdbNO.Text = "NO";
            this.rdbNO.UseVisualStyleBackColor = true;
            // 
            // ManagerUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 518);
            this.Controls.Add(this.grbUserInformation);
            this.Controls.Add(this.grbUserList);
            this.MaximizeBox = false;
            this.Name = "ManagerUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerUsers_Load);
            this.grbUserInformation.ResumeLayout(false);
            this.grbUserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbUserList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grbUserInformation;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lblRetypePass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbUserList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbNO;
        private System.Windows.Forms.RadioButton rdbYES;
        private System.Windows.Forms.Label lblAdm;
    }
}