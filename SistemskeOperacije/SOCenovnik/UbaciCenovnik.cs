using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije
{
    using Sesija;
    using DomenskeKlase;

    public class UbaciCenovnik : OpstaSO
    {
        protected override bool Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        {
            

            Cenovnik cenovnik = odo as Cenovnik;


           if (broker.Azuriraj(cenovnik)&&broker.Ubaci(cenovnik))

            { return true; }

            else { return false; }


           
        }
    }
}