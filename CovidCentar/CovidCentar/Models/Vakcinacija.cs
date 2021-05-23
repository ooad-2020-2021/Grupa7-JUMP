using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Vakcinacija
    {
        [Required]
        [Display(Name = "Vakcina:")]
        public Vakcina vakcina { get; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Termin prve doze:")]
        public DateTime terminPrveDoze { get; }
        [Required]
        [Display(Name = "Primljena prve doze:")]
        public bool prvaDoza { get; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Termin druge doze:")]
        public DateTime terminDrugeDoze { get; }
        [Required]
        [Display(Name = "Primljena druga doze:")]
        public bool drugaDoza { get; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "Morate unijeti barem 1 karakter!")]
        [Display(Name = "Lokacija:")]
        public String lokacija { get; }

        public Vakcinacija(Vakcina vakcina, DateTime terminPrveDoze, bool prvaDoza, DateTime terminDrugeDoze, bool drugaDoza, string lokacija)
        {
            this.vakcina = vakcina;
            this.terminPrveDoze = terminPrveDoze;
            this.prvaDoza = prvaDoza;
            this.terminDrugeDoze = terminDrugeDoze;
            this.drugaDoza = drugaDoza;
            this.lokacija = lokacija;
        }
    }
}
