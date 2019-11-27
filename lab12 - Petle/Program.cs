using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12___Petle
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Podaj liczbę");
            //int liczba = Convert.ToInt32(Console.ReadLine());
            //int a=0;
            //for (int i = 2; i <= liczba-1; i++)
            //{
            //    if (liczba % i == 0)
            //    {
            //        a++;
            //        break;
            //    }
            //}
            //if (a == 0)
            //    Console.WriteLine($"Podana liczba {liczba} jest liczba pierwsza");
            //else
            //    Console.WriteLine($"Podana liczba {liczba} nie jest liczba pierwsza");

            //List<int> lista = new List<int>()
            //{
            //    1,2,3,4,7,8,11

            //};

            //for (int i = 0; i < lista.Count(); i++)
            //{
            //    Console.WriteLine($"{i} - {lista[i]}");
            //}

            //Console.WriteLine("Podaj tekst");
            //string tekst = Convert.ToString(Console.ReadLine());
            //int iloscLiter = 0;
            //int iloscCyfr = 0;
            //int iloscSpacji = 0;


            //foreach (var item in tekst)
            //{
            //    if(Char.IsLetter(item)) iloscLiter++;
            //    if (Char.IsWhiteSpace(item)) iloscSpacji++;
            //    if (Char.IsNumber(item)) iloscCyfr++;

            //}

            //Console.WriteLine($"tekst {tekst} zawiera: \n\n");
            //Console.WriteLine($"{iloscLiter} Liter ");
            //Console.WriteLine($"{iloscCyfr} Cyfr ");
            //Console.WriteLine($"{iloscSpacji} Bialych znakow ");

            //int licznik = 0;
            //while (licznik<10)
            //{
            //    Console.WriteLine(licznik++);
            //}

            int licznik = 20;
            do
            {
                Console.WriteLine(licznik++);
            } while (licznik<10);


            Console.ReadKey();
        }


    }
}
