﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody_cwiczenia_
{
    class Zwierze
    {
        /// <summary>
        /// Tutaj mamy parametry zwierzakow
        /// </summary>
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;


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
