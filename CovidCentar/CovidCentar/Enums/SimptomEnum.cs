using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CovidCentar.Enums
{
    public enum SimptomEnum
    {
        [Display(Name = "temperatura")]
        temperatura,
        [Display(Name = "kasalj")]
        kasalj,
        [Display(Name = "gubitak_cula_mirisa")]
        gubitak_cula_mirisa,
        [Display(Name = "gubitak_cula_okusa")]
        gubitak_cula_okusa,
        [Display(Name = "umor_i_iscrpljenost")]
        umor_i_iscrpljenost,
        [Display(Name = "glavobolja")]
        glavobolja,
        [Display(Name = "mucnina")]
        mucnina,
        [Display(Name = "otezano_disanje")]
        otezano_disanje
    }
}
