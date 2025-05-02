using System;

namespace MainMethodAssignment
{
    public class MathMethods2
    {
        //First method that takes an integer
        public int MathOp(int number)
        {
            return number + 7;
        }

        //Second method that takes a decimal
        public int MathOp(decimal number)
        {
            //Convert the decimal to an int to perform math operation
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }

        //Third MathOp method that takes a string
        public int MathOp(string number)
        {
            //Convert the string to an int to perform math operation
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}