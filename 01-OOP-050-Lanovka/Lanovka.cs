using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_050_Lanovka
{
    internal class Lanovka
    {
        public int Delka { get; private set; }
        public double Nosnost { get; private set; }

        private Clovek[] _sedacky;
        public double Zatizeni
        {
            get
            {
                double celkem = 0;
                foreach (Clovek pasazer in _sedacky)
                {
                    if (pasazer != null)
                        celkem += pasazer.Hmotnost;
                }
                return celkem;
            }
        }
        //public double Zatizeni => _sedacky.Select(x => x == null ? 0 : x.Hmotnost).Sum();

        //public bool JeVolnoDole
        //{
        //    get
        //    {
        //        if (_sedacky[0] == null)
        //            return true;
        //        else
        //            return false;
        //    }
        //}
        public bool JeVolnoDole => _sedacky[0] == null;
        public bool JeVolnoNahore => _sedacky[Delka - 1] == null;


        public Lanovka(int delka, double nosnost)
        {
            Delka = delka;
            _sedacky = new Clovek[Delka];

            Nosnost = nosnost;
        }

        /// <summary>
        /// Umístí člověka na první sedačku
        /// </summary>
        /// <param name="pasazer"></param>
        /// <returns>true, když pasažér nastoupil, false, když se nevejde</returns>
        public bool Nastup(Clovek pasazer)
        {
            if (!JeVolnoDole)
                return false;
            
            if (pasazer.Hmotnost + Zatizeni > Nosnost)
                return false;

            _sedacky[0] = pasazer;
            return true;
        }

        public Clovek Vystup()
        {
            Clovek pasazer = _sedacky[Delka - 1];
            _sedacky[Delka - 1] = null;
            return pasazer;
        }

        public void Jed()
        {
            if (_sedacky[Delka - 1] != null)
                throw new Exception("Nelze jet, nahoře někdo sedí");

            //půjdu odshora, budu "přesazovat"
            for (int i = Delka - 1; i > 0; i--)
            {
                _sedacky[i] = _sedacky[i - 1];
            }

            _sedacky[0] = null;
        }
    }
}
