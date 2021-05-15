using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Vakcinacija
    {
        [Required]
        public Vakcina vakcina { get; }
        [Required]
        public DateTime terminPrveDoze { get; }
        [Required]
        public bool prvaDoza { get; }
        [Required]
        public DateTime terminDrugeDoze { get; }
        [Required]
        public bool drugaDoza { get; }
        [Required]
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
