using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class Lokacija
    {
        #region Properties  
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public String grad { get; set; }
        [Required]
        public String aerodrom { get; set; }
        #endregion

        #region Constructor
        public Lokacija(int ID,String grad, String aerodrom)
        {
            this.ID = ID;
            this.grad = grad;
            this.aerodrom = aerodrom;
        }
        public Lokacija() { }
        #endregion

        #region Methods
        public void promijeniAerodrom(String aerodrom) {
            this.aerodrom = aerodrom; //Moramo li i u bazi mijenjati
        }
        #endregion

    }
}
