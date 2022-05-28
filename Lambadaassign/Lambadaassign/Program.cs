using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambadaassign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of 10 employees. Each employee should have a first and last name as well as an id.
            List<Employees> employees = new List<Employees>();//full employee list

            employees.Add(new Employees { FName = "Bob", LName = "Fisher", Id = 7 });
            employees.Add(new Employees { FName = "Liam", LName = "Wilson", Id = 1 });
            employees.Add(new Employees { FName = "Bryan", LName = "Keep", Id = 123 });
            employees.Add(new Employees { FName = "Jeff", LName = "Foster", Id = 1234 });
            employees.Add(new Employees { FName = "Josh", LName = "James", Id = 4598 });
            employees.Add(new Employees { FName = "Joe", LName = "Richards", Id = 8032 });
            employees.Add(new Employees { FName = "Dom", LName = "Hunter", Id = 245 });
            employees.Add(new Employees { FName = "Peter", LName = "Curry", Id = 1690 });
            employees.Add(new Employees { FName = "Joe", LName = "Li", Id = 2400 });
            employees.Add(new Employees { FName = "Tre", LName = "Well", Id = 3243 });

            List<Employees> theJoes = new List<Employees>();//new list that all of the joes go into.

            //loop that adds any employe whos first name is joe to a new list
            foreach (Employees employee in employees)
            {
                if (employee.FName == "Joe")
                    theJoes.Add(employee);
            }

            //Lambda function to find the first name "Joe" in a list.
            List<Employees> theJoesFNameLambda = employees.Where(x => x.FName.Contains("Joe")).ToList();

            //Lambda function to find the Id of all employees over 5.
            List<Employees> theJoesId = employees.Where(x => x.Id > 5).ToList();
        }
        class Employees
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Id { get; set; }
        }
    }
}
