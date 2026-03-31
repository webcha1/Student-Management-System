using StudentMarksSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudentMarksManager.DAL
{
    public class CourseRepository
    {
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT c.*, d.DeptName, s.SemesterName 
                             FROM Courses c
                             JOIN Departments d ON c.DeptID = d.DeptID
                             JOIN Semesters s ON c.SemesterID = s.SemesterID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        CourseID = (int)reader["CourseID"],
                        CourseName = reader["CourseName"].ToString(),
                        Credits = (int)reader["Credits"],
                        Description = reader["Description"]?.ToString(),
                        DeptID = (int)reader["DeptID"],
                        SemesterID = (int)reader["SemesterID"],
                        Department = new Department { DeptName = reader["DeptName"].ToString() },
                        Semester = new Semester { SemesterName = reader["SemesterName"].ToString() }
                    });
                }
            }

            return courses;
        }

        public Course GetCourseById(int courseID)
        {
            Course course = null;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT c.*, d.DeptName, s.SemesterName 
                             FROM Courses c
                             JOIN Departments d ON c.DeptID = d.DeptID
                             JOIN Semesters s ON c.SemesterID = s.SemesterID
                             WHERE c.CourseID = @CourseID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CourseID", courseID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    course = new Course
                    {
                        CourseID = (int)reader["CourseID"],
                        CourseName = reader["CourseName"].ToString(),
                        Credits = (int)reader["Credits"],
                        Description = reader["Description"]?.ToString(),
                        DeptID = (int)reader["DeptID"],
                        SemesterID = (int)reader["SemesterID"],
                        Department = new Department { DeptName = reader["DeptName"].ToString() },
                        Semester = new Semester { SemesterName = reader["SemesterName"].ToString() }
                    };
                }
            }

            return course;
        }

        public void AddCourse(Course course)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Courses 
                             (CourseName, Credits, Description, DeptID, SemesterID) 
                             VALUES 
                             (@CourseName, @Credits, @Description, @DeptID, @SemesterID)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@Credits", course.Credits);
                cmd.Parameters.AddWithValue("@Description", course.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DeptID", course.DeptID);
                cmd.Parameters.AddWithValue("@SemesterID", course.SemesterID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCourse(Course course)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Courses SET 
                             CourseName = @CourseName, 
                             Credits = @Credits, 
                             Description = @Description, 
                             DeptID = @DeptID, 
                             SemesterID = @SemesterID
                             WHERE CourseID = @CourseID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@Credits", course.Credits);
                cmd.Parameters.AddWithValue("@Description", course.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DeptID", course.DeptID);
                cmd.Parameters.AddWithValue("@SemesterID", course.SemesterID);
                cmd.Parameters.AddWithValue("@CourseID", course.CourseID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCourse(int courseID)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Courses WHERE CourseID = @CourseID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CourseID", courseID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}