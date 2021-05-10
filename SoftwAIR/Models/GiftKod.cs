using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class GiftKod
    {
        #region Properties
        [Required]
        public String kod { get; set; }
        [Required]
        public Kupac kupac { get; set; }
        [Required]
        public String trenutniStatus { get; set; }
        #endregion

        public GiftKod(String kod, Kupac kupac, String trenutniStatus) {
            this.kod = kod;
            this.kupac = kupac;
            this.trenutniStatus = trenutniStatus;
        }

        public void promijeniValidnost(String status) { 
        //TODO
        }
        public String dajValidnost()
        {
            return trenutniStatus;
        }

    }
}
