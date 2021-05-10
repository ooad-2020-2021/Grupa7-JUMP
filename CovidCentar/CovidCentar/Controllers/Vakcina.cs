
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
        public VakcinaEnum tip { get; }
        [Required]
        public int preostalo { get; set; }
        [Required]
        public int iskoristeno { get; set; }
        [Required]
        public String opis { get; }
        [Required]
        public static int brojAZ { get; }
        [Required]
        public static int brojPfizer { get; }
        [Required]
        public static int brojInstanciSputnikV { get; }
        [Required]
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
