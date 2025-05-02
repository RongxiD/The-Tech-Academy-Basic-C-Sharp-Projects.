using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathMethods2 class
            MathMethods2 math1 = new MathMethods2();

            // Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(7)); // Output: 14 (7 + 7)

            // Call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(7.3m)); // Output: 140 (Convert 7.3 to int 7, then 7 * 20)

            // Call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7")); // Output: 1 (Convert "7" to int 7, then 7 % 3)
        }
    }
}