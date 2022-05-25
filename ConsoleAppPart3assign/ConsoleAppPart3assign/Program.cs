using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart3assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.

            string[] foodsArray = { "pizza", "burger", "fries", "nachos", "tacos", "sundae" };
            double[] priceArray = { 1.99, 2.99, 12.99, 15.99, 21.99, 5.99 };

            string input;
            int i;

            Console.WriteLine("Welcome to food cart! \n");
            Console.WriteLine("This is the top food cart in the state!");
            Console.WriteLine();
            Console.Write("Please enter a value between 0 and 5 to print out the item to the screen for purchase ");
            input = Console.ReadLine();
            i = Convert.ToInt32(input);

            while (i <= 5)
            {
                Console.WriteLine("The item at index {0} is " + foodsArray[i], i);
                Console.WriteLine("The cost of item {0} is " + priceArray[i].ToString("C"), i);
                break;
            }
            if (i > 5)
            {
                Console.WriteLine("Sorry there is no item with that number. Please try again.");
            }
            Console.ReadLine();

            //Creates a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.

            //string[] CarsArray = { "Bmw", "Mercedes", "Toyota", "Jeep", "Ford" };
            //int i;

            //Console.WriteLine("Can you name a Popular car used in America");

            //for (i = 0; i < CarsArray.Length; i++)
            //{
            //    Console.WriteLine("There is {0}.", CarsArray[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("And that is some of the cars driven in America!");
            //Console.ReadLine();
        }
    }
}
