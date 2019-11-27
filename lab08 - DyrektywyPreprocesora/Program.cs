#define Przyklad1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08___DyrektywyPreprocesora
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PierwszyRegion

            Console.WriteLine("PierwszyRegion");
            Console.WriteLine("PierwszyRegion");
            Console.WriteLine("PierwszyRegion");
            Console.WriteLine("PierwszyRegion");

            #endregion


#if(Przyklad1)
            int a = 10;
            Console.WriteLine($"Przyklad pierwszy{a}");
#elif(Przyklad2)
            int a = 10;
            Console.WriteLine($"Przyklad pierwszy{a}");
#endif
        }
    }
}
