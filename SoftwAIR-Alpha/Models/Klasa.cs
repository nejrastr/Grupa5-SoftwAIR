using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SoftwAIR.Models
{
    public class Klasa
    {
        public enum KlasaEnum
        {
            [Display(Name = "Biznis")]
            BIZNIS,
            [Display(Name = "Prva")]
            PRVA,
            [Display(Name = "Ekonomska")]
            EKONOMSKA
        }

        public KlasaEnum tipKlase { get; set; }

        public Klasa() { }
    }
}
