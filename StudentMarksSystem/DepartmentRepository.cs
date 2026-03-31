using StudentMarksSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudentMarksManager.DAL
{
    public class DepartmentRepository
    {
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Departments";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    departments.Add(new Department
                    {
                        DeptID = (int)reader["DeptID"],
                        DeptName = reader["DeptName"].ToString(),
                        Location = reader["Location"]?.ToString()
                    });
                }
            }

            return departments;
        }

        public Department GetDepartmentById(int deptID)
        {
            Department department = null;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Departments WHERE DeptID = @DeptID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DeptID", deptID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    department = new Department
                    {
                        DeptID = (int)reader["DeptID"],
                        DeptName = reader["DeptName"].ToString(),
                        Location = reader["Location"]?.ToString()
                    };
                }
            }

            return department;
        }

        public void AddDepartment(Department department)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Departments 
                             (DeptName, Location) 
                             VALUES 
                             (@DeptName, @Location)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DeptName", department.DeptName);
                cmd.Parameters.AddWithValue("@Location", department.Location ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDepartment(Department department)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Departments SET 
                             DeptName = @DeptName, 
                             Location = @Location
                             WHERE DeptID = @DeptID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DeptName", department.DeptName);
                cmd.Parameters.AddWithValue("@Location", department.Location ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DeptID", department.DeptID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDepartment(int deptID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Departments WHERE DeptID = @DeptID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DeptID", deptID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}