using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KompasBySajra.Models
{
    public class Podsjetnik
    {
        public string tekst { get; set; }
        public DateTime termin { get; set; }

        public Podsjetnik() { }
        public Podsjetnik (string tekst, DateTime termin)
        {
            this.tekst = tekst;
            this.termin = termin;

        }
    }
}
