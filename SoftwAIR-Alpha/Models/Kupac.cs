﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class Kupac
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public String ime { get; set; }
        [Required]
        public String prezime { get; set; }
        [Required]
        public Boolean loyaltyClan { get; set; }
        [Required]
        [EmailAddress]
        public String email { get; set; }
        [Required]
        [Phone]
        public String broj { get; set; }
        #endregion

        #region Constructor
        public Kupac(int ID, String ime, String prezime, Boolean loyaltyClan, String email, String broj) {
            this.ID = ID;
            this.ime = ime;
            this.prezime = prezime;
            this.loyaltyClan = loyaltyClan;
            this.email = email;
            this.broj = broj;
        }
        public Kupac() { }
        #endregion

        public void zavediNarudzbu(Kupovina kupovina) {
            //TODO
        }

        public void uclaniSeULoyalty() { 
            //TODO
        }

    }
}
