using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SoftwAIR_Alpha.Models
{
    public class StatusLeta
    {
        public enum StatusLetaEnum
        {
            [Display(Name = "Neaktivan")]
            NEAKTIVAN,
            [Display(Name = "Check In")]
            CHECKIN,
            [Display(Name = "U Zraku")]
            UZRAKU
        }

        public StatusLetaEnum tipStatusaLeta { get; set; }

        public StatusLeta() { }
    }
}
