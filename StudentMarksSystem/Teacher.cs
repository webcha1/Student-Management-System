using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSystem
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Speciality { get; set; }
        public int DeptID { get; set; }
        public DateTime HireDate { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public User User { get; set; }
    }
}
