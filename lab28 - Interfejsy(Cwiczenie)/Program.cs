using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28___Interfejsy_Cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            KontoTypA kontoA = new KontoTypA();
            KontoTypB kontoB = new KontoTypB();


            kontoA.Wplac(20000);
            kontoB.Wplac(1000);

            kontoB.ZrobPrzelew(kontoB, 200);


            Console.ReadKey();

        }
    }
}
