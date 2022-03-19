using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Tshape_AutomationTesting
{
    public class PageLoad
    {
        public static void Main(string[] args)
        {
            Question1();
            Question2();

            string projPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            var coursesObj = BaseFunction.ReadJSon<IDictionary<string, List<Course>>>($"{projPath}\\data.json");
            var courses = coursesObj["courses"];
            foreach (var course in courses)
            {
                Console.WriteLine($"courseId: {course.CourseId}, courseName: {course.CourseName}, level: {course.Level}");
            }

            Question3C(courses);
            Question3D(courses);
            Question3E(courses);
            Question3F(courses);
        }
        public static void Question1()
        {
            int[] arr = new int[] { 2, 5, 3, 9, 15, 20, 1, 17 };
            int result = BaseFunction.GetMaximumNumber(arr);
            Console.WriteLine("Question 1: Maximum of A[j] - A[i] = " + result);
            Console.WriteLine("---------------------");
        }

        public static void Question2()
        {
            Console.Write("Please input text here: ");
            string a = Console.ReadLine();
            a = BaseFunction.CapitalizeTheFirstLetter(a);
            Console.WriteLine("Question 2: Capitalize the first letter = " + a);
            Console.WriteLine("---------------------");
        }

        public static void Question3C(List<Course> courses)
        {
            Console.Write("Please input Level to filter: ");
            int levelValue1 = Int32.Parse(Console.ReadLine());
            var filteredLevelCourses = courses.FilterLevel(levelValue1);

            foreach (var course in filteredLevelCourses)
            {
                Console.WriteLine($"courseId: {course.CourseId}, {course.CourseName}");
            }
            Console.WriteLine("---------------------");

        }

        public static void Question3D(List<Course> courses)
        {
            Console.Write("Please input Instructor to filter: ");
            string instructorlValue = Console.ReadLine();
            var filteredInstructorlCourses = courses.FilterInstructor(instructorlValue);

            foreach (var course in filteredInstructorlCourses)
            {
                Console.WriteLine($"courseId: {course.CourseId}, {course.CourseName}");
            }
            Console.WriteLine("---------------------");
        }

        public static void Question3E(List<Course> courses)
        {
            Console.Write("Please input Level to filter: ");
            int levelValue2 = Int32.Parse(Console.ReadLine());
            Console.Write("Please input Lessons to filter: ");
            int lessonValue = Int32.Parse(Console.ReadLine());

            var filteredLessonAndLevelCourses = courses.FilterLessons(lessonValue).FilterLevel(levelValue2);

            foreach (var course in filteredLessonAndLevelCourses)
            {
                Console.WriteLine($"courseId: {course.CourseId}, {course.CourseName}");
            }
            Console.WriteLine("---------------------");
        }

        public static void Question3F(List<Course> courses)
        {
            Console.Write("Please input Course name to filter: ");
            string nameValue = Console.ReadLine();

            var filteredCourseName = courses.FilterName(nameValue);

            foreach (var course in filteredCourseName)
            {
                Console.WriteLine($"courseId: {course.CourseId}, {course.CourseName}");
            }
            Console.WriteLine("---------------------");
        }
    }
}
