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
    public partial class VezbacForma : Form
    {
        KI ki = new KI();

        public VezbacForma()
        {
            InitializeComponent();
            ki.vratiVezbace(cmbVezbac);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ki.dodajVezbaca(txtImePrezime, txtJMBG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             ki.vratiVezbace2(dgvVezbaci);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ki.vratiDug(cmbVezbac, txtDug);
        }
    }
}
