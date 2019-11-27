using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaWlasciwosci__cwiczenie_
{
    class Zwierze
    {
        /// <summary>
        /// Tutaj mamy parametry zwierzakow
        /// </summary>
        private string nazwa;
        private int iloscNog;
        private int iloscOczu;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int IloscNog { get => iloscNog; set => iloscNog = value; }
        public int IloscOczu { get => iloscOczu; set => iloscOczu = value; }

        public Zwierze()
        {
        }

        public Zwierze(string nazwa, int iloscOczu,int iloscNog)
        {
            this.Nazwa = nazwa;
            this.IloscOczu = iloscOczu;
            this.IloscNog = iloscNog;
        }

        public Zwierze(string nazwa, int iloscOczu) :this(nazwa,iloscOczu,4)
        {

        }





        /// <summary>
        /// Metoda zwróci opis danego zwierzaka
        /// </summary>
        public void OpisKonsola()
        {
            Console.WriteLine($"ODPALANA KONSOLA\nNazwa: {Nazwa}\nIlosc Nog: {IloscNog}\nIlosc Oczu:" +
                $"{IloscOczu}\n");

        }   
        public string Opis()
        {
            return $"ZWRACANY STRING\nNazwa: {Nazwa}\nIlosc Nog: {IloscNog}\nIlosc Oczu:" +
                $"{IloscOczu}\n";
        }
    }
}
