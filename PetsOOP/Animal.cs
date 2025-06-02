using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOOP
{
    abstract class Animal
    {
        //name property of type text
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Console.WriteLine("Enter the dog's name: ");
            Name = Console.ReadLine();
        }

        public abstract void Eat();
    }
}
