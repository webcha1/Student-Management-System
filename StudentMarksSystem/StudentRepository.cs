using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSystem
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT s.*, d.DeptName, u.Username 
                          FROM Students s
                          JOIN Departments d ON s.DeptID = d.DeptID
                          JOIN Users u ON s.UserID = u.UserID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        StudentID = (int)reader["StudentID"],
                        UserID = (int)reader["UserID"],
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        DeptID = (int)reader["DeptID"],
                        EnrollmentDate = (DateTime)reader["EnrollmentDate"],
                        Department = new Department { DeptName = reader["DeptName"].ToString() },
                        User = new User { Username = reader["Username"].ToString() }
                    });
                }
            }

            return students;
        }

        public Student GetStudentById(int studentID)
        {
            Student student = null;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT s.*, d.DeptName, u.Username 
                          FROM Students s
                          JOIN Departments d ON s.DeptID = d.DeptID
                          JOIN Users u ON s.UserID = u.UserID
                          WHERE s.StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@StudentID", studentID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    student = new Student
                    {
                        StudentID = (int)reader["StudentID"],
                        UserID = (int)reader["UserID"],
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        DeptID = (int)reader["DeptID"],
                        EnrollmentDate = (DateTime)reader["EnrollmentDate"],
                        Department = new Department { DeptName = reader["DeptName"].ToString() },
                        User = new User { Username = reader["Username"].ToString() }
                    };
                }
            }

            return student;
        }

        public void AddStudent(Student student)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Students 
                          (UserID, Name, Email, Phone, Address, DeptID, EnrollmentDate) 
                          VALUES 
                          (@UserID, @Name, @Email, @Phone, @Address, @DeptID, @EnrollmentDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserID", student.UserID);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Email", student.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", student.Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", student.Address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DeptID", student.DeptID);
                cmd.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Students SET 
                          Name = @Name, 
                          Email = @Email, 
                          Phone = @Phone, 
                          Address = @Address, 
                          DeptID = @DeptID
                          WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Email", student.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", student.Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", student.Address ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DeptID", student.DeptID);
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Students WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@StudentID", studentID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
