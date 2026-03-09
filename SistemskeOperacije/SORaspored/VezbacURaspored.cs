using System;
using System.Text;
using Sesija;
using System.Collections.Generic;
using DomenskeKlase;
using System.Linq;
using System.Data;
namespace SistemskeOperacije
{
    public class VezbacURaspored : OpstaSO
    {
        protected override bool Izvrsi(DomenskeKlase.OpstiDomenskiObjekat odo, Broker broker)
        {
            try
            {
                broker.Ubaci(odo);
                List<OpstiDomenskiObjekat> v = broker.vratiZaUslovJOIN2(odo);
                Vezbac o = v.ElementAt(0) as Vezbac;
                Console.WriteLine(o.UkupnaVrednost);
                broker.Azuriraj2( v.ElementAt(0));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}