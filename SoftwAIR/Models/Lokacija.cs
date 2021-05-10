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
        public int ID { get; }
        [Required]
        public String grad { get; set; }
        public String aerodrom { get; set; }
        #endregion

        public Lokacija(int ID,String grad, String aerodrom)
        {
            this.ID = ID;
            this.grad = grad;
            this.aerodrom = aerodrom;
        }

        public void promijeniAerodrom(String aerodrom) { 
        //TODO
        }



    }
}
