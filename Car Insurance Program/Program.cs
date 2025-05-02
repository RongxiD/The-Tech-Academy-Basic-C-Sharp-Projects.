using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start application:\n");
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            
            bool trueOrFalseDUI = bool.Parse(Console.ReadLine());
            bool DUI = Convert.ToBoolean(trueOrFalseDUI);            

            Console.WriteLine("How many speeding tickets do you have?");
            int speedTickets = Convert.ToInt32(Console.ReadLine());


            bool qualified = (speedTickets < 3 && age > 15 && DUI == false);
            Console.WriteLine("Qualified?\n" + qualified);
            Console.ReadLine();

        }
    }
}
