using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Doktor:Osoba
    {
        [Required]
        public List<Zahtjev> zahtjevi { get; }

        public Doktor(List<Zahtjev> zahtjevi, int iD, string ime, string prezime, List<string> brojTelefon, string email, char spol, string adresa):base(iD, ime, prezime, brojTelefon, email, spol, adresa)
        {
            this.zahtjevi = zahtjevi;
        }

        public Uputnica izdajUputnicu(Korisnik korisnik)
        {
            return new Uputnica(korisnik, DateTime.Now);
        }

        public String odbijTest(Zahtjev zahtjev)
        {
            zahtjev.odobren = false;
            return "Zahtjev je odbijen";
        }

        public RezultatTesta kreirajRezultat()
        {
            //TODO
            return null;
        }

    }
}
