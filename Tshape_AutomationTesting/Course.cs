using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tshape_AutomationTesting
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public DateTime StartDate { get; set; }
        public int Lessons { get; set; }
        public int Level { get; set; }
    }
}
