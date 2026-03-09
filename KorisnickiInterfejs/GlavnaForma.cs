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
    public partial class GlavnaForma : Form
    {
        Komunikacija k;
        KI ki = new KI();

        public GlavnaForma()
        {
            InitializeComponent();
            poveziSeSaServerom();
            
        }


        private void poveziSeSaServerom()
        {
            k = new Komunikacija();
            if (!ki.poveziSeSaServerom())
            {
                this.Close();
            }
        }

        private void vezbacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VezbacForma forma = new VezbacForma();
            forma.Show();
            
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrenerForma forma = new TrenerForma();
            forma.Show();
            
        }

        private void placanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlacanjeForma forma = new PlacanjeForma();
            forma.Show();
            
        }

        private void cenovnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenovnikForma forma = new CenovnikForma();
            forma.Show();
            
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            poveziSeSaServerom();
            this.Text = k.BrojKlijenta.ToString();
        }

        private void rasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasporedForma forma = new RasporedForma();
            forma.Show();
            
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SportForma forma = new SportForma();
           // forma.Show();
            this.Hide();
        }

        private void azurirajRasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzurirajRasporedForma forma = new AzurirajRasporedForma();
            forma.Show();
        }
    }
}
