using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_05_Urad
{
    internal class Prepazka
    {
        public int Cislo { get; private set; }
        public int KdyBudeVolno { get; private set; }

        public Prepazka(int cislo)
        {
            Cislo = cislo;
            KdyBudeVolno = 0;
        }

        public void Vyres(Clovek clovek, int cas)
        {
            KdyBudeVolno = cas + clovek.Trvani;
            Console.WriteLine($"Prepazka {Cislo} : {clovek.Jmeno} {clovek.Prijmeni} : {cas} - {KdyBudeVolno}");
        }
    }
}
