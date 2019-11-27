using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze();
            pies.nazwa = "Pies";
            pies.iloscNog = 4;
            pies.iloscOczu = 2;

            Console.WriteLine( pies.Opis());
            pies.OpisKonsola();


            Console.ReadKey();
        }
    }
}
