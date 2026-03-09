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

    public partial class PlacanjeForma : Form
    {
        KI ki = new KI();

        public PlacanjeForma()
        {
            InitializeComponent();
            ki.vratiVezbace(cmbVezbac);
            ki.vratiDane(cmbDan);
            ki.vratiMesece(cmbMesec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ki.dodajUplatu(txtIznos, cmbVezbac, cmbDan, cmbMesec, txtGodina);
            
        }
    }
}
