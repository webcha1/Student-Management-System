using StudentMarksManager.DAL;
using StudentMarksManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarksSystem
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            SetupUIBasedOnRole();
        }

        private void SetupUIBasedOnRole()
        {
            lblWelcome.Text = $"Welcome, {currentUser.Username} ({currentUser.Role})";

            // Hide/show tabs based on role
            if (currentUser.Role == "Student")
            {
                tabControl1.TabPages.Remove(tabUsers);
                tabControl1.TabPages.Remove(tabTeachers);
                tabControl1.TabPages.Remove(tabDepartments);
            }
            else if (currentUser.Role == "Teacher")
            {
                tabControl1.TabPages.Remove(tabUsers);
                tabControl1.TabPages.Remove(tabStudents);
            }

            // Load initial data
            LoadInitialData();
        }

   


        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }
        private void btnDeleteMark_Click(object sender, EventArgs e)
        {

        }

        private void btnEditMark_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {

        }
        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {

        }
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {

        }
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

        }
        private void btnEditTeacher_Click(object sender, EventArgs e)
        {

        }
        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {

        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {

        }


        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
           
        }
        private void LoadInitialData()
        {
            LoadStudents();
            LoadTeachers();
            LoadCourses();
            LoadDepartments();
            LoadUsers();
        }

        private void LoadStudents()
        {
            StudentRepository repo = new StudentRepository();
            dgvStudents.DataSource = repo.GetAllStudents();
        }

        private void LoadTeachers()
        {
            TeacherRepository repo = new TeacherRepository();
            dgvTeachers.DataSource = repo.GetAllTeachers();
        }

        private void LoadCourses()
        {
            CourseRepository repo = new CourseRepository();
            dgvCourses.DataSource = repo.GetAllCourses();
        }

        private void LoadDepartments()
        {
            DepartmentRepository repo = new DepartmentRepository();
            dgvDepartments.DataSource = repo.GetAllDepartments();
        }

        private void LoadUsers()
        {
            UserRepository repo = new UserRepository();
            dgvUsers.DataSource = repo.GetAllUsers();
        }

        // CRUD operations for all entities would follow similar patterns

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int studentID = (int)dgvStudents.SelectedRows[0].Cells["StudentID"].Value;
                Student student = new StudentRepository().GetStudentById(studentID);

                EditStudentForm form = new EditStudentForm(student);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int studentID = (int)dgvStudents.SelectedRows[0].Cells["StudentID"].Value;

                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new StudentRepository().DeleteStudent(studentID);
                    LoadStudents();
                }
            }
        }

        // Similar CRUD operations for other entities (Teachers, Courses, etc.)

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // Special value to indicate logout
            this.Close();
        }
    }
}
