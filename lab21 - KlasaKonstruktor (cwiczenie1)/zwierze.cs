using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor__cwiczenie1_
{
    class Zwierze
    {
        /// <summary>
        /// Tutaj mamy parametry zwierzakow
        /// </summary>
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;

        public Zwierze()
        {
        }

        public Zwierze(string nazwa, int iloscOczu,int iloscNog)
        {
            this.nazwa = nazwa;
            this.iloscOczu = iloscOczu;
            this.iloscNog = iloscNog;
        }

        public Zwierze(string nazwa, int iloscOczu) :this(nazwa,iloscOczu,4)
        {

        }





        /// <summary>
        /// Metoda zwróci opis danego zwierzaka
        /// </summary>
        public void OpisKonsola()
        {
            Console.WriteLine($"ODPALANA KONSOLA\nNazwa: {nazwa}\nIlosc Nog: {iloscNog}\nIlosc Oczu:" +
                $"{iloscOczu}\n");

        }   
        public string Opis()
        {
            return $"ZWRACANY STRING\nNazwa: {nazwa}\nIlosc Nog: {iloscNog}\nIlosc Oczu:" +
                $"{iloscOczu}\n";
        }
    }
}
