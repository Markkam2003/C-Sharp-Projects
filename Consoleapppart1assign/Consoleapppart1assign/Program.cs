using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapppart1assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one - dimensional Array of strings.
            //2. Ask the user to input some text. 
            //3. Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            //4. Then create a loop that prints off each string in the Array on a separate line.

            string[] stringArray = { "la", "or", "ny", "sc", };
            string input;

            Console.WriteLine("Type in some letters to create a new state... >>");
            input = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + input;
                Console.WriteLine("By adding " + input + " you created the word " + stringArray[i]);
            }
            Console.ReadLine();
        }
    }
}
