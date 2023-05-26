using System;

namespace ConsoleApp_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MyClass myObject = new MyClass();

            // Prompt the user to enter a number
            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());

            // Call the method on the entered number
            int result = myObject.DivideByTwo(userInput);

            // Display the output
            Console.WriteLine("Result: " + result);

            // Call the method with output parameters
            int outputParam;
            myObject.MethodWithOutputParams(out outputParam);
            Console.WriteLine("Output parameter: " + outputParam);

            // Overload a method
            myObject.OverloadedMethod(10);
            myObject.OverloadedMethod(10, 20);

            // Declare a static class
            StaticClass.StaticMethod();
        }
    }

    // Create a class
    class MyClass
    {
        // Creates a method that divides the data passed to it by 2 and returns the result
        public int DivideByTwo(int number)
        {
            int result = number / 2;
            return result;
        }

        // Creates a method with output parameters
        public void MethodWithOutputParams(out int outputParam)
        {
            outputParam = 100;
        }

        // Overloads a method
        public void OverloadedMethod(int x)
        {
            Console.WriteLine("Overloaded Method: " + x);
        }

        public void OverloadedMethod(int x, int y)
        {
            Console.WriteLine("Overloaded Method: " + x + ", " + y);
        }
    }

    // Declare a static class
    static class StaticClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
    }
}
