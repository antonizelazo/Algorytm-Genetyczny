using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytm_Genetyczny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLosujPopulacje_Click(object sender, EventArgs e)
        {
            Populacja populacja = new Populacja(Decimal.ToInt32(numericUpDownIleOsobnikow.Value));
            Operacje.wstawDoTextBox(textBoxWidokOsobnikow, populacja);
        }
    }
}
