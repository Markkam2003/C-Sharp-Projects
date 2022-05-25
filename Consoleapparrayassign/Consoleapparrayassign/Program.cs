using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapparrayassign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] chips = { "Takis", "Doritos", "Cheetos", "Lays" };
            Console.WriteLine("Enter an index number to choose your chips: ");
            int input = Convert.ToInt32(Console.ReadLine());

            // if statement if the index is out of range
            if (input > chips.Length)
            {
                Console.WriteLine("Please choose a number inside of the array such as 1-4.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The chips at index number: " + input + " is " + chips[input]);
            }
            Console.ReadLine();

            // Array of integers
            int[] intArray = { 30, 21, 24, 14 };
            Console.WriteLine("Pick an index number to get your number.");
            int input2 = Convert.ToInt32(Console.ReadLine());

            // if statement if the index is out of range
            if (input2 > intArray.Length)
            {
                Console.WriteLine("You have chosen an index number out of range. Choose 1-4.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The integer at index number" + input2 + " is " + intArray[input2]);
            }
            //Console.ReadLine();

            // Create list of strings
            List<string> stringList = new List<string>() { "Oregon", "Washington", "Idaho" };
            Console.WriteLine("Enter an index number to get State.");
            int input3 = Convert.ToInt32(Console.ReadLine());

            //if statement if the index is out of range
            if (input3 > stringList.Count)
            {
                Console.WriteLine("You have picked a number that is out of range. Pick a number 1-3.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The state at index number is: " + input3 + " is " + stringList[input3]);
                Console.ReadLine();
            }
        }
    }
}
