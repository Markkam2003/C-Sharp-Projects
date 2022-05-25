using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart2assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // This creates a maximum value where the loop ends.
            const int Maximum = 50;
            int i;

            //First step: The count is set to the negative number because it creates an infinite loop.
            // Second step: fixing the infinit loop
            for (i = 0; i < Maximum; i++)
            {
                Console.WriteLine("This program creates an infinite loop...");
                Console.WriteLine(" Value: {0} ", i);
            }
            Console.ReadLine();
        }
    }
}
