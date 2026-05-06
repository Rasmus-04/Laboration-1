using System;
using System.Collections.Generic;

namespace Laboration_1
{
    public class Aktivitet
    {
        public int Id { get; }
        public string Namn { get; set; }
        public DateTime Datum { get; set; }
        public Spel Spel { get; set; }

        private List<Medlem> deltagare = new List<Medlem>();

        public Aktivitet(int id, string namn, DateTime datum, Spel spel)
        {
            Id = id;
            Namn = namn;
            Datum = datum;
            Spel = spel;
        }

        public void AddDeltagare(Medlem medlem)
        {
            if (deltagare.Contains(medlem))
                throw new Exception("Medlem redan tillagd");

            deltagare.Add(medlem);
        }

        public List<Medlem> GetDeltagare()
        {
            return deltagare;
        }

        public int AntalDeltagare()
        {
            return deltagare.Count;
        }
    }
}
