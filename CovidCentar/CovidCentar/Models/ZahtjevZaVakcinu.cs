using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class ZahtjevZaVakcinu:Zahtjev
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Datum termina vakcinacije:")]
        public DateTime datumTermina { get; set; }

        public ZahtjevZaVakcinu(Korisnik korisnik, DateTime datum, bool odobren,DateTime datumTermina):base(korisnik,datum,odobren)
        {
            this.datumTermina = datumTermina;
        }
    }
}
