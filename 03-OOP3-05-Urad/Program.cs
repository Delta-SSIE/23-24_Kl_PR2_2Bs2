﻿namespace _03_OOP3_05_Urad
{
    class Program
    {
        public static void Main(string[] args)
        {

            int pocetPrepazek = 4;

            Clovek[] lide =
            {
                new Clovek("Josef", "Smutný", 4),
                new Clovek("Anna", "Veselá", 3),
                new Clovek("Marie", "Zelená", 12),
                new Clovek("Jiří", "Červenka", 3),
                new Clovek("Antonín", "Černý", 5),
                new Clovek("Antonie", "Bohatá", 7),
                new Clovek("Richard", "Těsný", 4),
                new Clovek("Luisa", "Podhorská", 15),
            };

            Queue<Clovek> fronta = new Queue<Clovek>(lide);

            // vytvořit přepážky
            Prepazka[] prepazky = new Prepazka[pocetPrepazek];
            for (int i = 0; i < pocetPrepazek; i++)
            {
                prepazky[i] = new Prepazka(i + 1);
            }

            // spustit hodiny
            int cas = 0;

            // dokud jsou lidi ve frontě
            while(fronta.Count > 0) 
            {

                // projdu přepážky
                foreach (Prepazka prepazka in prepazky) 
                {
                    if (fronta.Count == 0)
                        break;

                    // pokud je volno, předám přepážce člověka
                    if (cas >= prepazka.KdyBudeVolno)
                    {
                        Clovek clovek = fronta.Dequeue();
                        prepazka.Vyres(clovek, cas);
                    }
                }

                // posunout hodiny
                cas++;
            }
        }
    }


}
