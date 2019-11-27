using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___typEnumSwitch
{
    class Program
    {
        enum State
        {
            Off,
            On,
            Unknown
        }
        static void Main(string[] args)
        {
            State state = State.On;

            switch (state)
            {
                case State.Off:
                    Console.WriteLine("Wylaczony");
                    break;
                case State.On:
                    Console.WriteLine("Wlaczony");
                    break;
                case State.Unknown:
                    Console.WriteLine("Nieznany");
                    break;
            }

            Console.ReadKey();
        }

    }
}
