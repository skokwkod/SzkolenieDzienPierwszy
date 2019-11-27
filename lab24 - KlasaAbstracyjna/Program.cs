using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstracyjna
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod samochod = new Samochod("BMW", 2019, 200);

            samochod.PokazPredkosc();


            Console.ReadKey();

        }
    }
}
