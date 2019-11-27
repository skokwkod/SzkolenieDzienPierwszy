using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstracyjna
{
    class Samochod : Pojazd
    {
        public Samochod(string marka, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.Marka = marka;
            this.RokProdukcji = rokProdukcji;
            this.MaksymalnaPredkosc = maksymalnaPredkosc;
        }


        public override void Przyspiesz(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if ((AktualnaPredkosc + wartosc) <= MaksymalnaPredkosc)
                {
                    AktualnaPredkosc += wartosc;
                }
                else AktualnaPredkosc = MaksymalnaPredkosc;
            }
            else
            {
                Console.WriteLine("Najpierw uruchom silnik");
            }
        }

        public override void Uruchom()
        {
            WlaczonySilnik = true;
        }

        public override void Zatrzymaj()
        {
            WlaczonySilnik = false;
        }

        public override void Zwolnij(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if ((AktualnaPredkosc - wartosc) < 0)
                {
                    AktualnaPredkosc = 0;
                }
            }
            else
            {
                Console.WriteLine("Najpierw uruchom silnik");
            }
        }
        public override void PokazPredkosc()
        {
            base.PokazPredkosc();
            if (AktualnaPredkosc == 0)
            {
                Console.WriteLine("Stoi w miejscu");
            }
            else if (AktualnaPredkosc > 90)
            {
                Console.WriteLine("Jedziesz za szybko");
            }
        }
    }

}


