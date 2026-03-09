using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace DomenskeKlase
{
    [Serializable]
    public class Termin : OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private string terminID;
        public string TerminID
        { 
            get { return terminID; }
            set { terminID = value; }
        }

        
#endregion

#region Konstruktori

public Termin()
{
}

public Termin(string terminID)
{
    this.terminID = terminID;
}

#endregion

#region IOpstiDomenskiObjekat Members

public string ImeObjekta()
{
     return "Termin"; 
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
    return "Termin"; 
}
        public string ImeKljucnogAtributa2()
        {
             return null; 
        }

        public string UslovZaNalazenjeSloga()
{
     return "Termin = " + this.terminID; 
}

public string UslovZaNalazenjeSlogova()
{
     return null; 
}

public string VrednostiAtributaZaAzuriranje()
{
    
        return " Termin = '" + this.terminID + "'";
   
}
        public string VrednostiAtributaZaAzuriranje2()
        {
             return null; 
        }

        public string VrednostiAtributaZaUbacivanje()
{
    
        return "(" + this.terminID + ")";
    
}

public List<OpstiDomenskiObjekat> vratiListu(System.Data.OleDb.OleDbDataReader citac)
{
    List<OpstiDomenskiObjekat> termini = new List<OpstiDomenskiObjekat>();
    while (citac.Read())
    {
        Termin termin = new Termin();
        termin.TerminID = citac["TerminID"].ToString();
        
        termini.Add(termin);
    }
    return termini;
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
            return terminID;
        }

    }
}