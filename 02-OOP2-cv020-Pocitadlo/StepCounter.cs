using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_cv020_Pocitadlo
{
    //2. StepCounter
    //Rozšiřte pomocí dědičnosti v nové třídě počítadlo tak, aby se mu v kontruktoru předávala hodnota step(krok). Při volání metody Next se pak bude zvyšovat o tuto hodnotu.
    internal class StepCounter : Counter
    {
        public int Step { get; private set; }

        public StepCounter(int step)
        {
            Step = step;
        }

        public override void Next()
        {
            Count += Step;
        }
    }
}
