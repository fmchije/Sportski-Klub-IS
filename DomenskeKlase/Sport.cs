using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DomenskeKlase
{
    [Serializable]
    public class Sport : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private int sportID;
        public int SportID
        {
            get { return sportID; }
            set { sportID = value; }
        }
    
        private string nazivSporta;
        public string NazivSporta
{
            get { return nazivSporta; }
            set { nazivSporta = value; }
        }


        #endregion

        #region Konstruktori

        public Sport()
        {
        }

        public Sport(int sportID)
        {
            this.sportID = sportID;
        }

        public Sport(int sportID, string nazivSporta)
        {
            this.sportID = sportID;
            this.nazivSporta = nazivSporta;

        }

        #endregion

        #region IOpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
            return "Sport"; 
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
            return "SportID";
        }
        public string ImeKljucnogAtributa2()
        {
             return null; 
        }
        public string UslovZaNalazenjeSloga()
        {
             return "SportID = " + this.sportID.ToString(); 
        }

        public string UslovZaNalazenjeSlogova()
        {
             return null; 
        }

        public string VrednostiAtributaZaAzuriranje()
        {
           
                return " SportID = '" + this.sportID.ToString() + "' , NazivSporta = " + this.nazivSporta + "'";
            
        }
        public string VrednostiAtributaZaAzuriranje2()
        {
            return null;
        }

        public string VrednostiAtributaZaUbacivanje()
        {
            
                return "(" + this.sportID.ToString() + ", '" + this.nazivSporta + "')";
            
        }

        public List<OpstiDomenskiObjekat> vratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> sportovi = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Sport sport = new Sport();
                sport.NazivSporta = citac["NazivSporta"].ToString();
                sport.SportID = citac.GetInt32(0);
                sportovi.Add(sport);
            }
            return sportovi;
        }

        public List<OpstiDomenskiObjekat> vratiListu2(System.Data.OleDb.OleDbDataReader citac)
        {

            return null;
        }

        public OpstiDomenskiObjekat NapuniObjekat(DataRow red)
        {


            return null;
        }
        #endregion

        public override string ToString()
        {
            return nazivSporta;
        }

         public override bool Equals(object obj)
        {
            return base.Equals(obj);
            Sport s = obj as Sport;
        }

    }
}