using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16___Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(WezOsobe().GetType());
            Console.WriteLine(WezOsobe().Item1);

            Console.ReadKey();
        }

        public static (string imie, string nazwisko) WezOsobe()
        {
            var nazwa = (imie: "Kubus", nazwisko: "Puchatek");

            return nazwa;

        }

    }
}
