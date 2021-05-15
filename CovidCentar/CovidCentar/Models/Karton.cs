using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Models
{
    public class Karton
    {
        
        [Required]
        public List<Vakcinacija> vakcine { get; }
        [Required]
        public List<Simptomatika> simptomi { get; }
        [Required]
        public List<RezultatTesta> testovi { get; }
        
        public Karton(List<Vakcinacija> vakcine, List<Simptomatika> simptomi, List<RezultatTesta> testovi)
        {
            this.vakcine = vakcine;
            this.simptomi = simptomi;
            this.testovi = testovi;
        }
        
        public void dodajVakcinu(Vakcinacija vakcina)
        {
            vakcine.Add(vakcina);
        }

        public void dodajSimptomatiku(Simptomatika simptom)
        {
            simptomi.Add(simptom);
        }

        public void dodajTest(RezultatTesta test)
        {
            testovi.Add(test);
        }

    }
}
