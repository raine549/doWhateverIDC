using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOOP
{
    class Dog : Animal
    {
        public void GetName()
        {
            Console.WriteLine("Enter the dog's name: ");
            Name = Console.ReadLine();
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating dog food.");
        }
    }
}
