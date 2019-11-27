using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18___ObslugaBledow
{
    class Program
    {
        static void Main(string[] args)
        {
            //tryaaa
            //{
            //    Console.WriteLine("Wprowadz dlugosc boku kwadratu");
            //    int dlBoku = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Pole kwadratu: {dlBoku*dlBoku}" );

            //    Console.WriteLine($"Obwod kwadratu: {4 * dlBoku}");

            //cos na probe

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Blednie wporadzona liczba \n {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Koniec programu"
            //        );

            //}

            //try
            //{
            //    int firstNumber = 1;
            //    int secondNumber = 0;

            //    Console.WriteLine(firstNumber /= secondNumber);
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("ArgumentException");

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("DivideByZeroException");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Exception");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}

            try
            {
                Console.WriteLine("Wprowadz dzielna, nastepnie dzielnik");
                //   decimal dzielna = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Wprowadz dzielnik");
                // decimal dzielnik = Convert.ToInt32(Console.ReadLine());
                decimal a=0;


                Console.WriteLine( Division(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),out a));

                Console.WriteLine(a);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();

        static decimal Division(decimal dzielna, decimal dzielnik)
        {
            if (dzielnik == 0)
                throw new DivideByZeroException();
           // a = 2;
            return dzielna / dzielnik;

        }

        static void Division(decimal dzielna, decimal dzielnik)
        {
            if (dzielnik == 0)
                throw new DivideByZeroException();
            a = 2;
            //return dzielna / dzielnik;

        }
    }
}
