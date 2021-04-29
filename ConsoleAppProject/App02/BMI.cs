using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {

        public const string IMPERIAL = "Imperial";
        public const string METRIC = "Metric";

        public const string FEET = "Feet";
        public const string INCHES = "Inches";

        public const int INCHES_IN_FEET = 12;
        public const int POUNDS_IN_STONE = 14;
        public const int IMPERIAL_FACTOR = 703;

        public double BMI_Index { get; set; }
        public BMI_Status Status { get; set; }

        private double height;
        private double weight;


        private string unitChoice;


        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            ConvertBMI();
        }

        public void ConvertBMI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Selecting units");

            string[] choices = new string[]
            {
                IMPERIAL, METRIC
            };

            Console.WriteLine($"\n Please select a unit to convert from\n");
            int choice = ConsoleHelper.SelectChoice(choices);
            unitChoice = choices[choice - 1];
            
            Console.WriteLine($"\n You have selected {unitChoice}! ");


            if (unitChoice == IMPERIAL)
            {
                InputImperial();
                CalculateImperial();
            }
            else if (unitChoice == METRIC)
            {
                InputMetric();
                CalculateMetric();
            }

            OutputBMI_Index();
            string input = Console.ReadLine();
        }

        private void InputImperial()
        {
            ConsoleHelper.OutputYellow($"\n Enter your height" +
                            " to the nearest feet & inches");

            height = ConsoleHelper.InputNumber($"\n Enter your height in feet > ");
            int inches = (int)ConsoleHelper.InputNumber($" Enter your height in inches > ", 0, INCHES_IN_FEET);
            height = height * INCHES_IN_FEET + inches;

            ConsoleHelper.OutputYellow($"\n Enter your weight" +
            " to the nearest stones & pounds");

            weight = ConsoleHelper.InputNumber($"\n Enter your weight in stone > ");
            int pounds = (int)ConsoleHelper.InputNumber($" Enter your weight in pounds > ", 0, POUNDS_IN_STONE);
            weight = weight * POUNDS_IN_STONE + pounds;
        }

        private void InputMetric()
        {
            ConsoleHelper.OutputYellow($"\n Enter your height " +
                "in metres");

            height = ConsoleHelper.InputNumber($"\n Enter your height in metres > ");

            ConsoleHelper.OutputYellow($"\n Enter your weight " +
            "to the nearest kilogram");

            weight = ConsoleHelper.InputNumber($"\n Enter your weight in kilograms > ");
        }

        /// <summary>
        /// BMI = (weight in pounds) x 703 / (height in inches)2
        /// </summary>
        private void CalculateImperial()
        {
            BMI_Index = (weight * IMPERIAL_FACTOR) / (height * height);
        }

        /// <summary>
        /// BMI = (weight in kg) / (height in metres)2
        /// </summary>
        private void CalculateMetric()
        {
            BMI_Index = weight / (height * height);
        }

        private void OutputBMI_Index()
        {
            if (BMI_Index < 18.50)
            {
                Status = BMI_Status.UnderWeight;
            }
            else if (BMI_Index > 18.5 && BMI_Index < 24.9)
            {
                Status = BMI_Status.NormalWeight;
            }
            else if (BMI_Index > 25.0 && BMI_Index < 29.9)
            {
                Status = BMI_Status.OverWeight;
            }
            else if (BMI_Index > 30.00 && BMI_Index < 34.9)
            {
                Status = BMI_Status.ObeseI;
            }
            else if (BMI_Index > 35.0 && BMI_Index < 39.9)
            {
                Status = BMI_Status.ObeseII;
            }
            else if (BMI_Index >= 40.0)
            {
                Status = BMI_Status.ObeseIII;
            }

            ConsoleHelper.OutputYellow($"\n Your BMI index is {BMI_Index: 0.00}");
            ConsoleHelper.OutputYellow($"Your BMI status is {Status}");

            Console.WriteLine("\n If you are Black, Asian, or other minority " +
                "ethnic groups, you have a higher risk");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk " +
                "\n Adults 27.5 or more are at high risk");
        }

        /// <summary>
        /// This method displays the list of choices of unit
        /// Imperial or metric, for them to choose from
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine("\n");
            Console.WriteLine($" 1. {IMPERIAL}");
            Console.WriteLine($" 2. {METRIC}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }
    }
}