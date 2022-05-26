using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodassign
{
    public class MathClass
    {
        //the class parameter value from the input variable inputnumber.
        public int inputnumber { get; set; }

        //a method for doing subtraction with the value of the parameter input number applied to the variable num. num - 55 = value saved to the variable subtraction. With a console writeline 
        //to display a statement showing the operation with the value of num and subtraction concatenated into the statement.
        //an if statement applied to avoid a negative number from subtracting a smaller number than 55
        public int subMath(int num)
        {
            if (num >= 55)
            {
                int subtraction = num - 55;
                return subtraction;
            }
            else
            {
                int subtraction = 55 - num;
                return subtraction;
            }
        }

        //a method for doing addition with the value of the parameter input number applied to the variable num. num + 55 = value saved to the variable addition. With a console writeline 
        //to display a statement showing the operation with the value of num and addition concatenated into the statement.
        public int addMath(int num)
        {
            int addition = num + 55;
            return addition;
        }

        //a method for doing multiplication with the value of the parameter input number applied to the variable num. num * 55 = value saved to the variable multiplication. With a console writeline 
        //to display a statement showing the operation with the value of num and multiplication concatenated into the statement.
        public int multiMath(int num)
        {
            int multiplication = num * 55;
            return multiplication;
        }

        //a method for finding the square root with the value of the parameter input number applied to the variable num. utilizing the system Math class with the method Sqrt of the variable sum
        //= value saved to the variable sqrt. This method makes a return value to the method that will used in a Writeline methode statement (mathClass.sqrtMath(mathClass.inputnumber) concatinated
        //into the statement )
        public double sqrtMath(int num)
        {
            double sqrt = Math.Sqrt(num);
            return sqrt;
        }
    }
}
