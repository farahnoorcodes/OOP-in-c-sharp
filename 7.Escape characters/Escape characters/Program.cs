using System;
namespace Escape_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //there are 2 types of escape characters in C#:
            //1. Escape sequences
            //2. Verbatim string literals
            //Escape sequences are special characters that are used to represent certain characters in a string. They are represented by a backslash (\) followed by a character. For example, \n represents a new line, \t represents a tab, and \\ represents a backslash.
            //Verbatim string literals are strings that are prefixed with the @ symbol. They allow you to include special characters in a string without having to escape them. For example, @"C:\Users\Username" represents the string C:\Users\Username without having to escape the backslashes.
            //Here are some examples of escape sequences and verbatim string literals in C#:
            Console.WriteLine("Hello, World!");
            Console.WriteLine("farah noor.\n3rd semester.");
            Console.WriteLine("computer engineering.\tbahaddin zakariya univesity.");
            Console.WriteLine("This is a backslash:\\");
            Console.WriteLine("This is a quote: \"farah noor\"");
            Console.WriteLine("This is a single quote: \'farah noor\'");
            //\v represents a vertical tab
            Console.WriteLine("This is a vertical tab.\vThis is after the vertical tab.");
            //\a represents an alert (bell)
            Console.WriteLine("This is an alert (bell).\aThis is after the alert.");
            //\r represents a carriage return
            Console.WriteLine("This is a carriage return.\rThis is after the carriage return.");
            //\f represents a form feed
            Console.WriteLine("This is a form feed.\fThis is after the form feed.");
            //\b represents a backspace
            Console.WriteLine("This is a backspace.\bThis is after the backspace.");
            //\u represents a Unicode character
            Console.WriteLine("This is a Unicode character: \u263A");
            // @ represents a verbatim string literal
            // The @ symbol allows you to include special characters in a string without having to escape them.
            Console.WriteLine(@"C:\Users\Username");
            //$ represents an interpolated string in C#. The $ prefix lets you embed expressions directly inside a string using curly braces {}.
            string name = "Farah";
            int age = 21;
            string message = $"My name is {name} and I am {age} years old.";
            // Key points:

            //Anything inside { } is evaluated as an expression, not treated as literal text
            //To include an actual { or } in the output, double it: { { or } }
            //You can call methods or do simple operations inside the braces: $"Sum: {a + b}"
            //Formatting specifiers work too: $"Price: {price:C}"(currency format), $"{value:F2}"(2 decimal places)
            int a = 5, b = 3;
            double price = 49.999;
            double value = 3.14159;

            // Expression evaluated inside {}
            Console.WriteLine($"Hello, {name}!");

            // Escaping braces with {{ and }}
            Console.WriteLine($"This is a literal brace: {{a}} but this is a value: {a}");

            // Calling methods / operations inside braces
            Console.WriteLine($"Sum: {a + b}");
            Console.WriteLine($"Uppercase name: {name.ToUpper()}");

            // Formatting specifiers
            Console.WriteLine($"Price: {price:C}");   // Currency format, e.g. $50.00
            Console.WriteLine($"Value: {value:F2}");  // 2 decimal places, e.g. 3.14
        }
    }
}
