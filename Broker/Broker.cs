using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Reflection;


using System.Linq;

namespace Sesija
{
    using DomenskeKlase;

    public class Broker
    {
        private OleDbConnection konekcija;
        private OleDbTransaction transakcija;

        public Broker()
        {
            //string konString = ConfigurationManager.ConnectionStrings["konekcioniString"].ConnectionString;
            this.konekcija =
                new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\sem2.accdb;Persist Security Info=False;");
        }

        #region Metode za rukovanje konekcijama i transakcijama
        
        public void OtvoriKonekciju()
        {
            try
            {
                this.konekcija.Open();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri otvaranju konekcije sa bazom!");
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                this.konekcija.Close();
            }
            catch (Exception)
            {               
                throw new Exception("Greska pri zatvaranju konekcije sa bazom!");
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {            
                throw new Exception("Greska pri zapocinjanju transakcije!");
            }
        }

        public void PotvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {              
                throw new Exception("Greska pri potvrdjivanju transakcije!");
            }
        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {              
                throw new Exception("Greska pri ponistavanju transakcije!");
            }
        }

        #endregion

        /// <summary>
        /// Vraca sve slogove iz date relacije
        /// </summary>
        /// <param name="odo">Objekat iz trazene relacije</param>
        /// <returns>Lista svih objekata</returns>
      /*  public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT *" +
                                    " FROM " + odo.ImeObjekta;
            OleDbDataReader reader = null;

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);

                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pomOdo = odo.NapuniObjekat(red);
                    lista.Add(pomOdo);
                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        } */

        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select * from " + odo.ImeObjekta();
                //Console.WriteLine(upit);
                OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                return odo.vratiListu(citac);
            }
            catch (Exception ex)
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        public List<OpstiDomenskiObjekat> vratiZaUslovJOIn(OpstiDomenskiObjekat odo)
        {
            try
            {
        
                string upit = "Select " + odo.ImeKljucnogAtributa() + " from " + odo.ImeObjekta() +  " INNER JOIN " + odo.ImeObjektaZaJoin() + " ON Raspored.JMBG=Trener.JMBG  Where " + odo.UslovZaNalazenjeSlogova();
                //(" + odo.ImeJoinAtributa() + ")
                //Console.WriteLine(upit);
                OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                return odo.vratiListu2(citac);
            }
            catch (Exception ex)
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        public List<OpstiDomenskiObjekat> vratiZaUslovJOIN2(OpstiDomenskiObjekat odo)
        {
            try
            {

                string upit = "Select " + odo.ImeKljucnogAtributa2() + " from " + odo.ImeObjekta() + " INNER JOIN Cenovnik ON Raspored.TerminID=Cenovnik.TerminID AND Raspored.SportID=Cenovnik.SportID Where " + odo.UslovZaNalazenjeSlogova();
                //(" + odo.ImeJoinAtributa2() + ")
                //Console.WriteLine(upit);
                OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                return odo.vratiListu(citac);

            }
            catch (Exception ex)
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }






        public List<OpstiDomenskiObjekat> VratiSveZaUslov2(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upitniString = "SELECT *" +
                                    " FROM " + odo.ImeObjekta() + 
                                    " WHERE " + odo.UslovZaNalazenjeSlogova();

                //Console.WriteLine(upitniString);

                OleDbDataReader reader = null;

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);
          
                reader = komanda.ExecuteReader();
                return odo.vratiListu2(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
           
        }



        /// <summary>
        /// Vraca objekat za datu vrednost kljucnog atributa
        /// </summary>
        /// <param name="odo">Objekat sa vrednoscu kljucnog atributa</param>
        /// <returns>Trazeni objekat (ili null,
        /// ako trazeni objekat ne postoji) </returns>
        public OpstiDomenskiObjekat Vrati(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT *" +
                                    " FROM " + odo.ImeObjekta() +
                                    " WHERE " + odo.UslovZaNalazenjeSloga();

           

            OleDbDataReader reader = null;

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;

                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }

                return odo.NapuniObjekat(red);
            }
            catch (Exception)
            {               
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public bool Azuriraj(OpstiDomenskiObjekat odo)
        {

            try
            {
                string upitniString = "UPDATE " + odo.ImeObjekta() +
                                    " SET " + odo.VrednostiAtributaZaAzuriranje() +
                                    " WHERE " + odo.UslovZaNalazenjeSloga();

                //Console.WriteLine(upitniString);
                OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Azuriraj2(OpstiDomenskiObjekat odo)
        {
            string upitniString = "UPDATE " + odo.ImeObjekta() +
                                    " SET " + odo.VrednostiAtributaZaAzuriranje2() +
                                    " WHERE " + odo.UslovZaNalazenjeSloga();

            //Console.WriteLine(upitniString);
            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);

            try
            {
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
               
            }
        }


        public bool Ubaci(OpstiDomenskiObjekat odo)
        {
            string upitniString = "INSERT INTO " + odo.ImeObjekta() +
                                    " VALUES " + odo.VrednostiAtributaZaUbacivanje();

            //Console.WriteLine(upitniString);

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);

            try
            {
                 komanda.ExecuteNonQuery();
                 return true; 
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u radu sa bazom!"); 
            }
        }


        public int Obrisi(OpstiDomenskiObjekat odo)
        {
            string upitniString = "DELETE *" +
                                    " FROM " + odo.ImeObjekta() +
                                    " WHERE " + odo.UslovZaNalazenjeSloga();

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message == "The record cannot be deleted or changed because table 'StavkaRacuna' includes related records.")
                {
                    throw new Exception("Objekat ne moze biti obrisan!\nPostoji veza sa drugim objektom");
                }
                else
                {
                    throw new Exception("Greska u radu sa bazom!");
                }
            }

        }

        public int ObrisiSveZaUslov(OpstiDomenskiObjekat odo)
        {
            string upitniString = "DELETE *" +
                                    " FROM " + odo.ImeObjekta() +
                                    " WHERE " + odo.UslovZaNalazenjeSlogova();

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int VratiSlobodnuSifruIUbaciNovu(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT SlobodnaSifra" + 
                                    " FROM Sifarnik" + 
                                    " WHERE NazivTabele = '" + odo.ImeObjekta() + "'";

            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);

            try
            {
                int sifraSlobodna = Convert.ToInt32(komanda.ExecuteScalar());
                int sifraNova = sifraSlobodna + 1;

                upitniString = "UPDATE Sifarnik" +
                                " SET SlobodnaSifra = " + sifraNova.ToString() +
                                " WHERE NazivTabele = '" + odo.ImeObjekta() + "'";

                komanda.CommandText = upitniString;
                komanda.ExecuteNonQuery();

                return sifraSlobodna;
            }
            catch (Exception)
            {
               throw new Exception("Greska u radu sa bazom!");
            }
        }                                    
    }
}
