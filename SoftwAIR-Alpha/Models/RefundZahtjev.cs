using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class RefundZahtjev
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime vrijemePodnosenja { get; set; }
        [Required]
        public String statusZahtjeva { get; set; }
        [Required]
        public Kupac kupac { get; set; }
        [Required]
        public Kupovina kupovina { get; set; }
        #endregion

        #region Constructor
        public RefundZahtjev(int id, DateTime vrijemePodnosenja, String statusZahtjeva, Kupac kupac, Kupovina kupovina)
        {
            this.ID = id;
            this.vrijemePodnosenja = vrijemePodnosenja;
            this.statusZahtjeva = statusZahtjeva;
            this.kupac = kupac;
            this.kupovina = kupovina;
        }
        public RefundZahtjev() { }
        #endregion

        #region Methods

        public void odobri()
        {
            //TODO
        }
        public void odbij()
        {
            //TODO
        }
        #endregion
    }
}
