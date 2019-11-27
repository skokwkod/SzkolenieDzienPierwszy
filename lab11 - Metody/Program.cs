using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11___Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OpiszDlugoscWyrazu(DajInicjaly("Michal", "Dabek")));

            WypiszLiczby(5, 44444,1);
            WypiszLiczby(5.0, 44444, 1);
            Console.ReadKey();
        }
        static string DajInicjaly(string imie, string nazwisko)
        {
            return imie[0] +"."+ nazwisko[0]+".";
        }

        static int OpiszDlugoscWyrazu(string wyraz)
        {
            return wyraz.Length;
        }

        static void WypiszLiczby(int liczba1, int liczba2)
        {
            Console.WriteLine($"Liczba1: {liczba1}, Liczba2: {liczba2}");
        }
        static void WypiszLiczby(int liczba1, int liczba2, int liczba3)
        {
            Console.WriteLine($"Liczba1: {liczba1}, Liczba2: {liczba2}, Liczba3: {liczba3}");
        }
        static void WypiszLiczby(double liczba1, double liczba2, double liczba3)
        {
            Console.WriteLine($"Liczba1 double: {liczba1}, Liczba2: {liczba2}, Liczba3: {liczba3}");
        }


    }
}
