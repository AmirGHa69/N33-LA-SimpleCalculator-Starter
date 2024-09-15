using System;

namespace SimpleCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // Class to perform actual calculations
                var calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter the first number:");
                var firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                var secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Enter the operation (e.g., +, add, -, subtract, * multiply, /, divide):");
                var operation = Console.ReadLine().ToLower();

                while (operation != "+" && operation != "add" &&
                       operation != "-" && operation != "subtract" &&
                       operation != "*" && operation != "multiply" &&
                       operation != "/" && operation != "divide")
                {
                    Console.WriteLine(
                        "Invalid operation. Please enter a valid operation (e.g., +, add, -, subtract, *, multiply, /, divide):");
                    operation = Console.ReadLine().ToLower();
                }

                var result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                // Display the result in a human-readable format
                var output = $"The value {firstNumber} {operation} {secondNumber} is equal to {result}.";
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }
        }
    }
}