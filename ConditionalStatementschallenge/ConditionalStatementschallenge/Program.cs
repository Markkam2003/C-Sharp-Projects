using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementschallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //if, else if, else statements
            string name = "Mark";

            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse. Your name is not Brett.");
            }
            Console.ReadLine();
        }
    }
}
