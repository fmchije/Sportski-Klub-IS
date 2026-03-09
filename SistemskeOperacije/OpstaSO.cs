using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije
{
    using Sesija;
    using DomenskeKlase;

    public class OpstaSO
    {
        protected Broker broker;

        List<OpstiDomenskiObjekat> lista;

        public List<OpstiDomenskiObjekat> Lista
        {
            get { return lista; }
            set { lista = value; }
        }


        public OpstaSO()
        {
            this.broker = new Broker();
        }

        public bool IzvrsiSO(OpstiDomenskiObjekat odo)
        {
            bool rezultat;

            broker.OtvoriKonekciju();
            broker.ZapocniTransakciju();

            rezultat = Izvrsi(odo, broker);
            if (rezultat)
               
            {
               
                broker.PotvrdiTransakciju();
            }
            else
            {
                broker.PonistiTransakciju();
               
            }
            
                broker.ZatvoriKonekciju();
            

            return rezultat;
        }

        public object IzvrsiSO(OpstiDomenskiObjekat odo, OpstiDomenskiObjekat odo2)
        {
            object rezultat = null;

            broker.OtvoriKonekciju();
            broker.ZapocniTransakciju();

            try
            {
                rezultat = Izvrsi(odo, broker);
               
                broker.PotvrdiTransakciju();
            }
            catch (Exception ex)
            {
                broker.PonistiTransakciju();
                throw ex;
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }

            return rezultat;
        }

        public bool IzvrsiSO(List<OpstiDomenskiObjekat> odoList)
        {
            bool rezultat;

            broker.OtvoriKonekciju();
            broker.ZapocniTransakciju();
            rezultat = Izvrsi(odoList, broker);
           if(rezultat)
            {
                
                
                broker.PotvrdiTransakciju();
            }
            else
            {
                broker.PonistiTransakciju();
                
            }
           
            
                broker.ZatvoriKonekciju();
            

            return rezultat;
        }

        protected virtual bool Izvrsi(OpstiDomenskiObjekat odo, Broker broker)
        { return false; }

        protected virtual bool Izvrsi(List<OpstiDomenskiObjekat> odo, Broker broker)
        { return false; }
    }
}
