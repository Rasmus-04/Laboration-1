using System;

namespace Laboration_1
{
    public class Spel
    {
        public int Id { get; }
        public string Titel { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public Spel(string titel, int maxPlayers, int minPlayers, int id=0)
        {
            Id = id;
            Titel = titel;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
        }

        public override string ToString()
        {
            return $"{Titel}";
        }
    }
}