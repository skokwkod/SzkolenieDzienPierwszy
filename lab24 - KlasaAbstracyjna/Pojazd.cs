﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstracyjna
{
    public abstract class Pojazd
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


        public virtual void PokazPredkosc()
        {
            Console.WriteLine($"Aktualna predkosc: {AktualnaPredkosc}");
        }

        public abstract void Uruchom();

        public abstract void Zatrzymaj();

        public abstract void Przyspiesz(int wartosc);

        public abstract void Zwolnij(int wartosc);

    }
}
