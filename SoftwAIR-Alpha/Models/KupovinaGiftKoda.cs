using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class KupovinaGiftKoda : Kupovina
    {
        #region Properties
        [Required]
        public GiftKod giftkod { get; set; }
        #endregion

        #region Constructor
        public KupovinaGiftKoda(int ID, String statusKupovine, DateTime datumKupovine, int idKupca, GiftKod giftkod) : base(ID, statusKupovine, datumKupovine, idKupca) {
            this.giftkod = giftkod;
        }
        #endregion

        #region Methods
        public void DodajGiftKod(GiftKod giftKod)
        {
            //TODO
        }
        #endregion

    }
}
