using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije
{
    using Sesija;
    using DomenskeKlase;

    public class UbaciVezbaca : OpstaSO
    {
        protected override bool Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        {
           

            

            return broker.Ubaci(odo);

            

            
        }

       
    }
}