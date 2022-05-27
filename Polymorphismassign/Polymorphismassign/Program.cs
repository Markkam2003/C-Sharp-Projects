using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismassign
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object type IQuittable
            IQuitable quitable = new Employee();
            //calling quit method 
            quitable.Quit();
            Console.ReadLine();
        }
    }
}
