using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiply entered number by 50 and display result to console
            Console.WriteLine("Enter a number and I will multiply it by 50.");
            int numOriginal = Convert.ToInt32(Console.ReadLine());
            int numFifty = numOriginal * 50;
            Console.WriteLine("Your number times 50 is: " + numFifty);
            Console.ReadLine();

            //Add entered number by 25 and display result to console
            Console.WriteLine("Enter a number and I will add by 25.");
            int myNum = Convert.ToInt32(Console.ReadLine());
            int numtwentyfive = myNum + 25;
            Console.WriteLine("Your number plus 25 is: " + numtwentyfive);
            Console.ReadLine();

            // divide entered number by 12.5 and display result to console
            Console.WriteLine("Enter a number and I will divide it by 12.5.");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            double quotient = yourNum / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.ReadLine();

            //check if entered number is > 50 and display true or false to console
            Console.WriteLine("Enter a number and I will see if it is greater than 50.");
            int theirNum = Convert.ToInt32(Console.ReadLine());
            bool isGreater = theirNum > 50;
            Console.WriteLine(isGreater);
            Console.ReadLine();

            //divide entered number by 7 and display result and remainder to console
            Console.WriteLine("Enter a number and I will divide it by 7 and display the remainder");
            int giveNum = Convert.ToInt32(Console.ReadLine());
            int remainder = giveNum % 7;
            Console.WriteLine("Your remainder divided by 7 is: " + remainder);
            Console.ReadLine();

        }
    }
}
