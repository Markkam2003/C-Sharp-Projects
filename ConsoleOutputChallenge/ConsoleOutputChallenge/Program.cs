using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // greater than operator displayed
            //int num1 = 15;
            //int num2 = 3;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("The first number is larger.");
            //}
            //else
            //{
            //    Console.WriteLine("The second number is larger.");
            //}
            //Console.ReadLine();

            // lesser than or equal to operator displayed
            int age = 14;
            if (age <= 15)
            {
                Console.WriteLine("No you cannot get your liscence.");
            }
            else
            {
                Console.WriteLine("You can get your liscence!");
            }
            Console.ReadLine();
        }
    }
}
