using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_InstrukcjaIfElse_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min, max;

            Console.WriteLine("Podaj 3 wartości: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            min = a;
            max = a;
            if (min > b)
            {
                min = b;
            }
            else if(max < b)
            {
                max = b;
            }
            if (min > c)
            {
                min = c;
            }
            else if(max<c)
            {
                max = c;
            }

            Console.WriteLine($"min: {min}, max: {max}");

            Console.ReadKey();
        }
    }
}
