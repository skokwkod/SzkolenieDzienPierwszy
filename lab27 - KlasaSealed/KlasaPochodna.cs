using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab27___KlasaSealed
{
    class KlasaPochodna : KlasaBazowa
    {
        public sealed override void Test()
        {
            base.Test();
            Console.WriteLine("Klasa Pochodna - metoda Test");
        }
    }
}
