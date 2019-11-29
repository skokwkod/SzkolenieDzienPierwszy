#define reverse
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab36___LinqNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 22, 33, 12, 21, 31, 43, 34, 54, 65, 76, 87, 10 };

#if (take)
            IEnumerable<int> modifiedNumbers = numbers.Take(3);

#elif (skip)
            IEnumerable<int> modifiedNumbers = numbers.Skip(3);
#elif (reverse)
            IEnumerable<int> modifiedNumbers = numbers.Reverse();


#endif
            foreach (int item in modifiedNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
