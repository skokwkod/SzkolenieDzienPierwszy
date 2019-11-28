using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28___Interfejsy_Cwiczenie_
{
    class KontoTypA : IKontoBankowe
    {
        //private decimal saldo;

        public decimal Saldo { get; private set; }

        public void Wplac(decimal wartosc)
        {
            Saldo += wartosc;
            Console.WriteLine($"Wpłata {wartosc} - aktualne saldo: {Saldo}");
        }

        public bool Wyplac(decimal wartosc)
        {
            if ((Saldo - wartosc) < 0)
            {
                Console.WriteLine("Nie posiadasz wystarczajacych srodkow");
                return false;
            }
            else
            {
                Saldo -= wartosc;
                Console.WriteLine($"Wypłata {wartosc} - aktualne saldo: {Saldo}");
                return true;
            }
        }

        public bool ZrobPrzelew(IKontoBankowe kontoB, decimal wartosc)
        {
            Console.WriteLine($"Przelew z konta A - {wartosc}");
            if (this.Wyplac(wartosc))
            {

                kontoB.Wplac(wartosc);
                return true;
            }
            return false;
        }
    }
}
