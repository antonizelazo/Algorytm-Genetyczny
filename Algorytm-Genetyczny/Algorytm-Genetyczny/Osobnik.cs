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
                this.a = Operacje.losujLiczbe(1, 9);
                this.b = Operacje.losujLiczbe(1, 9);
                this.c = Operacje.losujLiczbe(1, 9);
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
