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
    public partial class AzurirajRasporedForma : Form
    {

        public AzurirajRasporedForma()

        {
            InitializeComponent();
            ki.vratiVezbace(cmbVezbac);
            ki.vratiDane(cmbDan);
            ki.vratiMesece(cmbMesec);
            ki.vratiSportove(cmbSport);
            ki.vratiTermine(cmbTermin);
        }

    KI ki = new KI();

    private void button1_Click(object sender, EventArgs e)
        {
            ki.VezbacURaspored(cmbSport, cmbTermin, cmbDan, cmbMesec, txtGodina, cmbVezbac);
        }
    }
}
