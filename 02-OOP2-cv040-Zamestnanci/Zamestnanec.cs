using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv040_Zamestnanci
{
    internal abstract class Zamestnanec
    {
        public string Jmeno { get; init; }
        public string Prijmeni { get; init; }

        protected Zamestnanec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public abstract int Mzda(); //neříkám jak, ale ohlašuji, že každý zaměstnanec musí vypočítávat mzdu
    }
}
