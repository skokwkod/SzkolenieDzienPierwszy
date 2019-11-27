using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13___Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tablica1;

            //tablica1 = new int[] { 1, 4, 5, 2, 34 };
            //Console.WriteLine(tablica1.Length);
            //Console.WriteLine($"Wartosc elementu o indexie nr 2: {tablica1[2]}");

            //tablica1[2] = 1234;
            //Console.WriteLine($"Wartosc elementu o indexie nr 2: {tablica1[2]}");

            // int[] tablica2 = new int[] { 2, 3, 1, 54, 5, 3, 1 };

            WypiszTablice(new int[] { 1, 2, 3, 4, 1, 33});

            Console.ReadKey();
        }


        private static void WypiszTablice(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);
        }
    }
}
