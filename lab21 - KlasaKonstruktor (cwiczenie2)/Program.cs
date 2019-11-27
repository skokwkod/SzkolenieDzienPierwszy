using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasaKonstruktor__cwiczenie2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Wspolrzedne[] wspolrzedne = new Wspolrzedne[10];


            for (int indeks = 0; indeks < wspolrzedne.Length; indeks++)
            {
                wspolrzedne[indeks] = new Wspolrzedne(indeks,indeks*3+6);
                Console.WriteLine(wspolrzedne[indeks].x + " " +wspolrzedne[indeks].y);
            }



            Console.ReadKey();

        }
    }
}
