using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FORD", 2010,180);
            samochod.PokaFure();

            Samochod samochod2 = new Samochod("Audi", 2010);
            samochod2.PokaFure();


            Console.ReadKey();

        }
    }
}
