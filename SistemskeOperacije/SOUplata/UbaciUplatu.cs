using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SistemskeOperacije
{
    using Sesija;
    using DomenskeKlase;

    public class UbaciUplatu : OpstaSO
    {
        protected override bool Izvrsi(List<OpstiDomenskiObjekat> odoList, Broker broker)
        {
            


            OpstiDomenskiObjekat odo = odoList.ElementAt(0);


            bool a = broker.Ubaci(odo);

            OpstiDomenskiObjekat odo2 = odoList.ElementAt(1);

            bool b = broker.Azuriraj(odo2);

            if (a&&b)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}