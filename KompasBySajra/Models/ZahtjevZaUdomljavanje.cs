using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KompasBySajra.Models
{
    public class ZahtjevZaUdomljavanje
    {
        public int ID { get; set; }
        public string grad { get; set; }
        public string adresa { get; set; }

        public bool imaPsa { get; set; }
        public Korisnik korisnik { get; set; }
        public Pas izabraniPas { get; set; }

        public ZahtjevZaUdomljavanje (int id, Korisnik korisnik, Pas izabraniPas, string grad, string adresa, bool imaPsa)
        {
            ID = id;
            this.korisnik = korisnik;
            this.izabraniPas = izabraniPas;
            this.grad = grad;
            this.adresa = adresa;
            this.imaPsa = imaPsa;
        }

        public ZahtjevZaUdomljavanje() { }
    }
}
