using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Obj1Task1
{
    internal class RecordsAndFile
    {
        struct Film
        {
            public string Name;
            public string Genre;

            public int Year;
        }
        //static void Main(string[] args)
        //{
        //    FilmRecords();
        //}
        public static void FilmRecords()
        {
            Console.WriteLine("Movies \n");

            //set up an array of films
            Film[] theFilms = new Film[6];

            importMovies(ref theFilms);
            //foreach (Film f in theFilms)
            //{
            //    Console.WriteLine($ "{f.Name}, {f.Genre}, {f.Year}");
            //}

            for (int i = 0; i < theFilms.Length; i++)
            {
                Console.Write(theFilms[i].Name + " ");
                Console.Write(theFilms[i].Genre + " ");
                Console.Write(theFilms[i].Year + " ");
                Console.WriteLine();
            }
        }

        static void importMovies(ref Film[] films) //this imports data from file
        {
            string path = @"C:\C#\Obj1Task1\List of Movies.txt";
            StreamReader reader = new StreamReader(path);

            //reads data from file
            string space = " ";
            string[] oneMovie = new string[3]; //this array stores a single film, 3 fields

            Film tempFilm; //assigning thingy from struct

            int counter = 0;

            while (space != null) //when no more movies i think
            {
                space = reader.ReadLine(); //reads whole line as a string
                if (space != null)
                {
                    oneMovie = space.Split(",");

                    //assigns each element of the string array to a film attribute
                    tempFilm.Name = oneMovie[0];
                    tempFilm.Genre = oneMovie[1];
                    tempFilm.Year = Convert.ToInt32(oneMovie[2]);
                    films[counter] = tempFilm;
                    counter++;
                }
            }

            reader.Close();
            Console.WriteLine("The number of films is " + counter); //just to check
        }

      
    }





}
