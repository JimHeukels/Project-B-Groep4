using System;

namespace Bioscoopkiezer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecteer uw bioscoop om de films van die bioscoop te kunnen zien:\nKies 1 om de beschikbare films van bioscoop 1 te zien.\nKies 2 om de beschikbare films van bioscoop 2 te zien.");
            int kiezer = Int32.Parse(Console.ReadLine());
            string[] Bioscoop1 = { "No Time To Die", "Parasite", "1917", "The Dark Knight", "Toy Story 4", "Roma", "Interstellar" };
            string[] Bioscoop2 = { "Avengers: Endgame", "Iron Man", "Spiderman 3: Far From Home", "Once Upon A Time In Hollywood", "Hatefull Eight", "Django Unchained" };
            Console.WriteLine("Uw heeft gekozen voor bioscoop (" + (kiezer) + ")");
            if (kiezer == 1)
            {
                Console.WriteLine("\nBeschikbare films:");
                foreach (string i in Bioscoop1)
                {
                    Console.WriteLine(i);
                }
                
            }
            else if (kiezer == 2)
            {
                Console.WriteLine("\nBeschikbare films:");
                foreach (string i in Bioscoop2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
