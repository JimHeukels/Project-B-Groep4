using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> lstMovies = new List<Movie>();
            lstMovies.Add(new Movie("The Lord of the Rings", "Adventure"));
            lstMovies.Add(new Movie("The Hobbit", "Adventure"));

            lstMovies.Add(new Movie("The War", "Action"));

            foreach (Movie oMovie in lstMovies)
            {
                Console.WriteLine(oMovie.getData());
            }

            Console.ReadLine();
        }
    }
}
