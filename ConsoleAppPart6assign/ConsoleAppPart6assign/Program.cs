using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart6assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of strings that has at least two identical strings in the list.

            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> animalList = new List<string>() { "Lion", "tiger", "zebra", "panda", "bear" };
            List<string> duplicateCheck = new List<string>();

            foreach (string animal in animalList)
            {
                if (!duplicateCheck.Contains(animal))
                {
                    Console.WriteLine(animal + " - has not appeared on the list.");
                }
                else
                {
                    Console.WriteLine(animal + " - has already appeared on the list.");
                }
                duplicateCheck.Add(animal);
            }
            Console.ReadLine();
        }
    }
}
