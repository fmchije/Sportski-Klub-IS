using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomenskeKlase
{
    [Serializable]
    public class TransferKlasa
    {
        Object transferObjekat;

        List<OpstiDomenskiObjekat> listaTObjekata;

        bool uspesnost;

        public bool Uspesnost
        {
            get { return uspesnost; }
            set { uspesnost = value; }
        }

        int operacija;

        int signal;

        public int Signal
        {
            get { return signal; }
            set { signal = value; }
        }

        public int Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }

        public List<OpstiDomenskiObjekat> ListaTObjekata
        {
            get { return listaTObjekata; }
            set { listaTObjekata = value; }
        }
    }

    public enum Operacije
    {
        Sacuvaj_Uplatu = 1, Sacuvaj_Cenovnik, Sacuvaj_Trenera, Vrati_Sportove,
        VratiTrenereZaRaspored, VezbacURaspored, Vrati_Vezbace, Vrati_Termine,
        Vrati_MesecGodine, Sacuvaj_Vezbaca, Vrati_Trenere, VratiCeoCenovnik, vratiDug, Kraj
    };

}
