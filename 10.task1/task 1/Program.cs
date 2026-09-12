//convert int to double and decimal to int and display all values
using System;
namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and store an integer
            int number = 25;

            // Implicit conversion: int to double
            double doubleValue = number;

            // Declare and store a decimal
            decimal decimalNumber = 25.75m;

            // Explicit conversion: decimal to int
            // Requires a cast because narrowing conversions can lose data
            // The fractional part is truncated (not rounded)
            int intValue = (int)decimalNumber;

            // Display all values
            Console.WriteLine("Integer value: " + number);
            Console.WriteLine("Double value: " + doubleValue);
            Console.WriteLine("Decimal value: " + decimalNumber);
            Console.WriteLine("Int value: " + intValue);
            Console.ReadKey();
        }
    }
}
