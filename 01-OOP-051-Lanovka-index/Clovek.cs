﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_051_Lanovka_index
{
    internal class Clovek
    {
        public string Jmeno { get; set; }
        public double Hmotnost { get; set; }

        public Clovek(string jmeno, double hmotnost)
        {
            Jmeno = jmeno;
            Hmotnost = hmotnost;
        }
    }
}
