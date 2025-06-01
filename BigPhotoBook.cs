using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookOOP
{
    class BigPhotoBook
    {
        private int numPages;

        public BigPhotoBook() // Constructor
        {
            numPages = 64; // Default number of pages for a big photo book
        }

        public int GetNumPages()
        {
            return numPages; // Return the number of pages
        }
    }
}
