using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Algorytm_Genetyczny
{
    class Operacje
    {
        public static double losujLiczbe(double min, double maks)
        {
            Thread.Sleep(1);
            Random r = new Random(System.DateTime.Now.Millisecond);
            return r.NextDouble() * (maks - min) + min;
        }

        public static void wstawDoTextBox(System.Windows.Forms.TextBox textBox, Populacja populacja)
        {
            textBox.Text = populacja.ToString();
        }
    }
}
