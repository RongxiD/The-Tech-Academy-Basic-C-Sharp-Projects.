using System; // Importing the System namespace, which provides fundamental classes and base types.

namespace MathOperationApp // Declaring a namespace to organize the code and prevent naming collisions.
{
    // Creating a public class named 'MathOperations'. Classes are blueprints for creating objects.
    public class MathOperations
    {
        // Creating a public void method named 'PerformOperation' that accepts two integer parameters: 'number1' and 'number2'.
        // 'void' indicates that this method does not return any value.
        public void PerformOperation(int number1, int number2)
        {
            // Performing a math operation (multiplication in this case) on the first integer ('number1').
            int result = number1 * 5; // Multiplying 'number1' by 5 and storing the result in the 'result' variable.

            // Displaying the second integer ('number2') to the console.
            Console.WriteLine("The second number is: " + number2); // Using Console.WriteLine to output text and the value of 'number2' to the console.
        }
    }

    // Creating the main program class named 'Program'. This class contains the entry point of the application.
    class Program
    {
        // The 'Main' method is the entry point of the console application. 'static void Main(string[] args)' is the standard signature.
        static void Main(string[] args)
        {
            // Instantiating the 'MathOperations' class. This creates an object (instance) of the 'MathOperations' class named 'mathOps'.
            MathOperations mathOps = new MathOperations();

            // Calling the 'PerformOperation' method of the 'mathOps' object, passing in two integer values (10 and 20) as arguments.
            mathOps.PerformOperation(10, 20); // Here, 10 is assigned to 'number1' and 20 is assigned to 'number2' based on their order.
            Console.WriteLine(); // Adding an empty line to the console output for better readability.

            // Calling the 'PerformOperation' method again, but this time specifying the parameter names explicitly.
            // This is called named arguments. The order of the arguments doesn't matter when using named parameters.
            mathOps.PerformOperation(number2: 30, number1: 5); // Here, 'number1' is explicitly set to 5 and 'number2' is explicitly set to 30.

            // Keeping the console window open until a key is pressed, so the user can see the output.
            Console.ReadKey();
        }
    }
}