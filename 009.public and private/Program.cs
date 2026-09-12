using System;

namespace public_and_private_keywords
{
    class student
    {
        // "public" means this field can be accessed directly from
        // outside the class (e.g., s1.name = "...").
        public string name;

        // "private" means this field can ONLY be accessed from inside
        // this class. Code outside (like Main) cannot do s1.marks = 85.
        // This protects the data and forces it to be set through a method.
        private int marks;

        // A public method that allows outside code to set the value
        // of the private "marks" field in a controlled way.
        public void setMarks(int m)
        {
            marks = m;
        }

        // A public method that can still access the private "marks"
        // field, because this code is inside the same class.
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "farah noor";

            // Can't do s1.marks = 85 directly here since marks is private.
            // Instead, we use the public method to set it.
            s1.setMarks(85);

            s1.display();
            Console.ReadKey();
        }
    }
}
