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

        //System.Windows.Forms.ListBox
        public static void sprawdzBlokadeList(System.Windows.Forms.ListBox lista1, System.Windows.Forms.NumericUpDown standard)
        {
            if (lista1.SelectedIndex == 0)
            {
                standard.Enabled = false;
            } else if (lista1.SelectedIndex == 1)
            {
                standard.Enabled = true;
            }
        }

        public static void sortujPopulacje(Populacja populacja, System.Windows.Forms.ListBox funkcjaOceny, System.Windows.Forms.NumericUpDown nudStandard)
        {
            double standard = Decimal.ToDouble(nudStandard.Value);
            bool czyRestrykcyjnie = (funkcjaOceny.SelectedIndex == 0) ? true : false;
            populacja.sortuj(czyRestrykcyjnie, standard);
        }
    }
}
