using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsandIntegersassign
{
    class Program
    {
        static void Main(string[] args)
        {
            //boolean variable with a value of false
            bool trueOrFalse = false;

            //a while loop that will keep looping until the varaible trueOrFalse has the value of true
            while (!trueOrFalse)
            {
                //a try statement to run the code below with a catch statement for possible user input errors.  if the input is not a number.  0 also can not be used
                try
                {
                    //a list of int
                    List<int> numDivide = new List<int>
                    {
                    357,
                    654,
                    835,
                    9112,
                    47
                    };

                    //a writeLine method that prints to the console asking the user for an input with the input being saved as an int in the variable divider
                    Console.WriteLine("Please input a number that will be used in a division calculation.\n");
                    int divider = Convert.ToInt32(Console.ReadLine());

                    //a for loop that loops until the i is not less than the count of the list indices. 
                    for (int i = 0; i < numDivide.Count; i++)
                    {
                        //a division of each value in the list divided by the input from the user with the answer saved to the variable divAnswer
                        int divAnswer = numDivide[i] / divider;
                        //a WriteLine method to print to the console a string for each value in the list
                        Console.WriteLine("\n" + numDivide[i] + " divided by " + divider + " equals " + divAnswer + ".");
                        //changing the trueOrFalse variable to true
                        trueOrFalse = true;
                    }
                    Console.ReadLine();

                }
                //a catch for diviDivideByZeroException error if the input was 0
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please do not divide anything by 0.  Ever.");
                }
                //a catch for SystemException if the input was anythong else other then a number
                catch (SystemException)
                {
                    Console.WriteLine("The input must be a number.");
                }
                Console.ReadLine();

            }
        }
    }
}
