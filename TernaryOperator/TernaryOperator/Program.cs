using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary Operator
            int num1 = 15;
            int num2 = 11;

            string result = num1 < num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
