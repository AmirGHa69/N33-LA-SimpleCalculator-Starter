using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double result;
            while (!double.TryParse(argTextInput, out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                argTextInput = Console.ReadLine();
            }

            return result;
        }
    }
}