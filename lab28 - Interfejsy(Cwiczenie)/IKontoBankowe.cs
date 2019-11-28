using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28___Interfejsy_Cwiczenie_
{
    interface IKontoBankowe
    {
        decimal Saldo { get;}


        public void Wplac(decimal wartosc);
        public bool Wyplac(decimal wartosc);
        public bool ZrobPrzelew(IKontoBankowe konto, decimal wartosc);
        
    }
}
