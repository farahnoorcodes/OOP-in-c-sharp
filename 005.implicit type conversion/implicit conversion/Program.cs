using System;

namespace implicit_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an integer variable
            int number = 25;

            // Implicit conversion: int is automatically converted to double
            // Allowed because int fits safely into double without data loss
            double value = number;

            // Print the original integer value
            Console.WriteLine("Integer value: " + number);

            // Print the converted double value
            // Note: double does not show trailing .0 unless it has a fractional part
            Console.WriteLine("Double value: " + value);

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}