namespace StudentMarksManager.Forms
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblEnrollmentDate = new System.Windows.Forms.Label();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 1;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 3;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(120, 77);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 5;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 110);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(120, 107);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 60);
            this.txtAddress.TabIndex = 7;

            // lblDepartment
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(20, 180);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(73, 15);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department:";

            // cmbDepartment
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(120, 177);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(250, 23);
            this.cmbDepartment.TabIndex = 9;

            // lblEnrollmentDate
            this.lblEnrollmentDate.AutoSize = true;
            this.lblEnrollmentDate.Location = new System.Drawing.Point(20, 210);
            this.lblEnrollmentDate.Name = "lblEnrollmentDate";
            this.lblEnrollmentDate.Size = new System.Drawing.Size(94, 15);
            this.lblEnrollmentDate.TabIndex = 10;
            this.lblEnrollmentDate.Text = "Enrollment Date:";

            // dtpEnrollmentDate
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(120, 207);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(250, 23);
            this.dtpEnrollmentDate.TabIndex = 11;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(120, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(230, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // lblUser
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 240);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 15);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "User:";

            // cmbUser
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(120, 237);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(250, 23);
            this.cmbUser.TabIndex = 15;

            // AddStudentForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEnrollmentDate);
            this.Controls.Add(this.lblEnrollmentDate);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblEnrollmentDate;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbUser;
    }
}