using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab27___KlasaSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaPochodna klasaPochodna = new KlasaPochodna();

            klasaPochodna.Test();

            KlasaBardziejPochodna klasaBardziejPochodna = new KlasaBardziejPochodna();

            klasaBardziejPochodna.Test();


            Console.ReadKey();
        }
    }
}
