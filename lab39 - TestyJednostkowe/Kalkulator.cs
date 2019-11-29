using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab39___TestyJednostkowe
{
    public class Kalkulator
    {
        public static decimal Dodaj(decimal x, decimal y)
        {
            return x + y;
        }
        public static decimal Odejmij(decimal x, decimal y)
        {
            return x - y;
        }
        public static decimal Pomnoz(decimal x, decimal y) => x * y;

        public static decimal Podziel(decimal x, decimal y)
        {
            if (y== 0)
            {
                throw new ArgumentException("dzielnik nie moze miec wartosci zero");
            }
            return x / y;
        }


    }
}
