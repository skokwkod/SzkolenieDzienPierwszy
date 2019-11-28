using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___MetodyRozszerzajace
{
    public static class KlasaRozszerzajaca
    {
        public static int ZliczSlowa(this String tekst)
        {
            int iloscSlow = 0;
            int indeks = 0;

            while (indeks< tekst.Length)
            {
                while (indeks<tekst.Length && !char.IsWhiteSpace(tekst[indeks]) && char.IsWhiteSpace(tekst[indeks]))
                
                    indeks++;
                    iloscSlow++;
                    while (indeks<tekst.Length && char.IsWhiteSpace(tekst[indeks]))
                    {
                        indeks++;
                    }
                       
                
            }
            return iloscSlow;
        }
    }
}
