using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DomenskeKlase
{
    public interface OpstiDomenskiObjekat
    {
        string ImeObjekta();


        string ImeObjektaZaJoin();



        string ImeKljucnogAtributa();



        string ImeKljucnogAtributa2();


        string ImeJoinAtributa();


        string ImeJoinAtributa2();


        string UslovZaNalazenjeSloga();


        string UslovZaNalazenjeSlogova();


        string VrednostiAtributaZaAzuriranje();

        string VrednostiAtributaZaAzuriranje2();


        string VrednostiAtributaZaUbacivanje();
      

        List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac);

        List<OpstiDomenskiObjekat> vratiListu2(OleDbDataReader citac);

        OpstiDomenskiObjekat NapuniObjekat(DataRow red);
        
    }
}
