﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numer1 = 1;
            int numer2 = numer1;

            Console.WriteLine($"{numer1}  {numer2}");

            int numer3 = 300;
            byte numer4 = (byte)numer3;
            Console.WriteLine($"{numer3}  {numer4}");

            string numer5 = "123";
            byte numer6 = Convert.ToByte(numer5);
            Console.WriteLine($"{numer5}  {numer6}");



            Console.ReadKey();
        }
    }
}
