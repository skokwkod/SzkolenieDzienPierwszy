using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaKostruktor__cwiczenie3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat = new Prostokat(new Wspolrzedne(2, 5), 3, 4);

            Console.WriteLine($"Obwod: {prostokat.Obwod().ToString()}");
            Console.WriteLine($"Pole: {prostokat.Pole().ToString()}");
            Console.WriteLine(prostokat.prawyDolnyRog.x);
            prostokat.PokazWspolrzedne();
            Console.WriteLine(prostokat.prawyDolnyRog.x);


            Console.ReadKey();

        }
    }
}
