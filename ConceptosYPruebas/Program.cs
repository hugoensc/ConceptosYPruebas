using System;

namespace ConceptosYPruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Base b = new Base("Hugo Enrique");
            Base a = b;

            b.Name = "Cristina Citlalli";

            b.printName();
            a.printName();


            Console.ReadKey();  
        }
    }
}
