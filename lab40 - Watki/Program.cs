using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab40___Watki
{
    class Program
    {
        static void Main(string[] args)
        {
            Robotnik robotnik1 = new Robotnik();
            Robotnik robotnik2 = new Robotnik();

            Thread T1 = new Thread(robotnik1.wypisz1);
            Thread T2 = new Thread(robotnik2.wypisz2);

            T1.Start();
            T2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wypisz 3");
                Console.ResetColor();
            }
        //    robotnik2.wypisz1();


            Console.ReadKey();
        }

        class Robotnik
        {
            public void wypisz1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wypisz 1");
                    Console.ResetColor();
                }
            }
            public void wypisz2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wypisz 2");
                    Console.ResetColor();
                }
            }

        }
    }
}
