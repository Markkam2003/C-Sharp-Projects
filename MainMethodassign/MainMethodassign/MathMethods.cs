using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodassign
{
    class MathMethods
    {
        //will take in an int and do an addition operatoration and return as an int. 
        public int Mathop(int number)
        {
            return number + 7;
        }

        //will take in a decimal, and do multiplication and return as an int. 
        public int Mathop(decimal number)
        {
            int newNum = Convert.ToInt32(number);
            return newNum * 20;
        }

        //will take in a string, convert to int and then divide by 3 then return an int. 
        public int Mathop(string number)
        {
            int newNum = Convert.ToInt32(number);
            return newNum / 3;
        }
    }
}
