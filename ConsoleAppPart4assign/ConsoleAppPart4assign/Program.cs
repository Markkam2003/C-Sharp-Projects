using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart4assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //A list of strings where each item in the list is unique.

            //Ask the user to input text to search for in the list.

            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.

            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

            //Add code to the loop that stops it from executing once a match has been found.

            List<string> sodasList = new List<string>() { "fanta", "coke", "sprite", "mtndew", "drpepper", "pepsi", "canadadry" };
            string listItem;
            int index;
            Console.WriteLine("Please enter an item that is on the sodas list ");
            listItem = Console.ReadLine();

            if (sodasList.Contains(listItem))
            {
                foreach (string listitem in sodasList)
                {
                    Console.WriteLine("{0} is on the sodas list.", listItem);
                    index = sodasList.FindIndex(i => i.Contains(listItem));
                    Console.WriteLine("The place of {0} on the list is at index {1}.", listItem, index);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Sorry, that item is not on the sodas list. Please try another item.");
                Console.WriteLine("Please enter an item on the sodas list");
                listItem = Console.ReadLine();
                if (sodasList.Contains(listItem))
                {
                    foreach (string listitem in sodasList)
                    {
                        Console.WriteLine("{0} is on the sodas list.", listItem);
                        index = sodasList.FindIndex(i => i.Contains(listItem));
                        Console.WriteLine("The place of {0} on the list is at index {1}.", listItem, index);
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
