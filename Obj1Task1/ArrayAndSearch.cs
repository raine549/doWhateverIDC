using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj1Task1
{
    internal class ArrayAndSearch
    {
        public struct StudentStruct
        {
            public string Name;
            public int Age;
            public string Grade;

            public StudentStruct(string name, int age, string grade)
            {
                //turning field into variables (parameters)
                Name = name;
                Age = age;
                Grade = grade;
            }
        }

        public class Program
        {
            //public static void Main()
            //{
            //    // Create instances of the struct
            //    StudentStruct student1 = new StudentStruct("Alice", 20, "A");
            //    StudentStruct student2 = new StudentStruct("Bob", 22, "B");
            //    StudentStruct student3 = new StudentStruct("Charlie", 21, "A");

            //    // Create an array of the struct
            //    StudentStruct[] studentsArray = new StudentStruct[] { student1, student2, student3 };

            //    // Access and print the array elements
            //    foreach (StudentStruct student in studentsArray)
            //    {
            //        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            //    }

            //    Console.WriteLine("New process starting HERE... \n \n");
            //    linearSearch(student1, student2);
            //}

            public static void linearSearch(StudentStruct identifier, StudentStruct identifier2)
            {
                Console.WriteLine("Enter a student / value: ");
                dynamic searchItem = Console.ReadLine();

                StudentStruct student1 = new StudentStruct("Alice", 20, "A");
                StudentStruct student2 = new StudentStruct("Bob", 22, "B");
                StudentStruct student3 = new StudentStruct("Charlie", 21, "A");

                // Create an array of the struct
                StudentStruct[] studentsArray = new StudentStruct[] { student1, student2, student3 };

                int counter = 0;
                foreach (StudentStruct whatIsThis in studentsArray)
                {
                    counter++;
                }
                Console.WriteLine("The number of stuff in array is: " + counter);

            }
        }
    }
}
