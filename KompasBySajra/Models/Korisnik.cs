using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KompasBySajra.Models
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string eMail { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Pas pas { get; set; }

        public Korisnik() { }
        public Korisnik (int id, string ime, string prezime, string eMail, string username, string password, Pas pas)
        {
            ID = id;
            this.ime = ime;
            this.prezime = prezime;
            this.eMail = eMail;
            this.username = username;
            this.password = password;
            this.pas = pas;

        }
    }
}
