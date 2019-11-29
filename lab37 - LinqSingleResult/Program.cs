using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab37___LinqSingleResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 22, 33, 12, 21, 31, 43, 34, 54, 65, 76, 87, 10 };

            int firstNumber = numbers.First();
            Console.WriteLine($"firstNumber: {firstNumber}");
            int secondNumber = numbers.Skip(1).First();
            Console.WriteLine($"secondNumber: {secondNumber}");

            Console.ReadKey();
        }
    }
}
