using StudentMarksManager.DAL;

using StudentMarksSystem;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentMarksManager.Forms
{
    public partial class EditStudentForm : Form
    {
        private Student student;

        public EditStudentForm(Student studentToEdit)
        {
            InitializeComponent();
            this.student = studentToEdit;
            LoadStudentData();
            LoadDepartments();
        }

        private void LoadStudentData()
        {
            txtName.Text = student.Name;
            txtEmail.Text = student.Email;
            txtPhone.Text = student.Phone;
            txtAddress.Text = student.Address;
            dtpEnrollmentDate.Value = student.EnrollmentDate;
        }

        private void LoadDepartments()
        {
            DepartmentRepository repo = new DepartmentRepository();
            cmbDepartment.DataSource = repo.GetAllDepartments();
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptID";
            cmbDepartment.SelectedValue = student.DeptID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                student.Name = txtName.Text;
                student.Email = txtEmail.Text;
                student.Phone = txtPhone.Text;
                student.Address = txtAddress.Text;
                student.DeptID = (int)cmbDepartment.SelectedValue;
                student.EnrollmentDate = dtpEnrollmentDate.Value;

                StudentRepository repo = new StudentRepository();
                repo.UpdateStudent(student);

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

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}