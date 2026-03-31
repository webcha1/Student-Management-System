
using StudentMarksSystem;
using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    namespace StudentMarksManager.DAL
    {
        public class TeacherRepository
        {
            public List<Teacher> GetAllTeachers()
            {
                List<Teacher> teachers = new List<Teacher>();

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"SELECT t.*, d.DeptName, u.Username 
                             FROM Teachers t
                             JOIN Departments d ON t.DeptID = d.DeptID
                             JOIN Users u ON t.UserID = u.UserID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        teachers.Add(new Teacher
                        {
                            TeacherID = (int)reader["TeacherID"],
                            UserID = (int)reader["UserID"],
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Speciality = reader["Speciality"].ToString(),
                            DeptID = (int)reader["DeptID"],
                            HireDate = (DateTime)reader["HireDate"],
                            Department = new Department { DeptName = reader["DeptName"].ToString() },
                            User = new User { Username = reader["Username"].ToString() }
                        });
                    }
                }

                return teachers;
            }

            public Teacher GetTeacherById(int teacherID)
            {
                Teacher teacher = null;

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"SELECT t.*, d.DeptName, u.Username 
                             FROM Teachers t
                             JOIN Departments d ON t.DeptID = d.DeptID
                             JOIN Users u ON t.UserID = u.UserID
                             WHERE t.TeacherID = @TeacherID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        teacher = new Teacher
                        {
                            TeacherID = (int)reader["TeacherID"],
                            UserID = (int)reader["UserID"],
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Speciality = reader["Speciality"].ToString(),
                            DeptID = (int)reader["DeptID"],
                            HireDate = (DateTime)reader["HireDate"],
                            Department = new Department { DeptName = reader["DeptName"].ToString() },
                            User = new User { Username = reader["Username"].ToString() }
                        };
                    }
                }

                return teacher;
            }

            public void AddTeacher(Teacher teacher)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"INSERT INTO Teachers 
                             (UserID, Name, Email, Phone, Speciality, DeptID, HireDate) 
                             VALUES 
                             (@UserID, @Name, @Email, @Phone, @Speciality, @DeptID, @HireDate)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@UserID", teacher.UserID);
                    cmd.Parameters.AddWithValue("@Name", teacher.Name);
                    cmd.Parameters.AddWithValue("@Email", teacher.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", teacher.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Speciality", teacher.Speciality ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DeptID", teacher.DeptID);
                    cmd.Parameters.AddWithValue("@HireDate", teacher.HireDate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            public void UpdateTeacher(Teacher teacher)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"UPDATE Teachers SET 
                             Name = @Name, 
                             Email = @Email, 
                             Phone = @Phone, 
                             Speciality = @Speciality, 
                             DeptID = @DeptID
                             WHERE TeacherID = @TeacherID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Name", teacher.Name);
                    cmd.Parameters.AddWithValue("@Email", teacher.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", teacher.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Speciality", teacher.Speciality ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DeptID", teacher.DeptID);
                    cmd.Parameters.AddWithValue("@TeacherID", teacher.TeacherID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            public void DeleteTeacher(int teacherID)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string sql = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

