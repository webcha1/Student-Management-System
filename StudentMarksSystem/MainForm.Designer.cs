using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentMarksSystem
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.tabTeachers = new System.Windows.Forms.TabPage();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnEditMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.tabDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.tabMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabTeachers);
            this.tabControl1.Controls.Add(this.tabCourses);
            this.tabControl1.Controls.Add(this.tabDepartments);
            this.tabControl1.Controls.Add(this.tabMarks);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblWelcome);
            this.tabDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(952, 472);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 32);
            this.lblWelcome.TabIndex = 0;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.btnAddStudent);
            this.tabStudents.Controls.Add(this.btnEditStudent);
            this.tabStudents.Controls.Add(this.btnDeleteStudent);
            this.tabStudents.Location = new System.Drawing.Point(4, 24);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(952, 472);
            this.tabStudents.TabIndex = 1;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(6, 44);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 25;
            this.dgvStudents.Size = new System.Drawing.Size(940, 422);
            this.dgvStudents.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(6, 6);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 32);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(112, 6);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(100, 32);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(218, 6);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.dgvTeachers);
            this.tabTeachers.Controls.Add(this.btnAddTeacher);
            this.tabTeachers.Controls.Add(this.btnEditTeacher);
            this.tabTeachers.Controls.Add(this.btnDeleteTeacher);
            this.tabTeachers.Location = new System.Drawing.Point(4, 24);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeachers.Size = new System.Drawing.Size(952, 472);
            this.tabTeachers.TabIndex = 2;
            this.tabTeachers.Text = "Teachers";
            this.tabTeachers.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(6, 44);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowTemplate.Height = 25;
            this.dgvTeachers.Size = new System.Drawing.Size(940, 422);
            this.dgvTeachers.TabIndex = 7;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(6, 6);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(100, 32);
            this.btnAddTeacher.TabIndex = 4;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Location = new System.Drawing.Point(112, 6);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(100, 32);
            this.btnEditTeacher.TabIndex = 5;
            this.btnEditTeacher.Text = "Edit Teacher";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(218, 6);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteTeacher.TabIndex = 6;
            this.btnDeleteTeacher.Text = "Delete Teacher";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.dgvCourses);
            this.tabCourses.Controls.Add(this.btnAddCourse);
            this.tabCourses.Controls.Add(this.btnEditCourse);
            this.tabCourses.Controls.Add(this.btnDeleteCourse);
            this.tabCourses.Location = new System.Drawing.Point(4, 24);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(952, 472);
            this.tabCourses.TabIndex = 3;
            this.tabCourses.Text = "Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // dgvCourses
            // 
            this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(6, 44);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowTemplate.Height = 25;
            this.dgvCourses.Size = new System.Drawing.Size(940, 422);
            this.dgvCourses.TabIndex = 7;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(6, 6);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(100, 32);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(112, 6);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(100, 32);
            this.btnEditCourse.TabIndex = 5;
            this.btnEditCourse.Text = "Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(218, 6);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteCourse.TabIndex = 6;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // tabDepartments
            // 
            this.tabDepartments.Controls.Add(this.dgvDepartments);
            this.tabDepartments.Controls.Add(this.btnAddDepartment);
            this.tabDepartments.Controls.Add(this.btnEditDepartment);
            this.tabDepartments.Controls.Add(this.btnDeleteDepartment);
            this.tabDepartments.Location = new System.Drawing.Point(4, 24);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(952, 472);
            this.tabDepartments.TabIndex = 4;
            this.tabDepartments.Text = "Departments";
            this.tabDepartments.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(6, 44);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowTemplate.Height = 25;
            this.dgvDepartments.Size = new System.Drawing.Size(940, 422);
            this.dgvDepartments.TabIndex = 7;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(6, 6);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(120, 32);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(132, 6);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(120, 32);
            this.btnEditDepartment.TabIndex = 5;
            this.btnEditDepartment.Text = "Edit Department";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(258, 6);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(120, 32);
            this.btnDeleteDepartment.TabIndex = 6;
            this.btnDeleteDepartment.Text = "Delete Department";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // tabMarks
            // 
            this.tabMarks.Controls.Add(this.dgvMarks);
            this.tabMarks.Controls.Add(this.btnAddMark);
            this.tabMarks.Controls.Add(this.btnEditMark);
            this.tabMarks.Controls.Add(this.btnDeleteMark);
            this.tabMarks.Location = new System.Drawing.Point(4, 24);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(952, 472);
            this.tabMarks.TabIndex = 5;
            this.tabMarks.Text = "Marks";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // dgvMarks
            // 
            this.dgvMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(6, 44);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.RowTemplate.Height = 25;
            this.dgvMarks.Size = new System.Drawing.Size(940, 422);
            this.dgvMarks.TabIndex = 7;
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(6, 6);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(100, 32);
            this.btnAddMark.TabIndex = 4;
            this.btnAddMark.Text = "Add Mark";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnEditMark
            // 
            this.btnEditMark.Location = new System.Drawing.Point(112, 6);
            this.btnEditMark.Name = "btnEditMark";
            this.btnEditMark.Size = new System.Drawing.Size(100, 32);
            this.btnEditMark.TabIndex = 5;
            this.btnEditMark.Text = "Edit Mark";
            this.btnEditMark.UseVisualStyleBackColor = true;
            this.btnEditMark.Click += new System.EventHandler(this.btnEditMark_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Location = new System.Drawing.Point(218, 6);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteMark.TabIndex = 6;
            this.btnDeleteMark.Text = "Delete Mark";
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.btnEditUser);
            this.tabUsers.Controls.Add(this.btnDeleteUser);
            this.tabUsers.Location = new System.Drawing.Point(4, 24);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(952, 472);
            this.tabUsers.TabIndex = 6;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 44);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(940, 422);
            this.dgvUsers.TabIndex = 7;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 32);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(112, 6);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 32);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(218, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnGenerateReport);
            this.tabReports.Controls.Add(this.txtReport);
            this.tabReports.Controls.Add(this.cmbReportType);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Location = new System.Drawing.Point(4, 24);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(952, 472);
            this.tabReports.TabIndex = 7;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(300, 6);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 32);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.Location = new System.Drawing.Point(6, 44);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReport.Size = new System.Drawing.Size(940, 422);
            this.txtReport.TabIndex = 2;
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Student Transcript",
            "Course Statistics",
            "Department Summary",
            "Teacher Workload"});
            this.cmbReportType.Location = new System.Drawing.Point(100, 10);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(180, 23);
            this.cmbReportType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Report:";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(872, 518);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Marks Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.tabCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.tabDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.tabMarks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnEditMark;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}
