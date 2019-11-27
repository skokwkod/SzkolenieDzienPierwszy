using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaWlasciwosci
{
    class Samochod
    {
        private string marka;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maksymalnaPredkosc;

        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc { get => maksymalnaPredkosc;
            set {
                if (value > 150)
                {
                    maksymalnaPredkosc = 150;
                }
                else
                    maksymalnaPredkosc = value;
            }
                
                
                
                
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
