using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorassign
{
    class Program
    {
        static void Main(string[] args)
        {
            const string originalName = "Mercedes"; //Created a constant
            var nickName = "Mer"; //Created a string using Var
            Car competition = new Car("BMW");
            Console.ReadLine();
        }
    }

    //Chain two constructors together
    public class Car
    {
        public Car(string name) : this(name, "Type") { }
        public Car(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public string Name { get; private set; }
        public string Title { get; set; }
    }
}

