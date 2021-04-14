using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
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
    /// Isabelle M Thorpe 14/04/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            /// program cannot access DistanceCoverter
            /// see https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0122?f1url=%3FappId%3Droslyn%26k%3Dk(CS0122
            DistanceConverter converter = new DistanceConverter();
            /*
            converter.ConvertMilesToFeet();
            */
        }
    }
}
