using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Genetyczny
{
    class Populacja
    {
        private int generacja;
        Osobnik[] populacja;

        public Populacja()
        {
            int ileOsobnikow = 32;
            this.populacja = new Osobnik[ileOsobnikow];
            for (int i = 0; i < 32; i++)
            {
                populacja[i] = new Osobnik();
            }
        }
        public Populacja(int ileOsobnikow)
        {
            this.populacja = new Osobnik[ileOsobnikow];
            for (int i = 0; i < ileOsobnikow; i++)
            {
                populacja[i] = new Osobnik();
            }
        }

        public int Length()
        {
            return this.populacja.Length;
        }
        public override string ToString()
        {
            string tekst = "1 | " + populacja[0].ToString();
            for (int i = 1; i < populacja.Length ; i++)
            {
                tekst += "\r\n" + (i + 1).ToString() + " | " + populacja[i].ToString();
            }
            return tekst;
        }
    }
}
