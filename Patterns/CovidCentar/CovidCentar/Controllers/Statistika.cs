using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Statistika
    {
        
        [Required]
        public DateTime datum { get; }
        [Required]
        public int novozarazeni { get; set; }

        [Required]
        public int oporavljeni { get; set; }

        [Required]
        public int umrli { get; set; }

        [Required]
        public int testirani { get; set; }

        [Required]
        public int zarazeniTotal { get; set; }

        [Required]
        public int oporavljeniTotal { get; set; }

        [Required]
        public int umrliTotal { get; set; }

        [Required]
        public int testiraniTotal { get; set; }

        public void presjekStanja()
        {
            //TODO
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
