using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab28___Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd pojazd = new Pojazd();
            pojazd.Marka = "BMW";
            pojazd.MaksymalnaPredkosc = 190;
            pojazd.AktualnaPredkosc = 120;

            Console.WriteLine($"Marka: {pojazd.Marka}\nRok Produkcji: {pojazd.RokProdukcji}\nMaksymalna Predkosc:" +
    $"{pojazd.MaksymalnaPredkosc}\nAktualna Predkosc {pojazd.AktualnaPredkosc}");


            pojazd.Przyspiesz(45);


            Console.WriteLine($"Marka: {pojazd.Marka}\nRok Produkcji: {pojazd.RokProdukcji}\nMaksymalna Predkosc:" +
    $"{pojazd.MaksymalnaPredkosc}\nAktualna Predkosc {pojazd.AktualnaPredkosc}");


            Console.ReadKey();
        }
    }
}
