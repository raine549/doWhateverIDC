using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj1Task1
{
    internal class LearningStuff
    {
        public static void casting()
        {
            //there are 2 types of casting
            ///implicit casting which happens automatically
            ///when converting to larger data type eg: char -> int -> long -> float-> double
            //and explicit casting (manual) 
            ///when converting to smaller data type eg long to int

            //implicit casting example

            int myInt = 9;
            double myDouble = myInt;

            //explicit casting example

            double anotherDouble = 9.78;
            int anotherInt = (int)anotherDouble;

            //you can also use: Convert.ToBoolean, Convert.ToString etc




        }
    }

      
}
