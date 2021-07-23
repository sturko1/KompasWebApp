using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//https//raw.githubusercontent.com/ooad-2020-2021/Grupa9-NASM/main/Class%20Diagram/MVCsaPaternima.jpg

namespace KompasBySajra.Models
{
    public class Pas
    {
        
        public int ID { get; set; }
        public string ime { get; set; }
        public int starosnaDob { get; set; }
        //public Gender Spol { get; set; }
        public string rasa { get; set; }
        public int tezina { get; set; }
        public string zdravstveniProblemi { get; set; }
        public bool kastriranSterilisan { get; set;  }
        public string slika { get; set; }

        public Pas() { }
        
        public Pas(int Id, string ime, int starosnaDob, string rasa, int tezina, bool ks)
        {
            ID = Id;
            this.ime = ime;
            this.starosnaDob = starosnaDob;
            this.rasa = rasa;
            this.tezina = tezina;
            kastriranSterilisan = ks;
        }
    }
}
