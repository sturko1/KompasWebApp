using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KompasBySajra.Models
{
    public class Post
    {
        public string tekst { get; set; }
        public int brojKomentara { get; set; }
        public int brojReakcija { get; set; }
        public Korisnik autorPosta { get; set; }

        //public List<Komentar> komentari {get; set; }    NAPRAVI KLASU KOMENTAR

        public Post() { }
        public Post (string tekst) { this.tekst = tekst; }
    }
}
