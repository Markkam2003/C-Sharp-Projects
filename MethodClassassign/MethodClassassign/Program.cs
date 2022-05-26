using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassassign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            //instantiate the class
            Method myOp = new Method();

            //Call the method in the class, passing in two numbers.
            myOp.mathOp(num1, num2);

            //Call the method in the class, specifying the parameters by name.
            myOp.mathOp(secondNum: num2, firstNum: num1);
            Console.ReadLine();
        }
    }
}
