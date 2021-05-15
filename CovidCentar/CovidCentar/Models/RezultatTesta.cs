using CovidCentar.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class RezultatTesta
    {
        [Required]
        public DateTime datumTesta { get; }
        [Required]
        public TestEnum tipTesta { get; }
        [Required]
        public double IgM { get; }
        [Required]
        public double IgG { get; }
        [Required]
        public String napomena { get; }

        public RezultatTesta(DateTime datumTesta, TestEnum tipTesta, double igM, double igG, string napomena)
        {
            this.datumTesta = datumTesta;
            this.tipTesta = tipTesta;
            IgM = igM;
            IgG = igG;
            this.napomena = napomena;
        }
    }
}
