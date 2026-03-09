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
    public partial class CenovnikForma : Form
    {
        KI ki = new KI();

        public CenovnikForma()
        {
            InitializeComponent();
            ki.vratiSportove(cmbSport);
            ki.vratiMesece(cmbMesec);
            
            ki.vratiTermine(cmbTermin);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ki.dodajCenovnik(cmbSport, cmbTermin, cmbMesec, txtGodina, txtCena);
        }

        private void cmbTermin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ki.VratiCeoCenovnik(dgvCenovnik);
        }
    }
}
