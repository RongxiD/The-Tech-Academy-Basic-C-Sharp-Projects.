using System;

namespace MainMethodAssignment
{
    class MathOperation1
    {
        //Create a method that takes two integers as parameters
        //Make one parameter optional by providing a default value
        public int MathOperation(int i, int j = 1)
        {
            //Perform multiplication on integers and return the result
            int result = i * j;
            return result;
        }
    }
}