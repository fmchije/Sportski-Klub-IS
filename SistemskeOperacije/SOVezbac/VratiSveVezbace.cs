using System.Text;
using Sesija;
using DomenskeKlase;
namespace SistemskeOperacije
{
    public class VratiSveVezbace : OpstaSO
    {
        protected override bool Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
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