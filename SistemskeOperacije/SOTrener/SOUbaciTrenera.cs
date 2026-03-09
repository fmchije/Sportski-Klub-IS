using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SistemskeOperacije
{
    using Sesija;
    using DomenskeKlase;

    public class UbaciTrenera : OpstaSO
    {
        protected override bool Izvrsi(List<OpstiDomenskiObjekat> odoLista, Broker broker)
        {
            

            

            Trener trener = odoLista.ElementAt(0) as Trener;

            bool a = broker.Ubaci(trener);

            odoLista.RemoveAt(0);

            foreach (OpstiDomenskiObjekat odo in odoLista)
            {

                bool b = broker.Ubaci(odo);
                if (b == false)
                {
                    return false;

                }
            }
            if (a==true)
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