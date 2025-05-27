using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj1Task1
{
    internal class StuctKnowledgeConsolidation
    {
        public struct Employees
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public int Id;
            public bool PlaysPiano;

            public Employees(string firstName, string lastName, int age, int id, bool playsPiano)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Id = id;
                PlaysPiano = playsPiano;
            }
        }
        public static void Main(string[] args) 
        {
            Employees employee1 = new Employees("Bob", "Lane", 23, 1234, true);
            Employees employee2 = new Employees("John", "Stevenson", 43, 5678, false);
            Employees employee3 = new Employees("Jemma", "Aaaaa", 54, 2468, true);

            Employees[,] TheArray = new Employees[,] { { employee1 }, { employee2 }, { employee3 } };

            Console.WriteLine(TheArray[1, 0]);
        }

       
    }
}
