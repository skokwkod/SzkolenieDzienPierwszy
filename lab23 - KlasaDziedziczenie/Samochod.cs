using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23___KlasaDziedziczenie
{
    class Samochod : Pojazd
    {
        public Samochod(string marka, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.Marka = marka;
            this.RokProdukcji = rokProdukcji;
            this.MaksymalnaPredkosc = maksymalnaPredkosc;
            
        }
        public void PokaFure()
        {
            Console.WriteLine($"Marka: {Marka}\nRok Produkcji: {RokProdukcji}\nMaksymalna Predkosc:" +
                $"{MaksymalnaPredkosc}\nAktualna Predkosc {AktualnaPredkosc}");

        }

        public void Przyspiesz(int wartosc)
        {
            if ((AktualnaPredkosc + wartosc) <= MaksymalnaPredkosc)
            {
                AktualnaPredkosc += wartosc;
            }
            else AktualnaPredkosc = MaksymalnaPredkosc;
        }
        public void Zwolnij(int wartosc)
        {
            if ((AktualnaPredkosc - wartosc) < 0)
            {
                AktualnaPredkosc = 0;
            }

        }
    }
}
