using System;
using System.Collections.Generic;
using System.Text;

namespace MiniProjekatKlas.KontrolerAplikacioneLogike
{
    using MiniProjekatKlas.DomenskeKlase;
    using MiniProjekatKlas.SistemskeOperacije;

    public class KALProizvod
    {
        public List<Proizvod> VratiSve(Proizvod proizvod)
        {
            VratiSveProizvode so = new VratiSveProizvode();

            List<IOpstiDomenskiObjekat> listaOpsta = so.IzvrsiSOProizvod(proizvod) as List<IOpstiDomenskiObjekat>;
            List<Proizvod> listaProizvoda = new List<Proizvod>();
            foreach (Proizvod pomProizvod in listaOpsta)
            {
                listaProizvoda.Add(pomProizvod);
            }

            return listaProizvoda;
        }

        public int VratiNovuSifru(Proizvod proizvod)
        {
            VratiNovuSifruZaProizvod so = new VratiNovuSifruZaProizvod();
            return Convert.ToInt32(so.IzvrsiSOProizvod(proizvod));
        }

        public int Ubaci(Proizvod proizvod)
        {
            UbaciProizvod so = new UbaciProizvod();
            return Convert.ToInt32(so.IzvrsiSOProizvod(proizvod));
        }

        public int Azuriraj(Proizvod proizvod)
        {
            AzurirajProizvod so = new AzurirajProizvod();
            return Convert.ToInt32(so.IzvrsiSOProizvod(proizvod));
        }

        public int Obrisi(Proizvod proizvod)
        {
            ObrisiProizvod so = new ObrisiProizvod();
            return Convert.ToInt32(so.IzvrsiSOProizvod(proizvod));
        }

        public Proizvod Vrati(Proizvod proizvod)
        {
            VratiProizvod so = new VratiProizvod();
            return so.IzvrsiSOProizvod(proizvod) as Proizvod;
        }
    }
}
