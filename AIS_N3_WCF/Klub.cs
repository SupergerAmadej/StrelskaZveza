using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace AIS_N3_WCF
{
    [DataContract]
    public class Klub
    {
        [Key]
        [DataMember]
        public int KlubID { get; set; }
        [DataMember]
        public string Naziv { get; set; }
        [DataMember]
        public string Naslov { get; set; }
        [DataMember]
        public int LetoUstanovitve { get; set; }

        [DataMember]
        public virtual ICollection<StrelecVKlubu> Strelci { get; set; }

        public Klub()
        {
            this.Strelci = new HashSet<StrelecVKlubu>();
        }
       
    }
}