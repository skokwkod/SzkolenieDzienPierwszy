using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14___TabliceDwuwymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomTab();

            Console.ReadKey();
        }

        private static void RandomTab()
        {
            int min_i = 0;
            int min_j = 0;
            int max_i = 0;
            int max_j = 0;


            Random random = new Random();

            int[,] tab = new int[10, 10];
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            for (int i = 0; i < 10; i++)
            {
                
                Console.Write(" | ");
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = random.Next(200);
                    if (tab[i, j] < tab[min_i, min_j])
                    {
                        min_i = i;
                        min_j = j;
                    }
                    if (tab[i, j] > tab[max_i, max_j])
                    {
                        max_i = i;
                        max_j = j;
                    }



                    Console.Write(Convert.ToString(tab[i, j]).PadRight(3)+" | " );
                }
                Console.Write(" | \n");
            }

            Console.WriteLine($"Najmniejsza wartość = {tab[min_i,min_j]} pozycja [{min_i},{min_j}] \n" +
                $", najwieksza wartosc = {tab[max_i, max_j]}pozycja [{max_i},{max_j}]");
        }
    }
}
