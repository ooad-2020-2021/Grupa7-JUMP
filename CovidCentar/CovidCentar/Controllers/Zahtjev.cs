using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Zahtjev
    {
        [Required]
        public Korisnik korisnik { get; }
        [Required]
        public DateTime datum { get; }
        [Required]
        public bool odobren { get; set; }

        public Zahtjev(Korisnik korisnik, DateTime datum, bool odobren)
        {
            this.korisnik = korisnik;
            this.datum = datum;
            this.odobren = odobren;
        }
    }
}
