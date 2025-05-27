using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStruct
{
    //// defining struct
    //struct Employee
    //{
    //    public int id;

    //    //constructor (doesn't really fit here but added for demostration)
    //    public Employee(int employeeId)
    //    {
    //        id = employeeId;
    //    }

    //    //method
    //    public void getId(int id)
    //    {
    //        Console.WriteLine("Employee id: " + id);
    //    }

      
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        // declare emp of struct Employee
    //        Employee emp;

    //        // accesses and sets struct field
    //        emp.id = 1;

    //        // accesses struct methods
    //        emp.getId(emp.id);

    //        Console.ReadLine();
    //    }
    //}

}

namespace CStruct2
{
    //defining struct
    struct Employee
    {
        public int id;
        public string name;

        //parameterized contructor
        public Employee(int employeeId, string employeeName)
        {
            id = employeeId;
            name = employeeName;
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    //calls constructor of struct
        //    Employee emp = new Employee(1, "Brian");

        //    Console.WriteLine("Employee name: " + emp.name);
        //    Console.WriteLine("Employee id: " + emp.id);
        //}
    }



}
