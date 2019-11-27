using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19__Klasa__Cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {

            Zwierze pies = new Zwierze();
            Zwierze pajak = new Zwierze();
            Zwierze mucha = new Zwierze();


            pies.nazwa = "Pies";
            pies.iloscNog = 4;
            pies.iloscOczu = 2;

            pajak.nazwa = "Pajak";
            pajak.iloscNog = 8;
            pajak.iloscOczu = 8;

            mucha.nazwa = "Mucha";
            mucha.iloscNog = 6;
            mucha.iloscOczu = 2;


            Console.WriteLine($"Nazwa: {pies.nazwa}, Ilosc Nog: {pies.iloscNog}, Ilosc Oczu: {pies.iloscOczu}\n");

            Console.WriteLine($"Nazwa: {pajak.nazwa}, Ilosc Nog: {pajak.iloscNog}, Ilosc Oczu: {pajak.iloscOczu}\n");

            Console.WriteLine($"Nazwa: {mucha.nazwa}, Ilosc Nog: {mucha.iloscNog}, Ilosc Oczu: {mucha.iloscOczu}\n");



            Console.ReadKey();


        }
    }
}
