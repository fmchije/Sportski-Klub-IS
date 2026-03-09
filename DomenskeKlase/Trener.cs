using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DomenskeKlase
{
    [Serializable]
    public class Trener : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private int jmbg;
        public int Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        private string imePrezimeTrener;
        public string ImePrezimeTrener
        {
            get { return imePrezimeTrener; }
            set { imePrezimeTrener = value; }
        }


        #endregion

        #region Konstruktori

        public Trener()
        {
        }

        public Trener(int jmbg)
        {
            this.jmbg = jmbg;
        }

        public Trener(int jmbg, string imePrezimeVezbac)
        {
            this.jmbg = jmbg;
            this.imePrezimeTrener = imePrezimeVezbac;

        }

        #endregion

        #region OpstiDomenskiObjekat Members

        public string ImeObjekta()
        {
             return "Trener"; 
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
           
                return " JMBG = '" + this.jmbg.ToString() + "' , IMePrezimeVezbac = " + this.imePrezimeTrener + "'";
            
        }
        public string VrednostiAtributaZaAzuriranje2()
        {
             return null; 
        }

        public string VrednostiAtributaZaUbacivanje()
        {
           
                return "(" + this.jmbg.ToString() + ", '" + this.imePrezimeTrener + "')";
            
        }

        public List<OpstiDomenskiObjekat> vratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> treneri = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Trener trener = new Trener();
                trener.ImePrezimeTrener = citac["ImePrezimeTrener"].ToString();
                trener.Jmbg = citac.GetInt32(0);
                treneri.Add(trener);
            }
            return treneri;
        }

        public List<OpstiDomenskiObjekat> vratiListu2(OleDbDataReader citac)
        {

            return null;
        }

        public OpstiDomenskiObjekat NapuniObjekat(DataRow red)
        {


            return null;
        }

        public override string ToString()
        {
            return imePrezimeTrener;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
            Trener t = obj as Trener;
        }



        #endregion
    }
}