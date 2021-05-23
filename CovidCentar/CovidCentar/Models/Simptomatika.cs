using CovidCentar.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CovidCentar.Models
{

    public class Simptomatika:Zahtjev
    {
        [Required]
        [EnumDataType(typeof(SimptomEnum))]
        [NotMapped]
        [Display(Name = "Uobicajeni simptomi:")]
        public List<SimptomEnum> uobicajeniSimptomi { get; }
        [Required]
        [Display(Name = "Dodatni opis:")]
        public String dodatniOpis { get; }
        [Required]
        [Display(Name = "Kontakt sa zarazenim:")]
        public bool kontaktSaZarazenim { get; }
        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Datum mora biti u prošlosti!")]
        [Display(Name = "Datum:")]
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
