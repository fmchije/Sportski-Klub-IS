using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DomenskeKlase
{
    [Serializable]
    public class Vezbac : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private int vezbacID;
        public int VezbacID
        {
            get { return vezbacID; }
            set { vezbacID = value; }
        }

        private string imePrezimeVezbac;
        public string ImePrezimeVezbac
        {
            get { return imePrezimeVezbac; }
            set { imePrezimeVezbac = value; }
        }

        private int ukupnaUplata;
        public int UkupnaUplata
        {
            get { return ukupnaUplata; }
            set { ukupnaUplata = value; }
        }

        private int ukupnaVrednost;
        public int UkupnaVrednost
        {
            get { return ukupnaVrednost; }
            set { ukupnaVrednost = value; }
        }

       


        #endregion

        #region Konstruktori

        public Vezbac()
        {
        }

        public Vezbac(int vezbacID)
        {
            this.vezbacID = vezbacID;
        }

        public Vezbac(int vezbacID, string imePrezimeVezbac, int ukupnaUplata)
        {
            this.vezbacID = vezbacID;
            this.imePrezimeVezbac = imePrezimeVezbac;
            this.ukupnaUplata = ukupnaUplata;
        }

        #endregion

        #region IOpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
            return "Vezbac"; 
        }

        public string ImeObjektaZaJoin()
        {
             return null; 
        }

        public string ImeObjektaZaJoin2()
        {
             return null; 
        }

        public string ImeJoinAtributa()
        {
            return null; 
        }

        public string ImeJoinAtributa2()
        {
             return null;

        }

        public string ImeKljucnogAtributa()
        {
             return "VezbacID"; 
        }

        public string ImeKljucnogAtributa2()
        {
             return null; 
        }

        public string UslovZaNalazenjeSloga()
        {
             return "VezbacID = " + this.vezbacID.ToString(); 
        }

        public string UslovZaNalazenjeSlogova()
        {
             return null; 
        }

        public string VrednostiAtributaZaAzuriranje()
        {

            
            return "UkupnaUplata =  UkupnaUplata +" + this.ukupnaUplata;
        }

        public string VrednostiAtributaZaAzuriranje2()
        {

            return "UkupnaVrednost =  UkupnaVrednost +" + this.ukupnaVrednost;

        }

        public string VrednostiAtributaZaUbacivanje()
        {
           
                return "(" + this.vezbacID.ToString() + ", '" + this.imePrezimeVezbac + "', " + this.ukupnaUplata + "," + this.ukupnaVrednost + ")";
            
        }

        public List<OpstiDomenskiObjekat> vratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> vezbaci = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Vezbac vezbac = new Vezbac();
                vezbac.imePrezimeVezbac = citac["ImePrezimeVezbac"].ToString();
                vezbac.vezbacID = citac.GetInt32(0);
                vezbac.ukupnaUplata = Convert.ToInt32(citac["UkupnaUplata"].ToString());
                vezbac.ukupnaVrednost = Convert.ToInt32(citac["UkupnaVrednost"].ToString());
                vezbaci.Add(vezbac);
            }
            return vezbaci;
        }

        public List<OpstiDomenskiObjekat> vratiListu2(System.Data.OleDb.OleDbDataReader citac)
        {

            return null;
        }

        public OpstiDomenskiObjekat NapuniObjekat(DataRow red)
        {


            return null;
        }

        public override string ToString()
        {
            return imePrezimeVezbac;
        }

        #endregion
    }
}