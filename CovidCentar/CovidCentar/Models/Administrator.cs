using System;
using System.Collections.Generic;
using System.Text;

namespace CovidCentar.Models
{
    public class Administrator : Osoba
    {
        public Administrator(int iD, string ime, string prezime, string brojTelefon, string email, string sifra, char spol, string adresa) : base(iD, ime, prezime, brojTelefon, email, sifra, spol, adresa)
        {
        }
    }
}
