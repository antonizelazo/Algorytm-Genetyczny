using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Genetyczny
{
    class Osobnik
    {
        private double a, b, c, pole;

        public Osobnik()
        {
            do
            {
                this.a = Operacje.losujLiczbe(1, 9);
                this.b = Operacje.losujLiczbe(1, 9);
                this.c = Operacje.losujLiczbe(1, 9);
            } while (czyRamionaWZlejProporcji());
            this.pole = obliczPole();
        }

        private double obliczPole()
        {
            double p = (a + b + c) / 2;
            double liczba = p * (p - a) * (p - b) * (p - c);
            return Math.Sqrt(liczba);
        }

        private bool czyRamionaWZlejProporcji()
        {
            if (this.a + this.b > this.c && this.b + this.c > this.a && this.c + this.a > this.b)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            string tekst = "";
            tekst += String.Format("{0:N2}", this.a) + " | ";
            tekst += String.Format("{0:N2}", this.b) + " | ";
            tekst += String.Format("{0:N2}", this.c);
            return tekst;
        }
    }
}
