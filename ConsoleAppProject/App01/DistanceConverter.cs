using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Isabelle Thorpe version 0.1
    /// </author>
    
    public class DistanceConverter
    {
        // Distance measured in miles
        private double miles;
        // Distance measured in feet
        private double feet;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet
        /// </summary>

        public void Run()
        {
            Console.WriteLine("Distance Converter - Author: Isabelle Thorpe");
            InputMiles();
            ConvertMilesToFeet();
            OutputFeet();
        }

        private void InputMiles()
        {
                Console.Write("Enter the number of miles > ");
                string value = Console.ReadLine();
                miles = Convert.ToDouble(value);
        }

        private void ConvertMilesToFeet()
        {
            InputMiles();
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
    }
}
