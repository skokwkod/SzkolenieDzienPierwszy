using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___MetodyRozszerzajace_Cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date;
            date = DateTime.Parse("02.07.1990");

            Console.WriteLine(date.DaysOnEarth());


            Console.ReadKey();

        }
    }
}
