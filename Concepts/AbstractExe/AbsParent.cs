using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExe
{
    //use abstract keyword to create abstract class
    abstract class AbsParent
    {
        //create absract method.this class can also contaion non abstract methods also

        public void Add()            //non abstract method
        {
            Console.WriteLine("add method");
        }
        public abstract void Sub();  //dont define body of abstract class
        public abstract void Mul();
    }
}
