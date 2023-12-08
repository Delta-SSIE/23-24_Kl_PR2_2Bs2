using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv040_Zamestnanci
{
    internal class Firma
    {
        private List<Zamestnanec> _personal = new List<Zamestnanec>();
        public void Zamestnej(Zamestnanec osoba)
        {
            if (_personal.Contains(osoba))
                return; //podruhé na seznam nepřipíšu

            _personal.Add(osoba);
        }
        public void Propust(Zamestnanec osoba)
        {
            _personal.Remove(osoba);
        }
        public void Vyplata()
        {
            int celkem = 0;
            foreach(Zamestnanec osoba in _personal)
            {
                celkem += osoba.Mzda();
                Console.WriteLine($"{osoba.Prijmeni} {osoba.Jmeno} : {osoba.Mzda()},- Kč");
            }
            Console.WriteLine("------");
            Console.WriteLine($"Celkem {celkem},- Kč");
        }
    }
}
