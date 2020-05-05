using JimFilmsTake2.Db;
using JimFilmsTake2.Model;
using System;

namespace JimFilmsTake2
{
    class Program
    {
        static void Main(string[] args)
        {
            // maken een bioscoop met 1 scherm
            // maak de repository aan, de koppeling tussen onze code en de database
            var repo = new BioscoopRepository();
            var bioscoop = new Bioscoop("Pathe", "Azaleastraat 15");
            // wat mock data om te testen
            var vertoning = new Vertoning(2, 5, DateTime.Now.AddHours(2));
            var scherm = new Scherm(1);
            scherm.Vertoningen[vertoning.AanvangsTijd.ToString()] = vertoning;

            bioscoop.Schermen.Add(scherm);

            // Voeg de bioscoop met al zijn data toe aan de repository
            repo.AddBioscoop(bioscoop);
            repo.UpdateData();
            // Voeg nog een scherm toe aan bioscoop
            var scherm2 = new Scherm(2);
            repo.AddScherm(bioscoop, scherm2);
            repo.UpdateData();

            //var repo = new BioscoopRepository();
            var bioscopen = repo.GetBioscopen();

        }
    }
}
//HALLOASDOAKDSIPASKJd