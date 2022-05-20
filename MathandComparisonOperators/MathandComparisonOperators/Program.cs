using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal; 
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //Subtraction
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //Multiplication
            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //Division
            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();


            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //True or False
            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
