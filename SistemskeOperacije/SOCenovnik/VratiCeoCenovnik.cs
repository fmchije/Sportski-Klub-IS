using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sesija;

namespace SistemskeOperacije
{
    public class VratiCeoCenovnik : OpstaSO
    {
        protected override bool Izvrsi(DomenskeKlase.OpstiDomenskiObjekat odo, Broker broker)
        {
            try
            {
                Lista = broker.vratiSve(odo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}