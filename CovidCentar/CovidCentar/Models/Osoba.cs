using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CovidCentar.Models
{
    public class Osoba
    {
        
        [Required]
        [Key]
        [Range(1, int.MaxValue, ErrorMessage = "ID mora biti pozivitan broj!")]
        [Display(Name = "ID:")]
        public int ID { get; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "Morate unijeti barem 1 karakter!")]
        [Display(Name = "Ime:")]
        public String ime { get; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "Morate unijeti barem 1 karakter!")]
        [Display(Name = "Prezime:")]
        public String prezime { get; }
        [Required]
        [NotMapped]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "Morate unijeti barem 1 karakter!")]
        [Display(Name = "Broj telefona:")]
        public String brojTelefon { get; set;}
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "Morate unijeti barem 1 karakter!")]
        [Display(Name = "Email:")]
        public String email { get; }
        [Required]
        [RegularExpression(@"/(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}",ErrorMessage = "Sifra mora da sadrži bar jedno malo slovo, jedno veliko slovo i jedan broj, te da bude duža od 8 karaktera")]
        [Display(Name = "Sifra:")]
        public String sifra { get; }
        [Required]
        [Display(Name = "Spol:")]
        public char spol { get; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "Morate unijeti barem 1 karakter!")]
        [Display(Name = "Adresa:")]
        public String adresa { get; }

        public Osoba(int iD, string ime, string prezime, string brojTelefon, string email, string sifra, char spol, string adresa)
        {
            ID = iD;
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefon = brojTelefon;
            this.email = email;
            this.sifra = sifra;
            this.spol = spol;
            this.adresa = adresa;
        }

        public void izmijeniBrojTelefona(String broj)
        {
            brojTelefon = broj;
        }
       
    }




}
