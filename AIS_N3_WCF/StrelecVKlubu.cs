using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AIS_N3_WCF
{
    [DataContract]
    public class StrelecVKlubu
    {
        [DataMember]
        [Key]
        public int StrelecKlubID { get; set; }
        [DataMember]
        public DateTime Od { get; set; }
        [DataMember]
        public DateTime? Do { get; set; }

        public int StrelecId { get; set; }
        [DataMember]
        public virtual Strelec Strelec { get; set; }
        [DataMember]
        public int KlubId { get; set; }
        [DataMember]
        public virtual Klub Klub { get; set; }

    }
}