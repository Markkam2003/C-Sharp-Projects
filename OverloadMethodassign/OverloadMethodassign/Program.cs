using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodassign
{
    class Program
    {
        static void Main(string[] args)
        {
            int returnMult;

            //instantiate MathOp class
            Math myNumObj = new Math();

            //user input is divided by 2 and output is displayed
            Console.WriteLine("Input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            myNumObj.myMethod(userNum);

            //static overload method with an out parameter 
            int myNum = 1;
            Console.WriteLine("Your number plus my number is: " + Math.myMethod(userNum, myNum));
            myNumObj.MethodOut(userNum, out int extraNum);
            Console.WriteLine("That number plus one is: " + extraNum);

            returnMult = Staticmath.MethodMult(userNum);
            Console.WriteLine("That number times five is: " + returnMult);

            Console.ReadLine();
        }
    }
}
