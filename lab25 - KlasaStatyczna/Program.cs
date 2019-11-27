using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab25___KlasaStatyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kalkulator.Dodaj(10.2M ,5));
            Console.WriteLine(Kalkulator.Odejmij(10.2M, 5));
            Console.WriteLine(Kalkulator.Pomnoz(10.2M, 5));
            Console.WriteLine(Kalkulator.Podziel(10.2M, 5));


            Console.ReadKey();
        }
    }
}
