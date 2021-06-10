using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;


namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Isabelle Thorpe 14/04/2020
    /// </summary>
    
    public static class Program
    {
        private static int choice;
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("Isabelle Thorpe");
            Console.WriteLine();

            string[] choices = new string[]
            {
                "Distance Coverter",
                "BMI Calculator",
                "Student Grades",
                "Network App"
            };

            ConsoleHelper.OutputTitle("Please select the application you wish to use ");
            choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            { 
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choice == 2)
            {
                BMI_Calculator calculator = new BMI_Calculator();
                calculator.Run();
            }
            else if (choice == 3)
            {
                StudentGrades studentGrades = new StudentGrades();
                studentGrades.Run();
            }
            else if (choice == 4)
            {
                NetworkApp network = new NetworkApp();
                network.Run();
            }

        }
    }
}
