using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28___Interfejsy
{
    interface IPojazd
    {
        string Marka { get; set; }
        int RokProdukcji { get;; }
       int AktualnaPredkosc { get; set; }
        int MaksymalnaPredkosc { get; set; }
        bool WlaczonySilnik { get; set; }
        void Uruchom();

        void Zatrzymaj();

        void Przyspiesz(int wartosc);
        void Zwolnij(int wartosc);

    }
}
