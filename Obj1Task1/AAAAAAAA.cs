using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj1Task1
{
    internal class AAAAAAAA
    {
        public static void arrayTask()
        {
            string[,] wordArray = new string[3,3] { { "word1", "word2", "word3"},
                {"word4", "word5", "word6"}, {"7", "8", "9"} };

            int arrayLength = wordArray.Length;
            Console.WriteLine(arrayLength);
            Console.WriteLine(wordArray[1, 1]);

            Console.WriteLine("Enter value you are searching for: ");
            string searchItem = Console.ReadLine();

            string currentItem = "";

            int counter = 0;

            int itemLocationX = 0;
            int itemLocationY = 0;

            bool isFound = false;

            while (currentItem != searchItem | counter > 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        currentItem = wordArray[i, j];

                        if (currentItem == searchItem)
                        {
                            itemLocationX = i;
                            itemLocationY = j;
                            isFound = true;
                            break;
                        }
                        else
                        {
                            counter++;
                        }

                        
                    }
                }
                break;
            }

            if (isFound)
            {
                Console.WriteLine("The position of your item is: ( {0} , {1} )", itemLocationX, itemLocationY);
            }
            else if (isFound == false)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine("wtf is happening");
            }
        }
    }
}
