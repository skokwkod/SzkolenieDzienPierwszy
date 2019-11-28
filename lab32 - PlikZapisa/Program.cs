using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32___PlikZapisa
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"D:\test.txt";


            if (File.Exists(path))
            {
                Console.WriteLine("Plik istnieje");
            }

            //string tekst = "lubie placki\n";
            //File.WriteAllText(path, tekst);
            //File.AppendAllText(path, tekst);

            List<string> lista = new List<string>
            {
                "linia 1",
                "linia 2",
                "linia 3"
            };

            File.WriteAllLines(path,lista);

            Console.ReadKey();

        }
    }
}
