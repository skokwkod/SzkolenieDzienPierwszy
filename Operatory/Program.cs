using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"dodawanie: {2+2}");
            //Console.WriteLine($"mnozenie: {5 * 2}");
            //Console.WriteLine($"dzielenie: {5.0 / 2}");
            //Console.WriteLine($"potegowanie: {Math.Pow(2,3)}");
            //Console.WriteLine($"reszta z dzielenia: {5%3}");

            //int a = 5;
            //int b = 5;

            //Console.WriteLine(a++);
            //Console.WriteLine(++b);

            //int d = 6;
            //int e = 4;

            //Console.WriteLine(d += ++e);
            //Console.WriteLine(d += ++e);

            //Console.Clear();

            //double waga, wzrost, bmi;

            //Console.WriteLine("podaj wagę");
            //waga = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("podaj wzrost w metrach");
            //wzrost =Convert.ToDouble(Console.ReadLine());

            //bmi = waga / Math.Pow(wzrost,2);
            //Console.WriteLine(bmi.ToString("0.00"));
            //Console.WriteLine(bmi.ToString("0.000"));
            //Console.WriteLine(Math.Round(bmi,2));

            //Console.WriteLine("Podaj dlugosc boku kwadratu");
            //double ak =Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine($"Pole kwadratu: {Math.Pow(ak,2)}");


            decimal a, b;
            Console.WriteLine("Podaj a");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Suma: {a+b}");
            Console.WriteLine($"Roznica: {a - b}");
            Console.WriteLine($"Iloczyn: {a * b}");
            Console.WriteLine($"Iloraz: {a / b}");


            Console.ReadKey();
        }
    }
}
