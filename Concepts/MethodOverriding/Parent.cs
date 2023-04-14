using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Parent
    {
        public virtual void Display(string name)
            {
                Console.WriteLine($"I am Parent {name}");
            }
        }
    }

