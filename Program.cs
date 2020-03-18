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
            lstMovies.Add(new Movie());
            lstMovies[0].Name = "The Lord of the Rings";
            lstMovies[0].Genre = "Adventure";

            lstMovies.Add(new Movie());
            lstMovies[1].Name = "The Hobbit";
            lstMovies[1].Genre = "Adventure";

            foreach (Movie oMovie in lstMovies)
            {
                Console.WriteLine(oMovie.getData());
            }

            Console.ReadLine();
        }
    }
}
