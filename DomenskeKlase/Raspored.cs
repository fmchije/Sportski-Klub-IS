using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DomenskeKlase
{   [Serializable]
    public class Raspored : OpstiDomenskiObjekat
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

        private string datum;
        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private int jmbg;
        public int Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        private int vezbacID;
        public int VezbacID
        {
            get { return vezbacID; }
            set { vezbacID = value; }
        }

        #endregion

        #region Konstruktori

        public Raspored()
        {
        }



        public Raspored(int sportID, string termin, string datum, int vezbacID, int trenerID )
        {
            this.sportID = sportID;
            this.terminID = termin;
            this.datum = datum;
            this.vezbacID = vezbacID;
            this.jmbg = trenerID;
        }

        #endregion

        #region OpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
            return "Raspored";
        }

        public string ImeObjektaZaJoin()
        {
             return "Trener"; 
        }

        public string ImeObjektaZaJoin2()
        {
             return "Cenovnik"; 
        }

        public string ImeKljucnogAtributa()
        {
             return "Raspored.JMBG, ImePrezimeTrener"; 
        }

        public string ImeKljucnogAtributa2()
        {
             return "VezbacID,Cena"; 
        }

        public string ImeJoinAtributa()
        {
            return "JMBG"; 
        }

        public string ImeJoinAtributa2()
        {
            return "SportID AND TerminID";
        }

        public string UslovZaNalazenjeSloga()
        {
             return "Raspored.Datum = " + this.Datum + " AND Raspored.Datum between Cenovnik.DatumOd and Cenovnik.datumDo"  ; 
        }

        public string UslovZaNalazenjeSlogova()
        {
            return "Raspored.Datum=" + this.datum +  " AND Raspored.SportID=" + this.sportID + " AND Raspored.TerminID='" + this.terminID +"' AND Raspored.VezbacID=" + this.vezbacID + " AND Raspored.Datum BETWEEN Cenovnik.DatumOd and Cenovnik.datumDo"; 
        }

        public string VrednostiAtributaZaAzuriranje()
        {
            
                return "DatumDo = " + this.datum + "'";
            
        }

        public string VrednostiAtributaZaAzuriranje2()
        {
             return null; 
        }

        public string VrednostiAtributaZaUbacivanje()
        {
           
                return "(" + this.sportID.ToString() + "," + this.jmbg.ToString() + "," + this.vezbacID + ",'" + this.terminID + "', " + this.datum + ")";
            
        }

        public List<OpstiDomenskiObjekat> vratiListu(System.Data.OleDb.OleDbDataReader citac)
        {

            List<OpstiDomenskiObjekat> vezbaci = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {

                Vezbac vezbac = new Vezbac();
                vezbac.UkupnaVrednost = citac.GetInt32(1);
                vezbac.VezbacID = citac.GetInt32(0);
                Console.WriteLine(vezbac.UkupnaVrednost);
                vezbaci.Add(vezbac as OpstiDomenskiObjekat);

            }
            return vezbaci;
        }

        public List<OpstiDomenskiObjekat> vratiListu2(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> treneri = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Trener trener = new Trener();
                trener.ImePrezimeTrener = citac["ImePrezimeTrener"].ToString();
                trener.Jmbg = citac.GetInt32(0);

                treneri.Add(trener as OpstiDomenskiObjekat);
            }
            return treneri;
        }

        public OpstiDomenskiObjekat NapuniObjekat(DataRow red)
        {


            return null;
        }
        #endregion
    }
}