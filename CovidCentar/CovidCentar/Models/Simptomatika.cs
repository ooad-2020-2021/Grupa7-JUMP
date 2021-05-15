using CovidCentar.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Simptomatika:Zahtjev
    {
        [Required]
        public List<SimptomEnum> uobicajeniSimptomi { get; }
        [Required]
        public String dodatniOpis { get; }
        [Required]
        public bool kontaktSaZarazenim { get; }
        [Required]
        public DateTime datum { get; }
        
        public Simptomatika(Korisnik korisnik, DateTime datum1, bool odobren,List<SimptomEnum> uobicajeniSimptomi, string dodatniOpis, bool kontaktSaZarazenim, DateTime datum):base(korisnik,datum1,odobren)
        {
            this.uobicajeniSimptomi = uobicajeniSimptomi;
            this.dodatniOpis = dodatniOpis;
            this.kontaktSaZarazenim = kontaktSaZarazenim;
            this.datum = datum;       
        }
    }
}
