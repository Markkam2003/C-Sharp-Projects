using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixpartassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One
            //1. Create a one - dimensional Array of strings.
            //2. Ask the user to input some text. 
            //3. Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            //4. Then create a loop that prints off each string in the Array on a separate line.

            string[] stringArray = { "la", "or", "ny", "sc", };
            string input;

            Console.WriteLine("Type in some letters to create a new state... >>");
            input = Console.ReadLine();

            for (int a = 0; a < stringArray.Length; a++)
            {
                stringArray[a] = stringArray[a] + input;
                Console.WriteLine("By adding " + input + " you created the word " + stringArray[a]);
            }
            Console.ReadLine();


            // This creates a maximum value where the loop ends.
            const int Maximum = 50;
            int b;

            //Part two
            //First step: The count is set to the negative number because it creates an infinite loop.
            // Second step: fixing the infinit loop
            for (b = 0; b < Maximum; b++)
            {
                Console.WriteLine("This program creates an infinite loop...");
                Console.WriteLine(" Value: {0} ", b);
            }
            Console.ReadLine();

            //Part three
            // Creates a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.

            string[] foodsArray = { "pizza", "burger", "fries", "nachos", "tacos", "sundae" };
            double[] priceArray = { 1.99, 2.99, 12.99, 15.99, 21.99, 5.99 };

            string indexxx;
            int c;

            Console.WriteLine("Welcome to food cart! \n");
            Console.WriteLine("This is the top food cart in the state!");
            Console.WriteLine();
            Console.Write("Please enter a value between 0 and 5 to print out the item to the screen for purchase ");
            input = Console.ReadLine();
            c = Convert.ToInt32(input);

            while (c <= 5)
            {
                Console.WriteLine("The item at index {0} is " + foodsArray[c], c);
                Console.WriteLine("The cost of item {0} is " + priceArray[c].ToString("C"), c);
                break;
            }
            if (c > 5)
            {
                Console.WriteLine("Sorry there is no item with that number. Please try again.");
            }
            Console.ReadLine();

            //Creates a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.

            string[] CarsArray = { "Bmw", "Mercedes", "Toyota", "Jeep", "Ford" };
            int d;

            Console.WriteLine("Can you name a Popular car used in America");

            for (d = 0; d < CarsArray.Length; d++)
            {
                Console.WriteLine("There is {0}.", CarsArray[d]);
            }
            Console.WriteLine();
            Console.WriteLine("And that is some of the cars driven in America!");
            Console.ReadLine();

            //Part4

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

            //Step Five

            //1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.

            //2. Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.

            //3. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

            List<string> groceryList = new List<string>() { "onions", "lettuce", "tomatoes", "blueberry", "milk", "beans" };
            foreach (string e in groceryList)
            {
                Console.WriteLine(e);
            }
            string listItems;
            int indexx;

            Console.WriteLine("Please enter a list item to display the grocery list item and their indexes ");
            listItems = Console.ReadLine();
            if (groceryList.Contains(listItems))
            {
                foreach (string item in groceryList)
                {
                    indexx = groceryList.FindIndex(e => e.Contains(item));
                    if (indexx >= 0)
                    {
                        Console.WriteLine(item + " " + indexx);
                    }
                    else
                    {
                        Console.WriteLine("Sorry {0} is not on the list.", listItems);
                    }
                }
                Console.ReadLine();
            }
            

            //Part six

            //1.Create a list of strings that has at least two identical strings in the list.

            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> animalList = new List<string>() { "Lion", "tiger", "zebra", "Lion", "bear", "zebra" };
            List<string> duplicateCheck = new List<string>();

            foreach (string animal in animalList)
            {
                if (!duplicateCheck.Contains(animal))
                {
                    duplicateCheck.Add(animal);
                    Console.WriteLine(animal + " - has not appeared on the list.");
                }
                else
                {
                    duplicateCheck.Add(animal);
                    Console.WriteLine(animal + " - has already appeared on the list.");
                }
            }
            Console.ReadLine();
        }
    }
}
