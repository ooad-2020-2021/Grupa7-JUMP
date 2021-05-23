using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{

    public class Statistika
    {
        
        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Datum ne može biti u budućnosti!")]
        [Display(Name = "Datum:")]
        public DateTime datum { get; }
        [Required]
        [Display(Name = "Broj novozarazenih:")]
        public int novozarazeni { get; set; }

        [Required]
        [Display(Name = "Broj oporavljenih:")]
        public int oporavljeni { get; set; }

        [Required]
        [Display(Name = "Broj umrlih:")]
        public int umrli { get; set; }

        [Required]
        [Display(Name = "Broj testiranih:")]
        public int testirani { get; set; }

        [Required]
        [Display(Name = "Ukupni broj zarazenih:")]
        public int zarazeniTotal { get; set; }

        [Required]
        [Display(Name = "Ukupni broj oporavljenih:")]
        public int oporavljeniTotal { get; set; }

        [Required]
        [Display(Name = "Ukupni broj umrlih:")]
        public int umrliTotal { get; set; }

        [Required]
        [Display(Name = "Ukupni broj testiranih:")]
        public int testiraniTotal { get; set; }

        public void presjekStanja()
        {
            novozarazeni = 0;
            oporavljeni = 0;
            umrli = 0;
            testirani = 0;
        }

        public void dodajTest(bool zarazen)
        {
            if (zarazen)
            {
                testiraniTotal++;
            }
            else
            {
                oporavljeniTotal++;
            }
        }

        public void dodajUmrlog()
        {
            umrliTotal++;
        }

    }
}
