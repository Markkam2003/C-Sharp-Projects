using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchassign
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;
            //Exceptions must be handled using “try/catch.”
            try
            {
                //Ask the user for their age 
                Console.WriteLine("What is your age?");
                userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge == 0 || userAge < 0)
                {
                    throw new ExceptionHandling();
                }
                //Display the Year the user was born
                int userBorn = DateTime.Now.Year - userAge;
                Console.WriteLine("You were born in: " + userBorn);
                Console.ReadLine();
            }
            catch (ExceptionHandling)
            {
                //Display appropriate error messages if the user enters zero or negative numbers.
                Console.WriteLine("Please enter a number that is non zero and not negative.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                //Display a general message if an exception was caused by anything else.
                Console.WriteLine("Something went wrong.");
            }
            Console.ReadLine();
        }
    }
}
