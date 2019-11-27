using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //    if (1==2)
            //    {
            //        Console.WriteLine("Yeah");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Buuu");
            //    }

            double waga, wzrost, bmi;

            Console.WriteLine("podaj wagę");
            waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj wzrost w metrach");
            wzrost = Convert.ToDouble(Console.ReadLine());

            // bmi = waga / Math.Pow(wzrost, 2);
            bmi = 17;
            Console.WriteLine(Math.Round(bmi, 2));

            if (bmi < 16)
            {
                Console.WriteLine("wygłodzenie");
            }else if(bmi>= 16 && bmi < 17)
            {
                Console.WriteLine("wychudzenie");
            }
            else if (bmi >= 17 && bmi < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Wartosc prawidlowa");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("nadwaga");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("I stopien otylosci");
            }
            else if (bmi >= 35 && bmi < 40)
            {
                Console.WriteLine("II stopień otyłości");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("Otylosc skrajna");
            }

            //            mniej niż 16 - wygłodzenie
            //16 - 16.99 - wychudzenie
            //17 - 18.49 - niedowaga
            //18.5 - 24.99 - wartość prawidłowa
            //25 - 29.99 - nadwaga
            //30 - 34.99 - I stopień otyłości
            //35 - 39.99 - II stopień otyłości
            //powyżej 40 - otyłość skrajna

            Console.ReadKey();

        }
    }
}
