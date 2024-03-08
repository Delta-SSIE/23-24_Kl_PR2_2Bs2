using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unit_testing_02_RychlostniSkrin
{
    public enum Stupen { Zpatecka, Neutral, Jednicka, Dvojka, Trojka, Ctyrka, Petka, Sestka }
    
    public class RychlostniSkrin
    {

        public Stupen Zarazeno { get; private set; } = Stupen.Neutral;

        private int otacky;
        public int Otacky { 
            get => otacky; 
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                otacky = value;
            } 
        }
        public int MaxOtackyRazeni { get; private set; }

        public RychlostniSkrin(int maxOtackyRazeni)
        {
            if (maxOtackyRazeni < 0)
                throw new ArgumentOutOfRangeException();

            MaxOtackyRazeni = maxOtackyRazeni;
        }

        public void Nahoru()
        {

            if (Zarazeno == Stupen.Sestka) //výš se nejde
                return;
            else if (Otacky > MaxOtackyRazeni)
                return;

            Zarazeno += 1;
            //Zarazeno = (Stupen)(Zarazeno + 1);
        }
        public void Dolu()
        {
            if (Zarazeno == Stupen.Zpatecka) //níž se nejde
                return;
            else if (Otacky > MaxOtackyRazeni)
                return;

            Zarazeno -= 1;
        }
    }
}
