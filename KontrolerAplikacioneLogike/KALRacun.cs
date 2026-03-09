using System;
using System.Collections.Generic;
using System.Text;

namespace MiniProjekatKlas.KontrolerAplikacioneLogike
{
    using MiniProjekatKlas.DomenskeKlase;
    using MiniProjekatKlas.SistemskeOperacije;

    public class KALRacun
    {
        

        public int VratiNovuSifru(Racun rac)
        {
            VratiNovuSifruZaRacun so = new VratiNovuSifruZaRacun();
            return Convert.ToInt32(so.IzvrsiSORacun(rac));
        }

        public Racun Vrati(Racun rac)
        {
            VratiRacun so = new VratiRacun();
            return so.IzvrsiSORacun(rac) as Racun;
        }

        public int Ubaci(Racun rac)
        {
            UbaciRacun so = new UbaciRacun();
            return Convert.ToInt32(so.IzvrsiSORacun(rac));
        }

        public int Azuriraj(Racun rac)
        {
            AzurirajRacun so = new AzurirajRacun();
            return Convert.ToInt32(so.IzvrsiSORacun(rac));
        }

        public int Storniraj(Racun rac)
        {
            StornirajRacun so = new StornirajRacun();
            return Convert.ToInt32(so.IzvrsiSORacun(rac));
        }
    }
}
