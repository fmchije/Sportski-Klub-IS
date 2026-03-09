using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KontrolerInterfejsa;
namespace KorisnickiInterfejs
{
    public partial class RasporedForma : Form
    {
        KI ki = new KI();

        public RasporedForma()
        {
            InitializeComponent();
            ki.vratiSportove(cmbSport);
            ki.vratiTermine(cmbTermin);
            ki.vratiDane(cmbDan);
            ki.vratiMesece(cmbMesec);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvRaspored.DataSource = ki.vratiTrenere(cmbSport, cmbTermin, cmbDan, cmbMesec, txtGodina );
        }
    }
}
