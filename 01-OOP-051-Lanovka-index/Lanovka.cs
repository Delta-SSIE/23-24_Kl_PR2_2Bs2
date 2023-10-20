using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_051_Lanovka_index
{
    internal class Lanovka
    {
        public int Delka { get; private set; }
        public double Nosnost { get; private set; }

        private int _indexPrvniSedacky;
        private int _indexPosledniSedacky
        {
            get
            {
                if (_indexPrvniSedacky != 0)
                    return _indexPrvniSedacky - 1;
                else
                    return Delka - 1;
            }
        }

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
        public bool JeVolnoDole => _sedacky[_indexPrvniSedacky] == null;
        public bool JeVolnoNahore => _sedacky[_indexPosledniSedacky] == null;


        public Lanovka(int delka, double nosnost)
        {
            Delka = delka;
            _sedacky = new Clovek[Delka];

            Nosnost = nosnost;

            _indexPrvniSedacky = 0;
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

            _sedacky[_indexPrvniSedacky] = pasazer;
            return true;
        }

        public Clovek Vystup()
        {
            Clovek pasazer = _sedacky[_indexPosledniSedacky];
            _sedacky[_indexPosledniSedacky] = null;
            return pasazer;
        }

        public void Jed()
        {
            if (!JeVolnoNahore)
                throw new Exception("Nelze jet, nahoře někdo sedí");

            _indexPrvniSedacky = _indexPosledniSedacky; //posunu index o 1 dozadu
            //_sedacky[_indexPrvniSedacky] = null; //na 1  nesmí nikdo sedět - ani nemusím
        }
    }
}
