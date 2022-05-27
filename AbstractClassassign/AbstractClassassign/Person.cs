using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassassign
{
    public abstract class Person
    {
        //abstract class
        public string firstName { get; set; }
        public string lastName { get; set; }

        //abstract method
        public abstract void sayName();
    }
}
