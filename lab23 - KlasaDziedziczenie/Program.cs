using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23___KlasaDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Toyota", 2009, 160);


            Console.WriteLine($"{ samochod.Marka}\n{ samochod.RokProdukcji}");


            Console.ReadKey();
        }
    }
}
