﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using JimFilmsTake2.Model;
using Newtonsoft.Json;
namespace JimFilmsTake2.Db
{
    public class BioscoopRepository
    {

        private JsonModel _database { get; set; }
        public static readonly string FILEPATH = @"C:\School\2019-2020\ProjectB\ProjectB\ProjectB\Database\db.json";

        public BioscoopRepository()
        {

            var jsonString = File.ReadAllText(FILEPATH);
            this._database = new JsonModel();
            if (jsonString == "")
            {
                UpdateData();
            }
            else
            {
                this._database = JsonConvert.DeserializeObject<JsonModel>(jsonString);
            }
        }
        public void UpdateData()
        {
            File.WriteAllText(FILEPATH, JsonConvert.SerializeObject(this._database));
        }
        public void AddBioscoop(Bioscoop bioscoop)
        {
            // Checken of de bioscoop niet al bestaat, dit doet de contains functie voor ons.
            if (!_database.Bioscopen.Contains(bioscoop))
            {
                // bestaat deze niet al voegen we hem toe
                this._database.Bioscopen.Add(bioscoop);
            }
            // bestaat die wel doen we een error gooien met info over de desbetreffende bioscoop
            else
            {
                throw new Exception($"Bioscoop met naam {bioscoop.Naam} bestaat al in de database");
            }
        }
        public void AddScherm(Bioscoop bioscoop, Scherm scherm)
        {
            // loop door de bioscopen heen in de database
            foreach (var _bioscoop in _database.Bioscopen)
            {
                // We hebben de juiste bioscoop gevonden
                if (_bioscoop == bioscoop)
                {
                    // We kijken of de bioscoop niet toevallig al eenzelfde scherm bevat, we checken nu of het hele schermobject hetzelfde is, 
                    // niet of er bijvoorbeeld al een scherm bestaat met eenzelfde nummer
                    if (!_bioscoop.Schermen.Contains(scherm))
                    {
                        _bioscoop.Schermen.Add(scherm);
                    }
                    // Anders gooien we een error, deze komt dan naar boven als we een scherm dubbel proberen toe te voegen
                    else
                    {
                        throw new Exception($"Bioscoop met naam {bioscoop.Naam} bestaat heeft al een scherm met nummer {scherm.Nummer}");
                    }
                }

            }
        }
        public IList<Bioscoop> GetBioscopen()
        {
            return _database.Bioscopen;
        }
    }
}
