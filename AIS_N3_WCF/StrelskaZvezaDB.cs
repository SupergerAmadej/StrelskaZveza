using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Data.Entity;

namespace AIS_N3_WCF
{

    public class StrelskaZvezaDB : DbContext
    {
        public StrelskaZvezaDB() : base("StrelskaZvezaDatabase")
        {
            Database.SetInitializer(new DbInit());
        }


        [DataMember]
        public DbSet<Klub> Klubi { get; set; }

        [DataMember]
        public DbSet<StrelecVKlubu> StrelecVKlubus {get; set;}

        [DataMember]
        public DbSet<Strelec> Strelci { get; set; }

        [DataMember]
        public DbSet<User> Useri { get; set; }

    }
}