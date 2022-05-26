using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodassign
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs integer to add 10 and return an integer then print the result to the display.
            MathMethods myOp = new MathMethods();//new MathMethods object

            Console.WriteLine("Please input an integer to operate on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your integer plus 7 is: " + myOp.Mathop(userNum));


            //User inputs decimal to add 10 and return an integer then print the result to the display.
            MathMethods myOp2 = new MathMethods();//new MathOp object

            //instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine("Please input a decimal to operate on: ");
            decimal userNumFloat = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Your decimal multiplied by 20 is: " + myOp2.Mathop(userNumFloat));


            //User inputs string, class will recieve string parameter and convert to integer. Class will divide by 10 and return an int.
            MathMethods myOp3 = new MathMethods(); //new MathOp object
            Console.WriteLine("Please input a integer to operate on: ");

            Console.WriteLine("Your integer divided by 3 is: " + myOp3.Mathop(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
