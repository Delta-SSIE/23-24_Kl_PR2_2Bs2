using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv040_Zamestnanci
{
    internal class Dobrovolnik : Zamestnanec
    {
        public Dobrovolnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        //public override int Mzda()
        //{
        //    return 0;
        //}
        public override int Mzda() => 0;

    }
}
