using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KompasBySajra.Models
{
    public class Profil
    {
        public Korisnik vlasnikProfila { get; set; }
        public Pas pas { get; set; }

        [NotMapped]
        public List<Podsjetnik> podsjetnici = new List<Podsjetnik>();
    }
}
