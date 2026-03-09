using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace KontrolerInterfejsa
{
    using DomenskeKlase;
    using KorisnickiInterfejs;
    
    public class KI
    {
        static Komunikacija k = new Komunikacija();

        IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

        List<Sport> odabraniSportovi = new List<Sport>();



        public bool poveziSeSaServerom()
        {
            bool rezultat = k.poveziSeSaServerom();
            if (rezultat)
            {
                MessageBox.Show("Uspesna konekcija!");
                
                return true;
            }
            else
            {
                MessageBox.Show("Neuspesna konekcija!");
                return false;
            }
        }



        public KI()
        {
           
        }

        

        public void dodajVezbaca(TextBox txtImePrezime, TextBox txtJMBG)
        {
            int vezbacID = Convert.ToInt32(txtJMBG.Text);
            string imePrezimeVezbac = txtImePrezime.Text;
            Vezbac v = new Vezbac();
            v.ImePrezimeVezbac = imePrezimeVezbac;
            v.VezbacID = vezbacID;
            v.UkupnaUplata = 0;
            v.UkupnaVrednost = 0;
            try
            {
                if (k.dodajVezbaca(v) == 1)
                {
                    MessageBox.Show("Uspesno ste ubacili vezbaca!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void dodajCenovnik(ComboBox cmbsport, ComboBox cmbtermin, ComboBox cmbmesec, TextBox cmbgodina, TextBox txtcena)
        {
            Cenovnik c = new Cenovnik();
            Sport sport = cmbsport.SelectedItem as Sport;
            c.SportID = sport.SportID;
            Termin termin = cmbtermin.SelectedItem as Termin;
            c.TerminID = termin.TerminID;
            string datum = "#01/" + cmbmesec.SelectedItem + "/" + cmbgodina.Text +"#";
            
            //DateTime dt = DateTime.Parse(datum, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            c.DatumOd = datum;
            //DateTime dt2 = DateTime.Parse("01/01/2099", culture, System.Globalization.DateTimeStyles.AssumeLocal);
            c.DatumDo = "#01/01/2099#";
            c.Cena = Int32.Parse(txtcena.Text);
            try
            {
                if (k.dodajCenovnik(c) == 1)
                {
                    MessageBox.Show("Uspesno ste ubacili cenovnik!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void dodajTrenera(TextBox txtImePrezime, TextBox txtJMBG)
        {
            //punjenje objekta trener
            int jmbg = Convert.ToInt32(txtJMBG.Text);
            string imePrezimeTrener = txtImePrezime.Text;
            Trener t = new Trener();
            t.ImePrezimeTrener = imePrezimeTrener;
            t.Jmbg = jmbg;
            //punjenje liste sportova
            List<TrenerSport> tsovi = new List<TrenerSport>();
            foreach(Sport sport in odabraniSportovi)
            {
                TrenerSport ts = new TrenerSport();
                ts.SportID = sport.SportID;
                ts.Jmbg = t.Jmbg;
                tsovi.Add(ts);

            }
                try
            {
                if (k.dodajTrenera(t, tsovi) == 1)
                {
                    MessageBox.Show("Uspesno ste ubacili trenera!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void dodajUplatu(TextBox txtIznos, ComboBox cmbVezbac, ComboBox cmbDan, ComboBox cmbMesec, TextBox txtGodina)
        {
            Vezbac v;
            v = cmbVezbac.SelectedItem as Vezbac;
            //int iznos = Convert.ToInt32(txtIznos.Text);
            string dan = cmbDan.Text;
            string mesec = cmbMesec.Text;
            string godina = txtGodina.Text;
            Placanje u = new Placanje();
            u.Iznos = Convert.ToInt32(txtIznos.Text);
            u.VezbacID = v.VezbacID;
            v.UkupnaUplata = u.Iznos;
            string datum = "#" + dan + "/" + mesec + "/" + godina + "#";
            //DateTime dt = DateTime.Parse(datum, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            u.Datum = datum;
           // Uplata.datum= DateTime.Now.ToLongTimeString()


            try
            {
                if (k.dodajUplatu(u,v) == 1)
                {
                    MessageBox.Show("Uspesno ste ubacili uplatu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public List<Trener> vratiTrenere(ComboBox cmbsport, ComboBox cmbtermin, ComboBox cmbDan, ComboBox cmbMesec, TextBox txtGodina)
        {
            Raspored r = new Raspored();
            Sport sport = cmbsport.SelectedItem as Sport;
            r.SportID = sport.SportID;

            Termin t = cmbtermin.SelectedItem as Termin;
            r.TerminID = t.TerminID;
            string datum = "#" + cmbDan.SelectedItem + "/" + cmbMesec.SelectedItem + "/" + txtGodina.Text + "#";

            Console.WriteLine(datum);
            //MessageBox.Show(datum);
           // DateTime dt = DateTime.Parse(datum, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            r.Datum = datum;
            List<OpstiDomenskiObjekat> treneriOpsta = k.vratiTrenere(r);
            List<Trener> treneriTabela =treneriOpsta.OfType<Trener>().ToList<Trener>();
            return treneriTabela;

        }

        public void vratiSveTrenere(DataGridView treneri)
        {
            List<OpstiDomenskiObjekat> treneriOpsta = k.vratiSveTrenere();
            List<Trener> treneriTabela = treneriOpsta.OfType<Trener>().ToList<Trener>();
            treneri.DataSource = treneriTabela;
        }

        public void VratiCeoCenovnik(DataGridView cenovnik)
        {
            List<OpstiDomenskiObjekat> cenovnikOpsta = k.VratiCeoCenovnik();
            List<Cenovnik> cenovnikTabela = cenovnikOpsta.OfType<Cenovnik>().ToList<Cenovnik>();
            cenovnik.DataSource = cenovnikTabela;
        }


        public void VezbacURaspored(ComboBox cmbsport, ComboBox cmbtermin, ComboBox cmbDan, ComboBox cmbMesec, TextBox txtGodina, ComboBox cmbvezbac)
        {
            Raspored r = new Raspored();
            Sport sport = cmbsport.SelectedItem as Sport;
            r.SportID = sport.SportID;
            Termin termin = cmbtermin.SelectedItem as Termin;
            r.TerminID = termin.TerminID;
            string datum = "#"+ cmbDan.SelectedItem + "/" + cmbMesec.SelectedItem + "/" + txtGodina.Text + "#";
            //DateTime dt = DateTime.Parse(datum, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            r.Datum = datum;
            Vezbac vezbac = cmbvezbac.SelectedItem as Vezbac;
            r.VezbacID = vezbac.VezbacID;
            r.Jmbg = 8;
            try
            {
                if (k.vezbacURaspored(r) == 1)
                {
                    MessageBox.Show("Uspesno ste ubacili vezbaca!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void vratiSportove(ComboBox sportovi)
        {
            sportovi.DataSource = k.vratiSportove();
        }

        public void vratiTermine(ComboBox termini)
        {
            termini.DataSource = k.vratiTermine();
        }

        public void vratiDane(ComboBox cmbdani)
        {

            List<String> dani = new List<String>() { "01", "02","03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };

         //   List<Int32> dani = Enumerable.Range(1, 31).ToList();

            cmbdani.DataSource = dani;
        }


        public void vratiMesece(ComboBox mesec)
        {
            List<String> meseci = new List<String>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            mesec.DataSource = meseci;
        }

        public void vratiVezbace(ComboBox vezbaci)
        {
            vezbaci.DataSource = k.vratiVezbace();
        }

        public void vratiVezbace2(DataGridView vezbaci)
        {
            List<OpstiDomenskiObjekat> treneriOpsta = k.vratiVezbace();
            List<Vezbac> treneriTabela = treneriOpsta.OfType<Vezbac>().ToList<Vezbac>();
            vezbaci.DataSource = treneriTabela;
        }

        public void DodajSportUListu(ComboBox sportovi)
        {
            Sport sport = sportovi.SelectedItem as Sport;

            odabraniSportovi.Add(sport);
              
        }
        public void ponistiListuSportova()
        {
            odabraniSportovi.Clear();
        }

      public void vratiDug(ComboBox cmbVezbac,TextBox txtDug)
        {
            Vezbac v = cmbVezbac.SelectedItem as Vezbac;
            int dug = v.UkupnaVrednost - v.UkupnaUplata;
            txtDug.Text = dug.ToString();

            
        }
        
    }
}
