using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_OOP2_cv030_Ucty
{
//    //Třída UcetSPoplatkem
//    I účet s poplatkem bude dědit ze třídy Ucet

//    Bude mít veřejné vlastnosti PoplatekZaVyber a PoplatekZaVklad(double)
//Změní metody Vyber a Uloz tak, aby se před provedením operace nejprve z účtu strhl poplatek. (Poradíte si s vyvoláním výjimky při nemožném výběru, aby nedošlo ke stržení poplatku ale jen k výjimce?)
    internal class UcetSPoplatkem : Ucet
    {
        public double PoplatekZaVyber { get; set; }
        public double PoplatekZaVklad { get; set; }

        public override void Uloz(double castka)
        {
            base.Uloz(castka - PoplatekZaVklad);
        }

        public override void Vyber(double castka)
        {
            base.Vyber(castka + PoplatekZaVyber);
        }
    }
}
