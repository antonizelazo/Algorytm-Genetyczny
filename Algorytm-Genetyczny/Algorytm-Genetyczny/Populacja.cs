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

        public void obliczRank(double standard)
        {
            int n = populacja.Length;
            for (int i = 0; i < n; i++)
            {
                populacja[i].obliczRanking(i + 1, n, standard);
            }
        }

        public void sortuj(bool czyRestrykcyjnie, double standard)
        {
            int n = populacja.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (populacja[i].dajPole() > populacja[i + 1].dajPole())
                    {
                        Osobnik tmp = populacja[i];
                        populacja[i] = populacja[i + 1];
                        populacja[i + 1] = tmp;
                    }
                }
                n--;
            } while (n > 1);

            if (!czyRestrykcyjnie)
            {
                // do zrobienie
                // jest obliczanie rankingu zrobione
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
