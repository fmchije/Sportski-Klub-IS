using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    using KontrolerInterfejsa;

    public partial class TrenerForma : Form
    {
        
        KI ki = new KI();

        public TrenerForma()
        {
            InitializeComponent();
            ki.vratiSportove(cmbSport);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ki.dodajTrenera(txtImePrezime, txtJMBG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ki.DodajSportUListu(cmbSport);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ki.ponistiListuSportova();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ki.vratiSveTrenere(dgvTreneri);
        }
    }
}
