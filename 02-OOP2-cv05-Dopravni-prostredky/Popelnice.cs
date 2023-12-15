using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv_05_Dopravni_prostredky
{
    internal class Popelnice : IPojizdny
    {
        public int PocetKol { get; private set; }

        public Popelnice(int pocetKol)
        {
            PocetKol = pocetKol;
        }

        //a spousta dalších jiných metod a vlastnosti
    }
}
