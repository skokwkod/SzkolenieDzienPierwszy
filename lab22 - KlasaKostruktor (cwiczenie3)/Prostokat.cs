using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasaKostruktor__cwiczenie3_
{
    class Prostokat
    {
        public Wspolrzedne lewyGornyRog = new Wspolrzedne();
        public Wspolrzedne lewyDolnyRog = new Wspolrzedne();
        public Wspolrzedne prawyGornyRog = new Wspolrzedne();
        public Wspolrzedne prawyDolnyRog = new Wspolrzedne();

        int wysokosc;
        int szerokosc;

        public Prostokat(Wspolrzedne lewyGornyRog, int wysokosc, int szerokosc)
        {
            this.lewyGornyRog = lewyGornyRog;
            this.wysokosc = wysokosc;
            this.szerokosc = szerokosc;

            this.prawyGornyRog = new Wspolrzedne(lewyGornyRog.x + szerokosc, lewyGornyRog.y);
            this.prawyDolnyRog = new Wspolrzedne(prawyGornyRog.x, prawyGornyRog.y - wysokosc);
            this.lewyDolnyRog = new Wspolrzedne(lewyGornyRog.x, lewyGornyRog.y - wysokosc);5
        }

        public int Obwod()
        {
            return (2 * wysokosc) + (2 * szerokosc);
        }
        public int Pole()
        {
            return wysokosc * szerokosc;
        }

        public void PokazWspolrzedne()
        {

            Console.WriteLine($"Lewy gorny rog: x:{lewyGornyRog.x} y:{lewyGornyRog.y}");
            Console.WriteLine($"Lewy dolny rog: x:{lewyDolnyRog.x} y:{lewyDolnyRog.y}");
            Console.WriteLine($"Prawy gorny rog: x:{prawyGornyRog.x} y:{prawyGornyRog.y}");
            Console.WriteLine($"Prawy dolny rog: x:{prawyDolnyRog.x} y:{prawyDolnyRog.y}");
        }
    }
}
