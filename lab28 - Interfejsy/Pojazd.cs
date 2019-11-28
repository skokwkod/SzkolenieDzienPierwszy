using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28___Interfejsy
{
    class Pojazd : IPojazd
    {
        private string marka;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maksymalnaPredkosc;
        private bool wlaczonySilnik;

        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc { get => maksymalnaPredkosc; set => maksymalnaPredkosc = value; }
        public bool WlaczonySilnik { get => wlaczonySilnik; set => wlaczonySilnik = value; }


        public void Przyspiesz(int wartosc)
        {
            if ((aktualnaPredkosc + wartosc) <= maksymalnaPredkosc)
            {
                aktualnaPredkosc += wartosc;
            }
            else aktualnaPredkosc = maksymalnaPredkosc;
        }

        public void Uruchom()
        {
            throw new NotImplementedException();
        }

        public void Zatrzymaj()
        {
            throw new NotImplementedException();
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
