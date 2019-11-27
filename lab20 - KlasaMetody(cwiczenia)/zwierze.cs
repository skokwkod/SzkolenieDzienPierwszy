using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody_cwiczenia_
{
    class Zwierze
    {
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;



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
