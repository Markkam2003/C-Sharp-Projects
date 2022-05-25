using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Mark";
            //string middlename = "David";
            //string lastname = "Kaminskiy";
            //// Concatenates these strings together
            //string str = name + middlename + lastname;
            //Console.WriteLine(str);
            //Console.ReadLine();

            // Converts a string to uppercase
            //string state = "Washington";
            //state = state.ToUpper();
            //Console.WriteLine(state);
            //Console.ReadLine();

            // Creates a string builder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("\t My name is Mark.");
            sb.Append("I live in Vancouver Washington");
            sb.Append("\n I want to become a software engineer");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
