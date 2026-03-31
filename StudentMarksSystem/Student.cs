using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSystem
{
    public class Student
    {
        public int StudentID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int DeptID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public User User { get; set; }

        public override string ToString() => Name;
    }
}
