using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class Karta
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; } //ovo je generisan kod za kartu
        [Required]
        public Let polazniLet { get; set; }
        [Required]
        public EnumKlasa klasa { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Vrijednost mora biti veca od 0!")]
        public double cijena { get; set; }
        public Let povratniLet { get; set; }
        #endregion

        #region Constructor
        public Karta(int ID, Let polazniLet, EnumKlasa klasa, double cijena, Let povratniLet)
        {
            this.ID = ID;
            this.polazniLet = polazniLet;
            this.klasa = klasa;
            this.cijena = cijena;
            this.povratniLet = povratniLet;

        }
        public Karta() { }
        #endregion

        #region Methods
        public void IzaberiKlasu(EnumKlasa klasa) {
            this.klasa = klasa;
        }
        public void posaljiKartuNaMail(String mail) { 
        //TODO
        }
        public void generisiKod() { 
        //TODO
        }
        public Karta clone()
        {
            return this;
        }
        #endregion

    }
}
