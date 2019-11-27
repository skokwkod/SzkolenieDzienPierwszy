using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___typEnumSwitch_cwiczenie_
{
    enum WielkoscKawy
    {
        mala,
        normalna,
        duza
    }
    class Program
    {
        static void Main(string[] args)
        {
            WielkoscKawy wielkoscKawy = WielkoscKawy.normalna;

            switch (wielkoscKawy)
            {
                case WielkoscKawy.mala:
                    Console.WriteLine($"Kawa {WielkoscKawy.mala} - 3zl");
                    break;
                case WielkoscKawy.normalna:

                    Console.WriteLine($"Kawa {WielkoscKawy.normalna} - 4,50zl");
                    break;
                case WielkoscKawy.duza:

                    Console.WriteLine($"Kawa {WielkoscKawy.duza} - 6zl");
                    break;
            }
            Console.ReadKey();
        }
    }
}
