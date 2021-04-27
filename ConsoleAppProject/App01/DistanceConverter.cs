using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// App01 allows the user to enter their choice of converting one
    /// distance into another distance. It runs by giving a choice, the
    /// user then inputing the value for conversion, excecuting the choice
    /// and finally giving the output of the conversion chosen.
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
        // Distance measured in metres
        private double metres;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;
        private object fromDistance;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet
        /// </summary>

        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                ConsoleHelper.OutputHeading("Distance Converter");
                int choice = InputChoice();
                ExcecuteChoice(choice);

                repeat = SelectRepeat();
            }
        }

        /// <summary>
        /// This method will give the user the choices of converting one
        /// distance into another distance
        /// </summary>
        private int InputChoice()
        {
            Console.WriteLine("1. Convert miles to feet");
            Console.WriteLine("3. Convert miles to metres");
            Console.WriteLine("3. Convert feet to metres");
            Console.WriteLine("4. Convert feet to miles");
            Console.WriteLine("5. Convert metres to miles");
            Console.WriteLine("6. Convert metres to feet");
            Console.WriteLine("");
            int value = (int)ConsoleHelper.InputNumber("Please enter either your choice from 1-6 \r\n", 1, 6);
            return value;
        }

        /// <summary>
        /// This method will excecute the users choice and converts one
        /// distance into another distance
        /// </summary>
        private void ExcecuteChoice(int choice)
        {
            if (choice == 1)
            {
                fromUnit = DistanceUnits.Miles;
                toUnit = DistanceUnits.Feet;
                ConsoleHelper.OutputTitle($"Converting {fromUnit} to {toUnit} ");

                InputMiles();
                ConvertMilesToFeet();
                OutputMilesToFeet();
            }
            else if (choice == 2)
            {
                fromUnit = DistanceUnits.Miles;
                toUnit = DistanceUnits.Metres;
                ConsoleHelper.OutputTitle($"Converting {fromUnit} to {toUnit} ");

                InputMiles();
                ConvertMilesToMetres();
                OutputMilesToMetres();

            }
            else if (choice == 3)
            {
                fromUnit = DistanceUnits.Feet;
                toUnit = DistanceUnits.Metres;
                ConsoleHelper.OutputTitle($"Converting {fromUnit} to {toUnit} ");

                InputFeet();
                ConvertFeetToMetres();
                OutputFeetToMetres();
            }
            else if (choice == 4)
            {
                fromUnit = DistanceUnits.Feet;
                toUnit = DistanceUnits.Miles;
                ConsoleHelper.OutputTitle($"Converting {fromUnit} to {toUnit} ");

                InputFeet();
                ConvertFeetToMiles();
                OutputFeetToMiles();
            }

            else if (choice == 5)
            {
                fromUnit = DistanceUnits.Metres;
                toUnit = DistanceUnits.Miles;
                ConsoleHelper.OutputTitle($"Converting {fromUnit} to {toUnit} ");

                InputMetres();
                ConvertMetresToMiles();
                OutputMetresToMiles();
            }

            else if (choice == 6)
            {
                fromUnit = DistanceUnits.Metres;
                toUnit = DistanceUnits.Feet;
                ConsoleHelper.OutputTitle($"Converting {fromUnit} to {toUnit} ");

                InputMetres();
                ConvertMetresToFeet();
                OutputMetresToFeet();
            }

            else
            {
                Console.WriteLine("Please enter a value between 1-6");
            }
        }

        /// <summary>
        /// This method will give the user the option to carry
        /// out another calculation by saying yes or no
        /// </summary>
        private bool SelectRepeat()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Would you like to carry out"
                    + " another calculation? yes/no?");
                string choice = Console.ReadLine();

                if (choice.ToLower().Contains("y"))
                {
                    Console.WriteLine("You have selected yes");
                    repeat = false;
                    return true;
                }

                else if (choice.ToLower().Contains("n"))
                {
                    Console.WriteLine("You have selected no");
                    repeat = false;
                    return false;
                }

                else
                {
                    Console.WriteLine("Error: invalid input. Please try again");
                }
            }
            return false;

        }

        /// <summary>
        /// These methods will display the input required for
        /// to convert one distance into another distance
        /// </summary>

        private void InputMiles()
        {
                Console.Write("Enter the number of miles > ");
                string value = Console.ReadLine();
                miles = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("Enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }


        /// <summary>
        /// These methods do the sums required to convert one 
        /// distance into another distance
        /// </summary>
        private void ConvertMilesToFeet()
        {
            feet = miles * 5280;
        }

        private void ConvertMilesToMetres()
        {
            metres = miles / 1609.34;
        }

        private void ConvertFeetToMetres()
        {
            metres = feet * 3.28;
        }

        private void ConvertFeetToMiles()
        {
            miles = feet / 5280;
        }

        private void ConvertMetresToMiles()
        {
            miles = metres * 1609.34;
        }

        private void ConvertMetresToFeet()
        {
            feet = miles / 3.28;
        }


        /// <summary>
        /// These methods will display the output for the user to
        /// see the conversion of one distance into another 
        /// </summary>
        private void OutputMilesToFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! \r\n");
        }

        private void OutputMilesToMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres! \r\n");
        }

        private void OutputFeetToMetres()
        {
            Console.WriteLine(feet + " feet is " + metres + " metres! \r\n");
        }

        private void OutputFeetToMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! \r\n");
        }

        private void OutputMetresToMiles()
        {
            Console.WriteLine(metres + " metres is " + miles + " miles! \r\n");
        }

        private void OutputMetresToFeet()
        {
            Console.WriteLine(metres + " metres is " + feet + " feet! \r\n");
        }
    }
}
