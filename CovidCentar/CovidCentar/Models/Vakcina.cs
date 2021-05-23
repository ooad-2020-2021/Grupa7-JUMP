
using CovidCentar.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Vakcina
    {
        [Required]
        [EnumDataType(typeof(VakcinaEnum))]
        [Display(Name = "Tip vakcine:")]
        public VakcinaEnum tip { get; }
        [Required]
        [Display(Name = "Preostalo:")]
        public int preostalo { get; set; }
        [Required]
        [Display(Name = "Iskoristeno:")]
        public int iskoristeno { get; set; }
        [Required]
        [Display(Name = "Opis:")]
        public String opis { get; }
        [Required]
        [Display(Name = "Broj vakcina Astra Zeneca:")]
        public static int brojAZ { get; }
        [Required]
        [Display(Name = "Broj vakcina Pfizer:")]
        public static int brojPfizer { get; }
        [Required]
        [Display(Name = "Broj vakcina Sputnik V:")]
        public static int brojInstanciSputnikV { get; }
        [Required]
        [Display(Name = "Broj vakcina Sinopharm:")]
        public static int brojSinopharm { get; }

        public Vakcina(VakcinaEnum tip, int preostalo, int iskoristeno)
        {
            this.tip = tip;
            this.preostalo = preostalo;
            this.iskoristeno = iskoristeno;
        }

        public void dodajKolicinu(int kolicina)
        {
            preostalo += kolicina;
        }
    }
}
