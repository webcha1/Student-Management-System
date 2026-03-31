using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSystem
{
    public class Mark
    {
        public int MarkID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public decimal Score { get; set; }
        public DateTime Date { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
