﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Child:Parent
    {

        public override void Display(string name)
        {
            Console.WriteLine($"I am child {name}");
        }
    }
}
