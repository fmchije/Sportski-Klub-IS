using System.Text;
using Sesija;

namespace SistemskeOperacije
{
    using DomenskeKlase;
    public class VratiTrenere : OpstaSO
    {
        
        protected override bool Izvrsi(OpstiDomenskiObjekat odo,Broker broker)
        {
            try
            {
                Lista = broker.vratiZaUslovJOIn(odo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}