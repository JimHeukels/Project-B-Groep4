using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Movie
    {
        public string Name;
        public string Genre;

        public Movie(String name, String genre)
        {
            this.Name = name;
            this.Genre = genre;
        }

        public Movie(String name)
        {
            this.Name = name;
        }

        public string getData()
        {
            return this.Name + "\nis an " + this.Genre + " based movie!\n";
        }
    }
}

