using CovidCentar.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Korisnik:Osoba
    {
        [Required]
        [Display(Name = "Punoljetan:")]
        public bool punoljetan { get; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 8, ErrorMessage = "Morate unijeti barem 8 karaktera!")]
        [Display(Name = "Broj knjizice:")]
        public String brojKnjizice { get; }
        [Required]
        [Display(Name = "Uplatnica:")]
        public Uputnica uputnica { get; }
        [Required]
        [Display(Name = "Karton:")]
        public Karton karton { get; }

        public Korisnik(int iD, string ime, string prezime, string brojTelefon, string email, string sifra, char spol, string adresa,bool punoljetan, string brojKnjizice, Uputnica uputnica, Karton karton):base(iD, ime, prezime, brojTelefon, email, sifra, spol, adresa)
        {
            this.punoljetan = punoljetan;
            this.brojKnjizice = brojKnjizice;
            this.uputnica = uputnica;
            this.karton = karton;
        }

        public Simptomatika odaberiSimptome(Korisnik korisnik, DateTime datum1, bool odobren, List<SimptomEnum> uobicajeniSimptomi, string dodatniOpis, bool kontaktSaZarazenim, DateTime datum)
        {
            return new Simptomatika(korisnik, datum1, odobren, uobicajeniSimptomi, dodatniOpis, kontaktSaZarazenim, datum);
        }

        public ZahtjevZaVakcinu zahtjevZaVakcinaciju(DateTime datum,bool odobren,DateTime termin)
        {
            return new ZahtjevZaVakcinu(this, datum, odobren, termin);
        }
    }
}
