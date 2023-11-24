using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv030_Ucty
{
    //Třída SporiciUcet
    //    Spořící účet bude dědit ze třídy Ucet, navíc ale bude

    //    Mít veřejnou vlastnost UrokovaMira(double). Hodnota 1.35 bude znamenat, že úroková míra je 1,35%
    //Mít veřejnou metodu Urokuj(), která připíše na účet úroky podle úrokové míry
    internal class SporiciUcet : Ucet
    {
        /// <summary>
        /// Úroková míra v jednotkách procento
        /// </summary>
        public double UrokovaMira { get; set; }

        public void Urokuj()
        {
            Stav += Stav / 100 * UrokovaMira;
        }
    }
}
