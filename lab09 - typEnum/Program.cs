using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09___typEnum
{
    class Program
    {
        enum State1
        {
            Off,
            On,
            Unknown
        }
        enum State2
        {
            Off,
            On = 10,
            Unknown
        }
        static void Main(string[] args)
        {
            State2 state1 = State2.On;
            Console.WriteLine($"Stan - {state1}, {Convert.ToInt32(state1)}");
            Console.ReadKey();
        }
    }
}
