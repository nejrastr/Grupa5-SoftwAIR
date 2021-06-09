using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class GiftKod
    {
        #region Properties
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public String kod { get; set; }
        [Required]
        public Kupac kupac { get; set; }
        [Required]
        public String trenutniStatus { get; set; }
        #endregion

        #region Constructor
        public GiftKod(String kod, Kupac kupac, String trenutniStatus) {
            this.kod = kod;
            this.kupac = kupac;
            this.trenutniStatus = trenutniStatus;
        }
        public GiftKod() { }
        #endregion

        #region Methods

        public void promijeniValidnost(String status) {
            this.trenutniStatus = status;
        }
        public String dajValidnost()
        {
            return trenutniStatus;
        }
        #endregion

    }
}
