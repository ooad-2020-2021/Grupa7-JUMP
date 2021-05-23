using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Enums
{
    public enum TestEnum
    {
        [Display(Name = "PCR")]
        PCR,
        [Display(Name = "Antitijela")]
        Antitijela,
        [Display(Name = "Seroloski")]
        Seroloski
    }
}
