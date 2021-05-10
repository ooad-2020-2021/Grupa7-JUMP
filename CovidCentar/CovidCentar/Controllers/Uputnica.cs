using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Uputnica
    {
        
        [Required]
        public Korisnik korisnik { get; }

        [Required]
        public DateTime datumPodnosenja { get; }
        
        
        public Uputnica(Korisnik korisnik, DateTime datumPodnosenja)
        {
            this.korisnik = korisnik;
            this.datumPodnosenja = datumPodnosenja;
        }

    }
}
