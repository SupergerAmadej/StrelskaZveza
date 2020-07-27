using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AIS_N3_WCF
{
    public class DbInit : CreateDatabaseIfNotExists<StrelskaZvezaDB>
    {
        protected override void Seed(StrelskaZvezaDB context)
        {
            IList<Strelec> strelci = new List<Strelec>();
            IList<User> users = new List<User>();
            IList<Klub> klubi = new List<Klub>();
            IList<StrelecVKlubu> svk = new List<StrelecVKlubu>();

            klubi.Add(new Klub { Naziv = "Zrece", Naslov = "pot na roglo 12", LetoUstanovitve = 1990 });
            klubi.Add(new Klub { Naziv = "Marbor", Naslov = "smetanova 15", LetoUstanovitve = 1991 });
            klubi.Add(new Klub { Naziv = "Ljubljana", Naslov = "prešernova 1", LetoUstanovitve = 1945 });

            strelci.Add(new Strelec { Ime = "bob", Priimek = "marley", LetoRojstva = 1998 });
            strelci.Add(new Strelec { Ime = "lars", Priimek = "gauda", LetoRojstva = 1999});
            strelci.Add(new Strelec { Ime = "pero", Priimek = "mozzarela", LetoRojstva = 1990});
            strelci.Add(new Strelec { Ime = "peter",Priimek="edamec",LetoRojstva=1998});
            strelci.Add(new Strelec { Ime = "ema",Priimek = "parmazan", LetoRojstva = 2000});

            users.Add(new User("amadeus", "asd", true));
            users.Add(new User("lars", "pleb", false));
            users.Add(new User("asd", "asd", true));

            svk.Add(new StrelecVKlubu { Strelec = strelci[0], Klub = klubi[0], Od = DateTime.Parse("2002-06-06") });
            svk.Add(new StrelecVKlubu { Strelec = strelci[4], Klub = klubi[0], Od = DateTime.Parse("2003-01-01") });
            svk.Add(new StrelecVKlubu { Strelec = strelci[1], Klub = klubi[1], Od = DateTime.Parse("2005-01-01") });
            svk.Add(new StrelecVKlubu { Strelec = strelci[2], Klub = klubi[2], Od = DateTime.Parse("2005-02-02") });
            svk.Add(new StrelecVKlubu { Strelec = strelci[3], Klub = klubi[2], Od = DateTime.Parse("2005-05-02") });
            svk.Add(new StrelecVKlubu { Strelec = strelci[0], Klub = klubi[1], Od = DateTime.Parse("1998-01-01"), Do = DateTime.Parse("2002-06-05") });
            svk.Add(new StrelecVKlubu { Strelec = strelci[4], Klub = klubi[2], Od = DateTime.Parse("1999-01-01"), Do = DateTime.Parse("2002-06-05") });

            context.Klubi.AddRange(klubi);
            context.Strelci.AddRange(strelci);
            context.Useri.AddRange(users);
            context.StrelecVKlubus.AddRange(svk);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}