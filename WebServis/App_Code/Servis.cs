using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using MiniProjekatKlas.KontrolerAplikacioneLogike;
using MiniProjekatKlas.DomenskeKlase;
using System.Collections.Generic;

[WebService(Namespace = "localhost")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Servis : System.Web.Services.WebService
{
    KALProizvod kontrolerProizvoda;
    KALRacun kontrolerRacuna;
    public Servis()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        kontrolerProizvoda = new KALProizvod();
        kontrolerRacuna = new KALRacun();
    }

    [WebMethod]
    public int VratiNovuSifruZaProizvod()
    {
        return kontrolerProizvoda.VratiNovuSifru(new Proizvod());
    }

    [WebMethod]
    public List<Proizvod> VratiSveProizvode(Proizvod proizvod)
    {
        return kontrolerProizvoda.VratiSve(proizvod);
    }

    [WebMethod]
    public int UbaciProizvod(Proizvod proizvod)
    {
        return kontrolerProizvoda.Ubaci(proizvod);
    }

    [WebMethod]
    public int AzurirajProizvod(Proizvod proizvod)
    {
        return kontrolerProizvoda.Azuriraj(proizvod);
    }

    [WebMethod]
    public int ObrisiProizvod(Proizvod proizvod)
    {
        return kontrolerProizvoda.Obrisi(proizvod);
    }

    [WebMethod]
    public Proizvod VratiProizvod(Proizvod proizvod)
    {
        return kontrolerProizvoda.Vrati(proizvod);
    }

    [WebMethod]
    public int VratiNovuSifruZaRacun(Racun rac)
    {
        return kontrolerRacuna.VratiNovuSifru(rac);
    }

    [WebMethod]
    public Racun VratiRacun(Racun rac)
    {
        return kontrolerRacuna.Vrati(rac);
    }

    [WebMethod]
    public int UbaciRacun(Racun rac)
    {
        return kontrolerRacuna.Ubaci(rac);
    }

    [WebMethod]
    public int AzurirajRacun(Racun rac)
    {
        return kontrolerRacuna.Azuriraj(rac);
    }

    [WebMethod]
    public int StornirajRacun(Racun rac)
    {
        return kontrolerRacuna.Storniraj(rac);
    }
}