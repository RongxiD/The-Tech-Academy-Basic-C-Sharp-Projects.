using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();

            // Ask the user to provide first parameter
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to provide a second parameter or press enter
            Console.WriteLine("Enter a second integer, or just press enter: ");
            try
            {
                // Call method with 2 parameters if both parameters are provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                // Call method with one parameter if only one is provided
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }

            Console.ReadKey();
        }
    }
}