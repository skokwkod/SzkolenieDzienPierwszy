using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33___PlikOdczyt
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = $@"D:\test.txt";

            if (File.Exists(path))
            {
                Console.WriteLine( File.ReadAllText(path));

                Console.WriteLine("==================================");

                string[] lines = File.ReadAllLines(path);

                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                }


            }else
            Console.WriteLine("Plik nie istnieje");

            Console.ReadKey();
        }
    }
}
