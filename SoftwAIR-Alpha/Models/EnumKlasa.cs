using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SoftwAIR_Alpha.Models
{
        public enum EnumKlasa
        {
            [Display(Name = "Biznis")]
            BIZNIS,
            [Display(Name = "Prva")]
            PRVA,
            [Display(Name = "Ekonomska")]
            EKONOMSKA
        }      
    
}
