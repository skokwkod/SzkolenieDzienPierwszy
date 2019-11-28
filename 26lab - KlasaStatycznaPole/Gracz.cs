using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26lab___KlasaStatycznaPole
{
    class Gracz
    {
        private string nick;
        private int id;
        private static int nextId;

        public string Nick { get => nick; set => nick = value; }
        public int Id { get => id;}
        public static int NextId { get => nextId; set => nextId = value; }


        public Gracz()
        {
            Console.WriteLine("Domyslny Konstruktor Gracza");
            Nick = null;
            id = -10;   

        }

        public Gracz(string nick)
        {
            this.Nick = nick;
            id = ++NextId;
            
        }
    }
}
