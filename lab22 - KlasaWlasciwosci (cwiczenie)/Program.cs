using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaWlasciwosci__cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze("pies", 2);

            Zwierze pajak = new Zwierze("Pajak", 8, 4);

            Zwierze mucha = new Zwierze("Mucha", 6, 4);

            pies.OpisKonsola();
            mucha.OpisKonsola();
            pajak.OpisKonsola();


            Console.ReadKey();

        }
    }
}
