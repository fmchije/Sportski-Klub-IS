using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using DomenskeKlase;
using Sesija;
using System.Threading;
using SistemskeOperacije;

namespace Server
{
    public class NitKlijenta
    {
        BinaryFormatter formater;
        NetworkStream tok;
        List<TransferKlasa> klijenti = new List<TransferKlasa>();


        public NitKlijenta(NetworkStream tok, List<TransferKlasa> klijenti)
        {
            formater = new BinaryFormatter();
            this.tok = tok;
            this.klijenti = klijenti;
            ThreadStart ts = obradaPodataka;
            Thread nit = new Thread(ts);
            nit.Start();


        }

        private void obradaPodataka()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {

                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    operacija = transfer.Operacija;
                    switch (transfer.Operacija)
                    {
                        case ((int)Operacije.Sacuvaj_Vezbaca):
                            UbaciVezbaca ubaci = new UbaciVezbaca();
                            transfer.Uspesnost = ubaci.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            //transfer.Signal = Broker.dajSesiju().ubaciMestoUBazu(transfer.TransferObjekat as Mesto);
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Sacuvaj_Cenovnik):
                            UbaciCenovnik ubaci1 = new UbaciCenovnik();
                            transfer.Uspesnost = ubaci1.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            //transfer.Signal = Broker.dajSesiju().ubaciMestoUBazu(transfer.TransferObjekat as Mesto);
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Sacuvaj_Trenera):
                            UbaciTrenera ubaci2 = new UbaciTrenera();
                            transfer.Uspesnost = ubaci2.IzvrsiSO(transfer.ListaTObjekata);
                            //transfer.Signal = Broker.dajSesiju().ubaciMestoUBazu(transfer.TransferObjekat as Mesto);
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Sacuvaj_Uplatu):
                            UbaciUplatu ubaci3 = new UbaciUplatu();

                            transfer.Uspesnost = ubaci3.IzvrsiSO(transfer.ListaTObjekata);//transfer.TransferObjekat as OpstiDomenskiObjekat/*, vezbac as OpstiDomenskiObjekat*/);
                            //transfer.Signal = Broker.dajSesiju().ubaciMestoUBazu(transfer.TransferObjekat as Mesto);
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Vrati_Sportove):
                            VratiSveSportove vrati = new VratiSveSportove();
                            transfer.Uspesnost = vrati.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = vrati.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        
                        case ((int)Operacije.VratiCeoCenovnik):
                            VratiSveSportove vrati9 = new VratiSveSportove();
                            transfer.Uspesnost = vrati9.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = vrati9.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.VratiTrenereZaRaspored):
                            VratiTrenere vrati4 = new VratiTrenere();
                            transfer.Uspesnost = vrati4.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = vrati4.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.VezbacURaspored):
                            VezbacURaspored ubaci5 = new VezbacURaspored();
                            transfer.Uspesnost = ubaci5.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            //transfer.TransferObjekat = vrati.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Vrati_Vezbace):
                            VratiSveVezbace vrati6 = new VratiSveVezbace();
                            transfer.Uspesnost = vrati6.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = vrati6.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Vrati_Trenere):
                            VratiSveTrenere vrati10 = new VratiSveTrenere();
                            transfer.Uspesnost = vrati10.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = vrati10.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Vrati_Termine):
                            VratiSveTermine vrati7 = new VratiSveTermine();
                            transfer.Uspesnost = vrati7.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = vrati7.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Vrati_MesecGodine):
                            VratiSveMesecGodine vrati8 = new VratiSveMesecGodine();
                            transfer.Uspesnost = vrati8.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            //transfer.TransferObjekat = vrati.Lista;
                            formater.Serialize(tok, transfer);
                            break;
                        case ((int)Operacije.Kraj):
                            Console.WriteLine("Hvala na konekciji!");
                            foreach (TransferKlasa t in klijenti)
                            {
                                if (t.Signal == transfer.Signal)
                                {
                                    klijenti.Remove(t);
                                    break;
                                }
                            }
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prekid niti:" + ex.Message);
            }
        }
    }
}
