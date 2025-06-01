using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhotoBookOOP
{
    class PhotoBook
    {
        private int numPages;
        public int NumPages
        {
            get { return numPages; }
            set
            {
                if (value < 1) // Ensure that the number of pages is at least 1
                {
                    throw new ArgumentException("Number of pages must be at least 1.");
                }
                numPages = value; 
            }
        }
        public int GetNumPages()
        {
            return NumPages;
        }


        public PhotoBook() // Default constructor
        {
            numPages = 16;
        }

        public PhotoBook(int numPages2) // second constructor
        {
          numPages = numPages2; // Allow user to set the number of pages
        }
    }
}
