using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using DomenskeKlase;
using System.Runtime.Serialization.Formatters.Binary;

namespace KorisnickiInterfejs
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater = new BinaryFormatter();
        int brojKlijenta;

        public int BrojKlijenta
        {
            get { return brojKlijenta; }
            set { brojKlijenta = value; }
        }

        public bool poveziSeSaServerom()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 10000);
                tok = klijent.GetStream();
                TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                if (transfer.Operacija == (int)Operacije.Kraj)
                {
                    return false;
                }
                brojKlijenta = transfer.Signal;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int dodajVezbaca(Vezbac v)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Sacuvaj_Vezbaca;
            transfer.TransferObjekat = v;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return transfer.Signal;
        }

        public List<OpstiDomenskiObjekat> VratiCeoCenovnik()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.VratiCeoCenovnik;
            transfer.TransferObjekat = new Cenovnik();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
            //return transfer.Signal;
        }


        public int dodajTrenera(Trener t, List<TrenerSport> tsovi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Sacuvaj_Trenera;
            //punjenje treansfer.ListTObjekata
            transfer.ListaTObjekata = new List<OpstiDomenskiObjekat>();
           //dodaja trenera u listu
            transfer.ListaTObjekata.Add(t);
            //dodaje sportove
            foreach (TrenerSport ts in tsovi)
                {
                transfer.ListaTObjekata.Add(ts);
            }
            //salje
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return transfer.Signal;
        }

        public List<OpstiDomenskiObjekat> vratiTrenere(Raspored r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.VratiTrenereZaRaspored;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>; ;
            }
            else
            {
                return null;
            }
            //return transfer.Signal;
        }

        public int vezbacURaspored(Raspored r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.VezbacURaspored;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return transfer.Signal;
        }

        public int dodajCenovnik(Cenovnik c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Sacuvaj_Cenovnik;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return transfer.Signal;
        }

        public int dodajUplatu(Placanje u,Vezbac v)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Sacuvaj_Uplatu;
            transfer.ListaTObjekata = new List<OpstiDomenskiObjekat>();
            transfer.ListaTObjekata.Add(u);
            transfer.ListaTObjekata.Add(v);
            
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return transfer.Signal;
        }







        public List<OpstiDomenskiObjekat> vratiSportove()
        {

            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Vrati_Sportove;
            transfer.TransferObjekat = new Sport();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

             public List<OpstiDomenskiObjekat> vratiTermine()
        {

            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Vrati_Termine;
            transfer.TransferObjekat = new Termin();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public List<OpstiDomenskiObjekat> vratiMesecGodine()
        {

            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Vrati_MesecGodine;
            transfer.TransferObjekat = new MesecGodina();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public List<OpstiDomenskiObjekat> vratiVezbace()
        {

            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Vrati_Vezbace;
            transfer.TransferObjekat = new Vezbac();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveTrenere()
        {

            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Vrati_Trenere;
            transfer.TransferObjekat = new Trener();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }


        public int AzurirajVezbaca (Vezbac v)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Sacuvaj_Uplatu;
            transfer.TransferObjekat = v;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return transfer.Signal;
        }


        public void zatvori()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.Kraj;
            transfer.Signal = brojKlijenta;
            formater.Serialize(tok, transfer);
        }

       
    }
}
