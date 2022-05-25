using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart5assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.

            //2. Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.

            //3. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

            List<string> groceryList = new List<string>() { "onions", "lettuce", "onions", "blueberry", "milk", "beans" };
            string listItem;
            int index;

            Console.WriteLine("Please enter a list item to display the grocery list item and their indexes ");
            listItem = Console.ReadLine();
            if (groceryList.Contains(listItem))
            {
                foreach (string item in groceryList)
                {
                    index = groceryList.FindIndex(a => a.Contains(item));
                    if (index >= 0)
                    {
                        Console.WriteLine(item + " " + index);
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry {0} is not on the list.", listItem);
            }
            Console.ReadLine();
        }
    }
}
