using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Class1
    {
        //if i make this string private then I cant access it in main program.
        //so use get set to access this values outside the class even if they are private!
        private string name;
        private string location;
        public Class1(string a, string b)
        {
            name = a;
            location = b;
        }
        public string Name { get; set; }
        public string Location { get; set; }   
        //now i can make use of name and location outside the class1.
        //set is use to assign value and that value will be printed by set
    }
}


