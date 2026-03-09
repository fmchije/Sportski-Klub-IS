using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DomenskeKlase
{
    [Serializable]
    public class Placanje : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private int vezbacID;
        public int VezbacID
        {
            get { return vezbacID; }
            set { vezbacID = value; }
        }

        private string mesecGodina;
        public string MesecGodina
        {
            get { return mesecGodina; }
            set { mesecGodina = value; }
        }
        private int iznos;
        public int Iznos
        { 
            get { return iznos; }
            set { iznos = value; }
        }
        private string datum;
            public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        #endregion

        #region Konstruktori

        public Placanje()
        {
        }

        public Placanje(int iznos)
        {
            this.iznos = iznos;
        }

        public Placanje(int iznos, string mesecGodina, int vezbacID)
        {
            this.iznos = iznos;
            this.mesecGodina = mesecGodina;
            this.vezbacID = vezbacID;

        }

        #endregion

        #region IOpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
            return "Placanje"; 
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
            
                return " VezbacID = '" + this.vezbacID.ToString() + "' , MesecGOdina = " + this.mesecGodina + "' , Iznos = " + this.iznos + "'";
            
        }
        public string VrednostiAtributaZaAzuriranje2()
        {
             return null; 
        }

        public string VrednostiAtributaZaUbacivanje()
        {
            
                return "("+ this.datum + "," + this.VezbacID.ToString() + ", " + this.Iznos.ToString() + ")";
            
        }

        public List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac)
        {
            
            return null;
        }

        public List<OpstiDomenskiObjekat> vratiListu2(OleDbDataReader citac)
        {

            return null;
        }

        public OpstiDomenskiObjekat NapuniObjekat(DataRow red)
        {


            return null;
        }
        #endregion
    }
}