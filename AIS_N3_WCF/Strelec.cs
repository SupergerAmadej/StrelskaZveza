using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AIS_N3_WCF
{
    [DataContract]
    public class Strelec
    {
        [DataMember]
        public int StrelecID { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Priimek { get; set; }
        [DataMember]
        public int LetoRojstva { get; set; }

        [DataMember]
        public virtual ICollection<StrelecVKlubu> Klubi { get; set; }

        public Strelec()
        {
            this.Klubi = new HashSet<StrelecVKlubu>();
        }
    }
}