using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class Avion
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; }
        [Required]
        public int brojMjestaPrva { get; }
        [Required]
        public int brojMjestaBiznis { get; }
        [Required]
        public int brojMjestaEconomy { get; }
        #endregion

        #region Constructors
        public Avion(int ID, int brojMjestaPrva, int brojMjestaBiznis, int brojMjestaEconomy)
        {
            this.ID = ID;
            this.brojMjestaPrva = brojMjestaPrva;
            this.brojMjestaBiznis = brojMjestaBiznis;
            this.brojMjestaEconomy = brojMjestaEconomy;
        }
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
