using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_052_Lanovka_linked
{
    internal class Lanovka
    {
        public int Delka { get; private set; }
        public double Nosnost { get; private set; }
        private Sedacka _horniSedacka;
        private Sedacka _dolniSedacka;
        public Lanovka(int delka, double nosnost)
        {
            Delka = delka;
            Nosnost = nosnost;

            VytvorSedacky();
        }

        private void VytvorSedacky()
        {
            _horniSedacka = new Sedacka();
            Sedacka posledniVyrobena = _horniSedacka;

            for (int i = 0; i < Delka - 1; i++)
            {
                Sedacka nova = new Sedacka();
                posledniVyrobena.Dalsi = nova;
                posledniVyrobena = nova;
            }

            _dolniSedacka = posledniVyrobena;
        }

        public bool JeVolnoDole { 
        get
            {
                return _dolniSedacka.Pasazer == null;
            } 
        }
        public bool JeVolnoNahore
        {
            get
            {
                return _horniSedacka.Pasazer == null;
            }
        }
        public double Zatizeni
        {
            get
            {
                double celkem = 0;

                //projít všechny sedačky
                Sedacka tahle = _horniSedacka;
                do
                {
                    if (tahle.Pasazer != null)
                        celkem += tahle.Pasazer.Hmotnost;
                    tahle = tahle.Dalsi;
                }
                while (tahle != null);

                return celkem;
            }
        }

        public bool Nastup(Clovek pasazer)
        {
            if (!JeVolnoDole)
                return false;

            if (pasazer.Hmotnost + Zatizeni > Nosnost)
                return false;

            _dolniSedacka.Pasazer = pasazer;
            return true;
        }

        public Clovek Vystup()
        {
            Clovek pasazer = _horniSedacka.Pasazer;
            _horniSedacka.Pasazer = null;
            return pasazer;
        }
        public void Jed()
        {
            if (!JeVolnoNahore)
            {
                throw new Exception("Nelze jet, nahoře někdo sedí");
            }

            _horniSedacka = _horniSedacka.Dalsi;
            
            Sedacka novaDolni = new Sedacka();
            _dolniSedacka.Dalsi = novaDolni;

            _dolniSedacka = novaDolni;
        }
    }
}
