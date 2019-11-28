using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26lab___KlasaStatycznaPole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gracz.NextId);
            Console.WriteLine(Gracz.NextId);

            Gracz[] gracze = new Gracz[3];

            gracze[0] = new Gracz();

            Console.WriteLine(gracze[0].Id + " " + gracze[0].Nick);

            gracze[0] = new Gracz("Przegrany");
            gracze[1] = new Gracz("Wygrany");
            gracze[2] = new Gracz("Statysta");

            foreach (var item in gracze)
            {
                Console.WriteLine(item.Id + " " + item.Nick);
            }


            Console.ReadKey();
        }
    }
}
