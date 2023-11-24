using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv030_Ucty
{
    //Třída Ucet
    //    Vytvořte třídu pro bankovní účet.

    //    Bude mít veřejnou vlastnost Stav(double) se soukromým zápisem
    //    Bude mít veřejné metody Uloz(double castka) a Vyber(double castka)
    //v případě nesmyslného vstupu budou vyvolávat výjimku
    //v případě pokusu o výběr pod nulový stav účtu vyvolá výjimku
    //Bude mít nějaký hezký ToString()
    internal class Ucet
    {
        public double Stav { get; protected set; }
        public virtual void Uloz(double castka)
        {
            if (castka <= 0)
                throw new ArgumentOutOfRangeException(nameof(castka), "Nelze uložit zápornou částku");

            Stav += castka;
        }

        public virtual void Vyber(double castka)
        {
            if (castka <= 0)
                throw new ArgumentOutOfRangeException(nameof(castka), "Nelze výbrat zápornou částku");

            else if (castka > Stav)
                throw new Exception("Nedostatek peněz");

            Stav -= castka;
        }

        public override string? ToString()
        {
            return $"Účet se zůstatkem {Stav} Kč";
        }
    }
}
