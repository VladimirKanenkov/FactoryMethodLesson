﻿using System;

namespace Bad.Bidlos
{
    class Gopnik : IBidlo
    {
        public void BatleRoar()
        {
            Console.WriteLine("Есть чё позвонить?");
        }

        public override string ToString()
        {
            return "Гопник";
        }
    }
}
