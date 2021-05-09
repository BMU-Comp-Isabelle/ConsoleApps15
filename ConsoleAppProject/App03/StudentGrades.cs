using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// App03 Student Marks will allow a tutor to
    /// enter a single mark for eah of a list of
    /// students and convert that mark into a grade
    /// It also calculates simple statistic and
    /// displays a student grade profile
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public double Minimum { get; set; }

        public double Maximum { get; set; }
    

        public StudentGrades()
        {
            Students = new string[]
            {
                "Louise", "Nikita", "Steve", "Abdel",
                "Fahima", "Robin", "Mehmed", "Issa",
                "Katie", "Joy"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }


        /// <summary>
        /// Input a mark between 0 - 100 for each
        /// student an store it in the Marks array
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the students and display their
        /// name and current mark
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert a student mark to a grade
        /// from F (Fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate and display the minimum, maximum
        /// and mean mark for all the students 
        /// </summary>







        public void TestGradesEnumeration()
        {
            Grades grade = Grades.C;

            Console.WriteLine($"Grade = {grade}");
            Console.WriteLine($"Grade No = {(int)grade}");

            Console.WriteLine("\nDiscovered by Andrei!\n");
            var gradeName = grade.GetAttribute<DisplayAttribute>().Name;
            Console.WriteLine($"Grade Name = {gradeName}");

            var gradeDescription = grade.GetAttribute<DescriptionAttribute>().Description;
            Console.WriteLine($"Grade Description = {gradeDescription}");

            string testDescription = EnumHelper<Grades>.GetDescription(grade);
            string testName = EnumHelper<Grades>.GetName(grade);

            Console.WriteLine();
            Console.WriteLine("Discovered by Derek Using EnumHelper\n");
            Console.WriteLine($"Name = {testName}");
            Console.WriteLine($"Description = {testDescription}");

        }
    }
}
