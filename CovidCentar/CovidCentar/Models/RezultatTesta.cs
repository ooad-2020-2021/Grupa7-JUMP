using CovidCentar.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{

    public class DatumIzProšlosti : RangeAttribute
    {
        public DatumIzProšlosti() : base(typeof(DateTime), DateTime.MinValue.ToString(), DateTime.Now.ToString())
        {
        }
    }

    public class RezultatTesta
    {
        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Datum testa mora biti u prošlosti!")]
        [Display(Name = "Datum testiranja:")]
        public DateTime datumTesta { get; }
        [Required]
        [EnumDataType(typeof(TestEnum))]
        [Display(Name = "Tip testa:")]
        public TestEnum tipTesta { get; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Vrijednost mora biti veća od 0!")]
        [Display(Name = "IgM:")]
        public double IgM { get; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Vrijednost mora biti veća od 0!")]
        [Display(Name = "IgG:")]
        public double IgG { get; }
        [Required]
        [Display(Name = "Napomena:")]
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
