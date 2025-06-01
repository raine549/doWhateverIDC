using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookOOP
{
    class PhotoBookTest
    {
        static void Main(string[] args)
        {
            PhotoBook myPhotoBook = new PhotoBook(); //use get to access private variable
            Console.WriteLine("Number of pages in my photo book: " + myPhotoBook.GetNumPages());

            PhotoBook myPhotoBook2 = new PhotoBook(24); //use second constructor to set number of pages
            Console.WriteLine("Number of pages in my second photo book: " + myPhotoBook2.GetNumPages());

            BigPhotoBook myBigPhotoBook = new BigPhotoBook();
            Console.WriteLine("Number of pages in my big photo book: " + myBigPhotoBook.GetNumPages());
        }
    }
}
