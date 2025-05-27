using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentTeacherOOP
{
    class Person
    {
        public string Age { get; set; } // property for age
        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int age)
        {
            //assign age of person
            //get set thingy somewhere here

            Console.WriteLine("Input age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Age = age.ToString(); // convert int to string and assign to Age property
            //check if it works without the property afterwards

        }
    }
}
