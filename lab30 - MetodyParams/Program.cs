using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab30___MetodyParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Dodaj(5,4,3,2,4,56,6,7,4,3,4,5,6));

            Console.ReadKey();
        }

        class Math
        {
            public static int Dodaj(params int[] parametry)
            {
                int wynik = 0;

                for (int i = 0; i < parametry.Length; i++)
                {
                    wynik += parametry[i];
                }
                return wynik;
            }
        }
    }
}
