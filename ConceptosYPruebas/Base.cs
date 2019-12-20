using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosYPruebas
{
    class Base
    {
        public string Name
        {
            get;
            set;
        }

        public Base(string name)
        {
            Name = name;
        }

        public void printName()
        {
            Console.WriteLine(Name);
        }
    }
}
