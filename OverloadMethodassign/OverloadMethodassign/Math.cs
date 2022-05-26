using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodassign
{
    public class Math
    {
        //void: division operation
        public void myMethod(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }
        //static: addition operation
        public static int myMethod(int userNum, int myNum)
        {
            int newNum = userNum + myNum;
            return newNum;
        }

        //using out parameter 
        public void MethodOut(int userNum, out int extraNum)
        {
            extraNum = userNum + 1;
        }
    }
}
