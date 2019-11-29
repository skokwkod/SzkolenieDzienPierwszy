#define multiAll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_35___LinqStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Michal", "Adam", "Piotr", "Tomasz", "Jan", "Dariusz", "Marek", "Lukasz" };

#if (Filtr1)
            //baaaad
            // IEnumerable<string> modifiedNames = System.Linq.Enumerable.Where(names, n => n.Length >= 5);


            IEnumerable<string> modifiedNames = names.Where(n => n.Length >= 5);

#elif (Filtr2)

            //  IEnumerable<string> modifiedNames = names.Where(x => x.Contains("M"));

            IEnumerable<string> modifiedNames = from n in names where n.Contains("M") select n;
#elif (sort)
            IEnumerable<string> modifiedNames = names.OrderBy(n => n.Length);

#elif (modified)
            IEnumerable<int> modifiedNames = names.Select(n => n.Length);
#elif (multi)
            IEnumerable<string> filterNames = names.Where(n => n.Contains("a"));
            IEnumerable<string> orderNames = filterNames.OrderBy(n => n);
            IEnumerable<string> modifiedNames = orderNames.Select(n => n.ToUpper());

#elif (multiAll)
            IEnumerable<string> modifiedNames = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n)
                .Select(n => n.ToUpper());

#endif
            foreach (var item in modifiedNames)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
