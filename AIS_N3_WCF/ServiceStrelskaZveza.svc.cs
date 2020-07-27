using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AIS_N3_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StrelskaZveza : IStrelskaZveza
    {
        public StrelskaZveza()
        {

        }

        public bool AddKlub(Klub k, out int id) //good
        {
            id = 0;
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    db.Klubi.Add(k);
                    db.SaveChanges();

                    id = k.KlubID;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            
        }

        public bool AddStrelec(Strelec s, out int id) //execellent
        {
            id = 0;
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    db.Strelci.Add(s);
                    db.SaveChanges();

                    id = s.StrelecID;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        private bool DeleteBridgeKlub(Klub k)
        {
            try
            {
                using(StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    var svk = db.StrelecVKlubus.Where(a => a.Klub.KlubID == k.KlubID);
                    db.StrelecVKlubus.RemoveRange(svk);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool DeleteBridgeStrelec(Strelec s)
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    var svk = db.StrelecVKlubus.Where(a => a.Strelec.StrelecID == s.StrelecID);
                    db.StrelecVKlubus.RemoveRange(svk);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteKlub(string id) //good
        {
            using (StrelskaZvezaDB db = new StrelskaZvezaDB())
            {
                try
                {
                    int iid = int.Parse(id);
                    var klub = db.Klubi.SingleOrDefault(x => x.KlubID == iid);
                    if (klub == null)
                        return false;
                    if (DeleteBridgeKlub(klub))
                    {
                        db.Klubi.Remove(klub);
                        db.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteStrelec(string id) //good
        {
            using (StrelskaZvezaDB db = new StrelskaZvezaDB())
            {
                try
                {
                    int iid = int.Parse(id);
                    var strelec = db.Strelci.SingleOrDefault(x => x.StrelecID == iid);
                    if (strelec == null)
                        return false;
                    if (DeleteBridgeStrelec(strelec))
                    {
                        db.Strelci.Remove(strelec);
                        db.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteSVK(string id)
        {
            using (StrelskaZvezaDB db = new StrelskaZvezaDB())
            {
                try
                {
                    int iid = int.Parse(id);
                    var svk = db.StrelecVKlubus.SingleOrDefault(a => a.StrelecKlubID == iid);
                    if (svk == null)
                        return false;
                    db.StrelecVKlubus.Remove(svk);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        public IEnumerable<Klub> ReturnKlubi() //good
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                        return (from p in db.Klubi
                                select new
                                {
                                    KlubID = p.KlubID,
                                    Naziv = p.Naziv,
                                    Naslov = p.Naslov,
                                    LetoUstanovitve = p.LetoUstanovitve
                                }).ToList()
                               .Select(x => new Klub
                               {
                                   KlubID = x.KlubID,
                                   Naziv = x.Naziv,
                                   Naslov = x.Naslov,
                                   LetoUstanovitve = x.LetoUstanovitve
                               });
                }
            }
            catch (Exception)
            {
                return new List<Klub>();
            }
        } 

        public IEnumerable<Strelec> ReturnStrelci() //good
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    return (from p in db.Strelci
                            select new
                            {
                                id = p.StrelecID,
                                ime = p.Ime,
                                priimek = p.Priimek,
                                rojstvo = p.LetoRojstva
                            }).ToList()
                           .Select(x => new Strelec
                           {
                               StrelecID = x.id,
                               Ime = x.ime,
                               Priimek = x.priimek,
                               LetoRojstva = x.rojstvo
                           });
                }
            }
            catch (Exception)
            {
                return new List<Strelec>();
            }
        }

        public IEnumerable<StrelecVKlubu> ReturnStrelecVKlubus()
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    return (from a in db.StrelecVKlubus
                            select new
                            {
                                sid = a.StrelecKlubID,
                                klub = new
                                {
                                    kid = a.Klub.KlubID,
                                    knaziv = a.Klub.Naziv,
                                    knaslov = a.Klub.Naslov,
                                    klu = a.Klub.LetoUstanovitve
                                }, 
                                strelec = new
                                {
                                    sid = a.Strelec.StrelecID,
                                    sime = a.Strelec.Ime,
                                    spri = a.Strelec.Priimek,
                                    slr = a.Strelec.LetoRojstva
                                },
                                od = a.Od,
                                ddo = a.Do
                            }).ToList().Select(a => new StrelecVKlubu
                            {
                                StrelecKlubID = a.sid,
                                Strelec = new Strelec 
                                {
                                    StrelecID = a.strelec.sid,
                                    Ime = a.strelec.sime,
                                    Priimek = a.strelec.spri,
                                    LetoRojstva = a.strelec.slr
                                },
                                Klub = new Klub {
                                    KlubID = a.klub.kid,
                                    Naziv = a.klub.knaziv,
                                    Naslov = a.klub.knaslov,
                                    LetoUstanovitve = a.klub.klu
                                },
                                Od = a.od,
                                Do = a.ddo
                            });
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<User> ReturnUseri()
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    return (from p in db.Useri
                            select new
                            {
                                ime = p.Ime,
                                geslo = p.Geslo
                            }).ToList()
                           .Select(x => new User
                           {
                               Ime = x.ime,
                               Geslo = x.geslo
                           });
                }
            }
            catch (Exception)
            {
                return new List<User>();
            }
        }


        public bool UpdateKlub(Klub k) //good i guess
        {
            using (StrelskaZvezaDB db = new StrelskaZvezaDB())
            {
                try
                {
                    var result = db.Klubi.SingleOrDefault(b => b.KlubID == k.KlubID);
                    if (result != null)
                    {
                        result.LetoUstanovitve = k.LetoUstanovitve;
                        result.Naslov = k.Naslov;
                        result.Naziv = k.Naziv;
                        db.SaveChanges();
                    }
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
                return true;


            }
        }

        public bool UpdateSVK(StrelecVKlubu svk)
        {
            using (StrelskaZvezaDB db = new StrelskaZvezaDB())
            {
                try
                {
                    var result = db.StrelecVKlubus.SingleOrDefault(a => a.StrelecKlubID == svk.StrelecKlubID);
                    if (result != null)
                    {
                        //result.StrelecId = svk.StrelecId;
                        //result.KlubId = svk.KlubId;
                        result.Od = svk.Od;
                        result.Do = svk.Do;
                        db.SaveChanges();
                    }
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        public bool DodajStrelcaVklub(Strelec s, string kid, out int id) //execellent
        {
            id = 0;
            try
            {
                int ikid = int.Parse(kid);
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    //db.Strelci.SingleOrDefault(a => a.StrelecID == s.StrelecID).StrelciVKlubus.Add(db.Klubi.SingleOrDefault(a => a.KlubID == ikid));
                    //db.SaveChanges();
                    Klub k = db.Klubi.SingleOrDefault(a => a.KlubID == ikid);
                    Strelec st = db.Strelci.SingleOrDefault(a => a.StrelecID == s.StrelecID);
                    if (k != null)
                    {
                        StrelecVKlubu svk = new StrelecVKlubu
                        {
                            Strelec = st,
                            Klub = k,
                            Od = DateTime.Now,
                        };
                        db.StrelecVKlubus.Add(svk);
                        db.SaveChanges();

                        id = svk.StrelecKlubID;
                    }
                    else
                        return false;

                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateStrelec(Strelec s) //good maybe
        {
            try
            {
                using(StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    var strelec = db.Strelci.SingleOrDefault(a => a.StrelecID == s.StrelecID);
                    if (strelec != null)
                    {
                        strelec.Ime = s.Ime;
                        strelec.Priimek = s.Priimek;
                        strelec.LetoRojstva = s.LetoRojstva;
                        db.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Klub GetKlub(string id) //good sam je useless
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    int iid = int.Parse(id);
                    //var klub =  (from s in db.Klubi
                    //               where s.KlubID == iid
                    //               select s).FirstOrDefault<Klub>();
                    //return klub;

                    return (from p in db.Klubi
                                where p.KlubID == iid
                                select new
                                {
                                    KlubID = p.KlubID,
                                    Naziv = p.Naziv,
                                    Naslov = p.Naslov,
                                    LetoUstanovitve = p.LetoUstanovitve
                                }).ToList()
                                    .Select(x => new Klub
                                {
                                    KlubID = x.KlubID,
                                    Naziv = x.Naziv,
                                    Naslov = x.Naslov,
                                    LetoUstanovitve = x.LetoUstanovitve
                                }).FirstOrDefault();

                }
            }
            catch (Exception)
            {
                return new Klub();
            }
        }

        public Strelec GetStrelec(string id)
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    int iid = int.Parse(id);

                    return (from p in db.Strelci
                            where p.StrelecID == iid
                            select new
                            {
                                id = p.StrelecID,
                                ime = p.Ime,
                                priimek = p.Priimek,
                                lr = p.LetoRojstva
                            }).ToList()
                                    .Select(x => new Strelec
                                    {
                                        StrelecID = x.id,
                                        Ime = x.ime,
                                        Priimek = x.priimek,
                                        LetoRojstva = x.lr
                                    }).FirstOrDefault();

                }
            }
            catch (Exception)
            {
                return new Strelec();
            }
        }

        public IEnumerable<Strelec> StrelciInKlub(string id) //works ... but useless
        {
            try
            {
                int iid = int.Parse(id);
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    //var asd = (from s in db.Strelci
                    //           where s.StrelciVKlubus.Contains(s.StrelciVKlubus.FirstOrDefault(a => a.KlubID == iid))
                    //           select new
                    //           {
                    //               id = s.StrelecID,
                    //               ime = s.Ime,
                    //               priimek = s.Priimek,
                    //               rojstvo = s.LetoRojstva,
                    //           }).ToList()
                    //           .Select(x => new Strelec
                    //           {
                    //               StrelecID = x.id,
                    //               Ime = x.ime,
                    //               Priimek = x.priimek,
                    //               LetoRojstva = x.rojstvo,
                    //           });

                    //return asd;

                    var strelci = (from a in db.StrelecVKlubus
                                   where a.Klub.KlubID == iid && a.Do == null //trenutno aktivne
                                   select new
                                   {
                                       id = a.Strelec.StrelecID,
                                       ime = a.Strelec.Ime,
                                       priimek = a.Strelec.Priimek,
                                       lr = a.Strelec.LetoRojstva
                                   }).ToList()
                                   .Select(a => new Strelec
                                   {
                                       StrelecID = a.id,
                                       Ime = a.ime,
                                       Priimek = a.priimek,
                                       LetoRojstva = a.lr
                                   });
                    return strelci;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Klub> KlubiOdStrelca(string id, out int[] trenutnoAktivni)
        {
            trenutnoAktivni = new int[0];
            try
            {
                int iid = int.Parse(id);
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {

                    var klubi = (from a in db.StrelecVKlubus
                                   where a.Strelec.StrelecID == iid //&& a.Do == null //trenutno aktivne
                                   select new
                                   {
                                       id = a.Klub.KlubID,
                                       naziv = a.Klub.Naziv,
                                       naslov = a.Klub.Naslov,
                                       lu = a.Klub.LetoUstanovitve
                                   }).ToList()
                                   .Select(a => new Klub
                                   {
                                       KlubID = a.id,
                                       Naziv = a.naziv,
                                       Naslov = a.naslov,
                                       LetoUstanovitve = a.lu
                                   });

                    trenutnoAktivni = (from a in db.StrelecVKlubus
                                       where a.Strelec.StrelecID == iid && a.Do == null
                                       select a.Klub.KlubID).ToArray();
                    return klubi;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CheckUser(User u, out bool admin)
        {
            try
            {
                using (StrelskaZvezaDB db = new StrelskaZvezaDB())
                {
                    User user = db.Useri.FirstOrDefault(a => a.Ime == u.Ime && a.Geslo == u.Geslo);
                    if (user != null)
                    {
                        if (user.Admin)
                            admin = true;
                        else
                            admin = false;
                        return true;
                    }
                    else
                    {
                        admin = false;
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                admin = false;
                return false;
            }
        }


    }
}
