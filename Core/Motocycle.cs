﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1.Core
{
    internal class Motocycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Двигатель запущен");
        }
    }
}
