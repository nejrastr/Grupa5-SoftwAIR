using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class Karta
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; } //ovo je generisan kod za kartu
        [Required]
        public Let polazniLet { get; }
        [Required]
        public Klasa klasa { get; }
        [Required]
        public double cijena { get; }
        public Let povratniLet { get; }
        #endregion

        public Karta(int ID, Let polazniLet, Klasa klasa, double cijena, Let povratniLet)
        {
            this.ID = ID;
            this.polazniLet = polazniLet;
            this.klasa = klasa;
            this.cijena = cijena;
            this.povratniLet = povratniLet;

        }
        public void IzaberiKlasu(Klasa klasa) { 
        //TODO
        }
        public void posaljiKartuNaMail(String mail) { 
        //TODO
        }
        public void generisiKod() { 
        //TODO
        }


        


    }
}
