using System;

namespace explicit_type_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a double variable with a fractional value
            double number = 25.75;

            // Explicit conversion (cast) from double to int
            // Requires an explicit cast because narrowing conversions can lose data
            // The fractional part is truncated (not rounded), so 25.75 becomes 25
            int value = (int)number;

            Console.WriteLine("Double value: " + number);
            Console.WriteLine("Int value: " + value);
            Console.ReadKey();
        }
    }
}