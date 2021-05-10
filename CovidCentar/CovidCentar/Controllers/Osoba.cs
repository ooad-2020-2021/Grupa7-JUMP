using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Osoba
    {
        
        [Required]
        [Key]
        public int ID { get; }
        [Required]
        public String ime { get; }
        [Required]
        public String prezime { get; }
        [Required]
        public List<String> brojTelefon { get; }
        [Required]
        public String email { get; }
        [Required]
        public char spol { get; }
        [Required]
        public String adresa { get; }

        public Osoba(int iD, string ime, string prezime, List<string> brojTelefon, string email, char spol, string adresa)
        {
            ID = iD;
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefon = brojTelefon;
            this.email = email;
            this.spol = spol;
            this.adresa = adresa;
        }

        public void dodajBrojTelefona(String broj)
        {
            brojTelefon.Add(broj);
        }
        public void izbrisiBrojTelefona(String broj)
        {
            if (brojTelefon.Contains(broj)){
                brojTelefon.Remove(broj);
            }
            
        }


    }




}
