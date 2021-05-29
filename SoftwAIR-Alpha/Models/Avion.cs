using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class Avion
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [Range(0,1000, ErrorMessage = "Broj slobodnih mjesta mora biti pozitivan")]
        public int brojMjestaPrva { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = "Broj slobodnih mjesta mora biti pozitivan")]
        public int brojMjestaBiznis { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = "Broj slobodnih mjesta mora biti pozitivan")]
        public int brojMjestaEconomy { get; set; }
        

        #endregion

        #region Constructors
        public Avion(int ID, int brojMjestaPrva, int brojMjestaBiznis, int brojMjestaEconomy)
        {
            this.ID = ID;
            this.brojMjestaPrva = brojMjestaPrva;
            this.brojMjestaBiznis = brojMjestaBiznis;
            this.brojMjestaEconomy = brojMjestaEconomy;
            
        }
        public Avion() { }
        #endregion

        #region Methods
        public int SlobodnihMjestaUkupno() {
            return brojMjestaBiznis + brojMjestaEconomy + brojMjestaPrva;
        }

        public Boolean JeLiRaspolozivo(Kupovina kupovina)
        {
            //TODO
            return true;
        }
        #endregion
    }
}
