using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DomenskeKlase
{
    using System.Data.OleDb;
    [Serializable]
    public class Cenovnik : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private int sportID;
        public int SportID
        {
            get { return sportID; }
            set { sportID = value; }
        }


        private string terminID;
        public string TerminID
        {
            get { return terminID; }
            set { terminID = value; }
        }

        private string datumOd;
        public string DatumOd
        {
            get { return datumOd; }
            set { datumOd = value; }
        }

        private string datumDo;
        public string DatumDo
        {
            get { return datumDo; }
            set { datumDo = value; }
        }

        private int cena;
        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        #endregion

        #region Konstruktori

        public Cenovnik()
        {
        }

        

        public Cenovnik(int sportID, string termin, string datumOd, string datumDo, int cena)
        {
            this.sportID = sportID;
            this.terminID = termin;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.cena = cena;
        }

        #endregion

        #region OpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
            return "Cenovnik"; 
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
             return "DatumDo = " + this.DatumDo.ToString() + " AND SportID=" + this.SportID.ToString() + " AND TerminID='" + this.terminID + "'"; 
        }

        public string UslovZaNalazenjeSlogova()
        {
             return null; 
        }

        public string VrednostiAtributaZaAzuriranje()
        {
            
                return "DatumDo = " + this.datumOd ;
            
        }

        public string VrednostiAtributaZaAzuriranje2()
        {
            return null; 
        }

        public string VrednostiAtributaZaUbacivanje()
        {
            
                return "(" + this.sportID.ToString() + ", '" + this.terminID + "', " + this.datumOd + ", " + this.datumDo + ", " + this.cena +  ")";
            
        }

        public List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> cenovnici = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Cenovnik cenovnik = new Cenovnik();
                cenovnik.TerminID = citac["TerminID"].ToString();
                cenovnik.SportID = citac.GetInt32(0);
                cenovnik.DatumOd = citac["DatumOd"].ToString();
                cenovnik.DatumDo = citac["DatumDo"].ToString();
                cenovnik.Cena = citac.GetInt32(4);
                cenovnici.Add(cenovnik as OpstiDomenskiObjekat);
            }
            return cenovnici;
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