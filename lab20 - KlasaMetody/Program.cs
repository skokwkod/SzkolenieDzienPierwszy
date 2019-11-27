using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();
            samochod1.marka = "BMW";
            samochod1.rokProdukcji = 2000;
            samochod1.maksymalnaPredkosc = 220;
            samochod1.aktualnaPredkosc = 0;


            samochod1.PokaFure();
            samochod1.Przyspiesz(200);
            samochod1.PokaFure();
            samochod1.Zwolnij(300);
            samochod1.PokaFure();


            Console.ReadKey();

        }
    }
}
