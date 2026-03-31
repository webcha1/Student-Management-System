using StudentMarksManager.DAL;
using StudentMarksSystem;
using System;
using System.Windows.Forms;

namespace StudentMarksManager.Forms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            LoadDepartments();
            LoadUsersWithoutStudents();
        }

        private void LoadDepartments()
        {
            DepartmentRepository repo = new DepartmentRepository();
            cmbDepartment.DataSource = repo.GetAllDepartments();
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptID";
        }

        private void LoadUsersWithoutStudents()
        {
            UserRepository userRepo = new UserRepository();
            StudentRepository studentRepo = new StudentRepository();

            var allUsers = userRepo.GetAllUsers();
            var studentUsers = studentRepo.GetAllStudents();

            // Get users with role "Student" who don't already have a student record
            cmbUser.DataSource = allUsers.FindAll(u =>
                u.Role == "Student" &&
                !studentUsers.Exists(s => s.UserID == u.UserID));

            cmbUser.DisplayMember = "Username";
            cmbUser.ValueMember = "UserID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Student student = new Student
                {
                    UserID = (int)cmbUser.SelectedValue,
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    DeptID = (int)cmbDepartment.SelectedValue,
                    EnrollmentDate = dtpEnrollmentDate.Value
                };

                StudentRepository repo = new StudentRepository();
                repo.AddStudent(student);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbUser.SelectedValue == null)
            {
                MessageBox.Show("Please select a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}