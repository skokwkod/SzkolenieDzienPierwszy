using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15___ListaString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Adam");
            lista.Add("Piotr");
            lista.Add("Adam");
            lista.Add("Krzysztof");
            lista.Add("Michal");
            lista.Add("Darek");
            lista.Add("Pawel");

            Console.WriteLine($"Lista posiada {lista.Count}");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(1);
            Console.WriteLine($"Lista posiada {lista.Count}\n\n");

            string zmienna = lista[0];

            Console.WriteLine(zmienna);
            Console.WriteLine($"Lista posiada {lista.Count} usuwanie...");
            lista.Remove(zmienna);

            Console.WriteLine($"Lista posiada {lista.Count}\n\n");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
