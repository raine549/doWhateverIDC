using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentTeacherOOP
{
    class Student : Person
    {
        //public int age = 20; // default age for student
        public void Study()
        {
            Console.WriteLine("I am studying.");
        }

        public void ShowAge()
        {
            Console.WriteLine("I am {0} years old.", Age); //student.age
        }
    }
}
