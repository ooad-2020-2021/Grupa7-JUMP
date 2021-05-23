using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Zahtjev
    {
        [Required]
        [Display(Name = "Korisnik koji podnosi zahtjev:")]
        public Korisnik korisnik { get; }
        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Datum mora biti u prošlosti!")]
        [Display(Name = "Datum podnosenja zahtjeva:")]
        public DateTime datum { get; }
        [Required]
        [Display(Name = "Odobren:")]
        public bool odobren { get; set; }

        public Zahtjev(Korisnik korisnik, DateTime datum, bool odobren)
        {
            this.korisnik = korisnik;
            this.datum = datum;
            this.odobren = odobren;
        }
    }
}
