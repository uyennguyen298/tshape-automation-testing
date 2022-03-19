using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tshape_AutomationTesting
{
    public static class ExtensionMethod
    {
        public static List<Course> FilterLevel(this List<Course> courses, int level)
        {
            return courses.Where(c => c.Level.Equals(level)).ToList();
        }

        public static List<Course> FilterInstructor(this List<Course> courses, string instructor)
        {
            return courses.Where(c => c.Instructor.Equals(instructor)).ToList();
        }

        public static List<Course> FilterLessons(this List<Course> courses, int lesson)
        {
            return courses.Where(c => c.Lessons.Equals(lesson)).ToList();
        }

        public static List<Course> FilterName(this List<Course> courses, string keyword)
        {
            return courses.Where(c => c.CourseName.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}
