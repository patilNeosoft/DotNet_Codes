using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExe
{
   class AbsChild :AbsParent
    {
        
        public override void Mul()                //implement abstract method of parent
        {
            Console.WriteLine("this is sub method from abstract class");
        }

        public override void Sub()                //implement abstract method of parent
        {
            Console.WriteLine("this is sub method from abstract class");
        }
        
    }
}
