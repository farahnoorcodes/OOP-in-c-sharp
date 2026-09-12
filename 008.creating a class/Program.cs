using System;

namespace class_in_c_sharp
{
    // A class is a blueprint for creating objects.
    // It groups related data (fields) and behavior (methods) together.
    class student
    {
        // These are "fields" - variables that belong to each object
        // created from this class. Every student object will have
        // its own name and age.
        public string name;
        public int age;
    }

    class program
    {
        static void Main()
        {
            // Creating an "object" (also called an instance) of the
            // student class using the "new" keyword.
            // s1 is now a real student object we can work with.
            student s1 = new student();

            // Accessing the object's fields using dot notation (s1.fieldName)
            // and assigning values to them.
            s1.name = "farah noor";
            s1.age = 18;

            // Printing the object's field values to the console.
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);

            // Waits for the user to press a key before closing the console
            // window. Useful when running the program outside an IDE.
            Console.ReadKey();
        }
    }
}