using System;

namespace Laboration_1
{
    public class Spel
    {
        public int Id { get; }
        public string Titel { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public Spel(int id, string titel, int minPlayers, int maxPlayers)
        {
            Id = id;
            Titel = titel;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
        }

        public override string ToString()
        {
            return $"{Titel} ({MinPlayers}-{MaxPlayers} players)";
        }
    }
}