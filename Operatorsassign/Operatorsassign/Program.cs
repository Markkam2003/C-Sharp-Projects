using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsassign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee();
            //employee1.firstName = "Bob";
            //employee1.lastName = "Fisher";
            //employee1.SayName();
            //Console.ReadLine();
            //employee1.Quit();
            //Console.WriteLine(employee1.firstName + "... " + employee1.lastName);
            //Console.ReadLine();

            Employee employee2 = new Employee();
            employee2.firstName = "Dave";
            employee2.lastName = "Fly";
            employee2.employeeID = 8845;

            Employee employee3 = new Employee();
            employee3.firstName = "Peter";
            employee3.lastName = "Fly";
            employee3.employeeID = 8845;

            bool doesEqual = employee2 == employee3; //overloaded operater method. 

            Console.ReadLine();
        }
    }
}
