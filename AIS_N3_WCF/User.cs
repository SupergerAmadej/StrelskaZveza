using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AIS_N3_WCF
{
    [DataContract]
    public class User
    {
        string ime;
        string geslo;
        bool admin;

        public User()
        {

        }

        public User(string ime, string geslo, bool admin)
        {
            Ime = ime;
            Geslo = geslo;
            Admin = admin;
        }
        [Key]
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Ime { get => ime; set => ime = value; }
        [DataMember]
        public string Geslo { get => geslo; set => geslo = value; }
        [DataMember]
        public bool Admin { get => admin; set => admin = value; }
    }
}