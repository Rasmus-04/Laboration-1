using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Laboration_1
{
    public class Aktivitet: INotifyPropertyChanged
    {
        public int Id { get; }
        public string Namn { get; set; }
        public DateTime Datum { get; set; }
        public Spel Spel { get; set; }
        public int MaxDeltagare { get; set; }

        public int AntalDeltagare 
        { 
            get { return deltagare.Count; } 
        }

        //private List<Medlem> deltagare = new List<Medlem>();

        private ObservableCollection<Medlem> deltagare = new ObservableCollection<Medlem>();

        public ObservableCollection<Medlem> Deltagare {  get { return deltagare; } }

        public Aktivitet(string namn, DateTime datum, Spel spel, int maxDeltagare, int id = 0)
        {
            Id = id;
            Namn = namn;
            Datum = datum;
            Spel = spel;
            MaxDeltagare = maxDeltagare;
        }

        public void AddDeltagare(Medlem medlem)
        {
            if (deltagare.Contains(medlem))
                throw new Exception("Medlem redan tillagd");

            deltagare.Add(medlem);

            OnPropertyChanged(nameof(AntalDeltagare));
        }

        public void RemoveDeltagare(Medlem medlem)
        {
            if (deltagare.Contains(medlem))
            {
                deltagare.Remove(medlem);
                OnPropertyChanged(nameof(AntalDeltagare));

            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
