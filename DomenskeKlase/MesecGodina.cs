using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DomenskeKlase
{
    public class MesecGodina //: OpstiDomenskiObjekat
    {
        #region Polja i svojstva

        private string mesecgodina;
        public string Mesecgodina
        {
            get { return mesecgodina; }
            set { mesecgodina = value; }
        }
    
        
#endregion

#region Konstruktori

public MesecGodina()
{
}

public MesecGodina(string mesecgodina)
{
    this.mesecgodina = mesecgodina;
}

#endregion

#region IOpstiDomenskiObjekat Members

public string ImeObjekta
{
    get { return "MesecGodina"; }
}

        public string ImeObjektaZaJoin
        {
            get { return null; }
        }

        public string ImeObjektaZaJoin2
        {
            get { return null; }
        }

        public string ImeJoinAtributa
        {
            get { return null; }
        }

        public string ImeJoinAtributa2
        {
            get { return null; }

        }
        public string ImeKljucnogAtributa
{
    get { return "MesecGodina"; }
}

        public string ImeKljucnogAtributa2
        {
            get { return null; }
        }

        public string UslovZaNalazenjeSloga
{
    get { return "MesecGodina = " + this.mesecgodina; }
}

public string UslovZaNalazenjeSlogova
{
    get { return null; }
}

public string VrednostiAtributaZaAzuriranje
{
    get
    {
        return " MesecGodina = '" + this.mesecgodina + "'";
    }
}
        public string VrednostiAtributaZaAzuriranje2
        {
            get { return null; }
        }

        public string VrednostiAtributaZaUbacivanje
{
    get
    {
        return "(" + this.mesecgodina + ")";
    }
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
        public OpstiDomenskiObjekat NapuniObjekat(DataRow red)
        {


            return null;
        }
        #endregion
    }
}