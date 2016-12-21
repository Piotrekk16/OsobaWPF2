using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WpfApplication11
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;

        public Osoba() { }

        public void Ustaw(string imie, string nazwisko, DateTime data)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = data;
        }

        public int ObliczWiek()
        {
            return DateTime.Now.Year - dataUrodzenia.Year;
        }

        public override string ToString()
        {
            return imie + "\n" + nazwisko + Environment.NewLine + dataUrodzenia.ToString("dd.MM.yyyy",CultureInfo.InvariantCulture) + "\n" + ObliczWiek();
        }
    }
}
