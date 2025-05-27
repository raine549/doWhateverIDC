using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj1Task1
{
    internal class ListsAndArraysBasics
    {
        public static void size()
        {
            //arrays have a fixed size that is set when they are created
            //lists can grow or shrink dynamically as items are added or removed

            int[] arrayExample = new int[3];
            List<int> listExample = new List<int>();

            Console.WriteLine("The length of the arrayExample is: {0}", arrayExample.Length); //outputs 3
            Console.WriteLine("The length of the listExample is: {0}", listExample.Count); //outputs 0

            arrayExample = new int[5];
            listExample.Add(1);
            listExample.Add(2);
            listExample.Add(3);

            Console.WriteLine("The length of the arrayExample is: {0}", arrayExample.Length);
            Console.WriteLine("The length (count) of the listExample is now: {0}", listExample.Count);

        }

        public static void accessingElements()
        {
            //arrays are accessed by index
            //lists can be accessed by index or foreach loop
            int[] arrayExample = new int[] { 1, 2, 3 };
            List<int> listExample = new List<int>() { 1, 2, 3 };

            Console.WriteLine(arrayExample[1]); //output: 2
            Console.WriteLine(listExample[1]); //output: 2

            foreach (int item in listExample)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");

            for (int i = 0; i < arrayExample.Length; i++)
            {
                Console.WriteLine(arrayExample[i]);
            }

        }

        public static void type()
        {
            //arrays can only store items of the same type
            //lists can store items of different types
            int[] arrayExample = new int[3];
            object[] objectArray = new object[3]; //object is data type
            List<int> listExample = new List<int>();

            objectArray[0] = "hello"; // allowed
            //arrayExample[0] = "hello"; // NOT allowed
            //listExample.Add("hello"); //NOT allowed
            listExample.Add(1); //allowed
        }

        public static void memoryAllocation()
        {
            //arrays allocate memory for all their elements when they are created
            //lists only allocate memory as needed

            int[] arrayExample = new int[3];
            List<int> listExample = new List<int>();

            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(arrayExample)); //output 12
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(listExample)); //output 16

            Console.WriteLine();

            listExample.Add(1);
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(listExample)); //output 16
            Console.WriteLine();

            listExample.Add(2);
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(listExample)); //output 16

            //doesnt work here


        }

        public static void performance()
        {
            //arrays facter when accessing individual elements
            //lists faster when adding or removing elements

            int[] arrayExample = new int[1000000];
            List<int> listExample = new List<int>();

            Stopwatch stopwatchExample = Stopwatch.StartNew();
            for (int i = 0; i < arrayExample.Length; i++)
            {
                arrayExample[i] = i;
            }

            stopwatchExample.Stop();
            Console.WriteLine("Array assignment: " + stopwatchExample.ElapsedMilliseconds);

            stopwatchExample.Restart();
            for (int i = 0; i < listExample.Capacity; i++)
            {
                listExample.Add(i);
            }
            stopwatchExample.Stop();
            Console.WriteLine("list add: " + stopwatchExample.ElapsedMilliseconds);



        }
    }
}

