using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_OOP2_cv020_Pocitadlo
{
    //1. Counter (počítadlo)
    
    //Vytvořte kód třídy Counter tak, aby každé počítadlo mělo:

    //vlastnost Count(celé číslo, stav), který lze veřejně zjistit
    //metodu Next, která nic nevrací, ale zvýší počítadlo o 1
    //metodu Reset, která vrátí počítadlo zpět na nulu
    internal class Counter
    {
        public int Count { get; protected set; }
        public virtual void Next() 
        {
            Count++;
        }
        public virtual void Reset()
        {
            Count = 0;
        }
    }
}
