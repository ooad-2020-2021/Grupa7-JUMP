using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{

    public class Uputnica
    {
        
        [Required]
        [Display(Name = "Korisnik kome se uputnica izdaje:")]
        public Korisnik korisnik { get; }

        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Datum mora biti u prošlosti!")]
        [Display(Name = "Datum podnosenja:")]
        public DateTime datumPodnosenja { get; }
        
        
        public Uputnica(Korisnik korisnik, DateTime datumPodnosenja)
        {
            this.korisnik = korisnik;
            this.datumPodnosenja = datumPodnosenja;
        }

    }
}
