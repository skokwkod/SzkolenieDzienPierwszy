using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17___ParametryMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "Kubus";
            Console.WriteLine(imie);
            Upper(imie);
            Console.WriteLine(imie);
            Lower(ref imie);
            Console.WriteLine(imie);

            int length = 333;
            GetWordLength(imie, out length);


            Console.WriteLine(length);




            Console.ReadKey();


        }

        static void Upper(string word)
        {
            word = word.ToUpper();
            Console.WriteLine(word);
        }

        static void Lower(ref string word)
        {
            word = word.ToLower();
            Console.WriteLine(word);
        }

        static void GetWordLength(string word, out int length)
        {
            length = word.Length;
        }
    }
}
