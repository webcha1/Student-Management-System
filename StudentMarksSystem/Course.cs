using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSystem
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public int DeptID { get; set; }
        public int SemesterID { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public Semester Semester { get; set; }

        public override string ToString() => CourseName;
    }
}
