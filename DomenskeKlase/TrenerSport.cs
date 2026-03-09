using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace DomenskeKlase
{   [Serializable]
    public class TrenerSport : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private int jmbg;
        public int Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        private int sportID;
        public int SportID
        {
            get { return sportID; }
            set { sportID = value; }
        }
       

        #endregion

        #region Konstruktori

        public TrenerSport()
        {
        }

        public TrenerSport(int jmbg)
        {
            this.jmbg = jmbg;
        }

        public TrenerSport(int jmbg, int sportID)
        {
            this.jmbg = jmbg;
            this.sportID = sportID;

        }

        #endregion

        #region IOpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
            return "TrenerSport"; 
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
           return "JMBG"; 
        }

        public string ImeKljucnogAtributa2()
        {
           return null; 
        }

        public string UslovZaNalazenjeSloga()
        {
             return "JMBG = " + this.jmbg.ToString(); 
        }

        public string UslovZaNalazenjeSlogova()
        {
            return null; 
        }

        public string VrednostiAtributaZaAzuriranje()
        {
            
                return " JMBG = '" + this.jmbg.ToString() + "' , SportID = " + this.sportID.ToString() + "'";
           
        }

        public string VrednostiAtributaZaAzuriranje2()
        {
             return null; 
        }

        public string VrednostiAtributaZaUbacivanje()
        {
            
                return "(" + this.jmbg.ToString() + ", '" + this.sportID.ToString() + "')";
            
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