using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_OOP2_cv020_Pocitadlo
{
    //3. DownCounter
    // Rozšiřte v další třídě počítadlo StepCounter tak, aby se mu v konstruktoru předával nejen Step ale také initValue(počíteční hodnota). DownCounter bude využívat konstruktor bázové třídy a bude ji rozšiřovat tak že při zavolání Next hodnota počítadla klesne o předanou hodnotu.
    // DownCounter bude mít dále vlastnost IsFinished, která bude vrace true v případě, že odpočet došel na nulu(nebo níže)
    // Metoda Reset stále funkční
    internal class DownCounter : StepCounter
    {
        public int InitValue { get; private set; }
        public bool IsFinished
        {
            get
            {
                return Count <= 0;
            }
        }
        //public bool IsFinished => Count <= 0;

        public DownCounter(int step, int initValue) : base(step)
        {
            InitValue = initValue;
            Count = initValue;
        }

        public override void Next()
        {
            Count -= Step;
        }
        public override void Reset()
        {
            Count = InitValue;
        }
    }
}
