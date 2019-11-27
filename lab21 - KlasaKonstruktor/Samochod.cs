using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor
{
    class Samochod
    {
        public string marka;
        public int rokProdukcji;
        public int aktualnaPredkosc;
        public int maksymalnaPredkosc;

        public Samochod(string marka, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.marka = marka ?? throw new ArgumentNullException(nameof(marka));
            this.rokProdukcji = rokProdukcji;
            this.maksymalnaPredkosc = maksymalnaPredkosc;
            this.aktualnaPredkosc = 0;
        }

        public Samochod(string marka, int rokProdukcji) : this(marka, rokProdukcji, 200)
        {

        }

        public void PokaFure()
        {
            Console.WriteLine($"Marka: {marka}\nRok Produkcji: {rokProdukcji}\nMaksymalna Predkosc:" +
                $"{maksymalnaPredkosc}\nAktualna Predkosc {aktualnaPredkosc}");

        }

        public void Przyspiesz(int wartosc)
        {
            if ((aktualnaPredkosc + wartosc) <= maksymalnaPredkosc)
            {
                aktualnaPredkosc += wartosc;
            }
            else aktualnaPredkosc = maksymalnaPredkosc;
        }
        public void Zwolnij(int wartosc)
        {
            if ((aktualnaPredkosc - wartosc) < 0)
            {
                aktualnaPredkosc = 0;
            }
        }
    }

}
