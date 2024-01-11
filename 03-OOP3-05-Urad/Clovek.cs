using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP3_05_Urad
{
    class Clovek
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Trvani { get; private set; }        

        public Clovek(string jmeno, string prijmeni, int trvani)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Trvani = trvani;
        }

        public static Clovek RndClovek(int minPozadavek, int maxPozadavek, Random random)
        {
            string jmeno = random.Next(0, 100000).ToString();
            string prijmeni = random.Next(0, 100000).ToString();
            int trvani = random.Next(minPozadavek, maxPozadavek + 1);
            return new Clovek(jmeno, prijmeni, trvani);
        }
    }
}
