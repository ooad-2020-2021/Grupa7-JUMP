using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Enums
{
    public enum VakcinaEnum
    {
        [Display(Name = "AstraZeneca")]
        AstraZeneca,
        [Display(Name = "Pfizer")]
        Pfizer,
        [Display(Name = "SputnikV")]
        SputnikV,
        [Display(Name = "Sinopharm")]
        Sinopharm
    }
}
