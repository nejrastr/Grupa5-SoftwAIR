using SoftwAIR_Alpha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public class Let
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; } //ne bi mogli biti u mogucnosti kroz app mijenjati ID leta, jer cemo ga dodavati kroz bazu ?
        [Required]
        public int kodZaStatusLeta { get; } //moze li ovo biti samo ID;
        [Required]
        public Lokacija polazak { get; } // sve osim naPopustuLoyalty i statusLeta ce se moci samo citati iz baze. Ako zelimo promijeniti moramo mijenjati bazu.
        [Required]
        public Lokacija dolazak { get; }
        [Required]
        public Avion avion { get; }
        public DateTime vrijemePolaska { get; }
        public DateTime vrijemeDolaska { get; }
        public Double osnovnaCijena { get; }
        public Boolean naPopustuZaLoyalty { get; set; }
        public StatusLeta statusLeta { get; set; }
        #endregion

        #region Constructor
        public Let(int ID, int kodZaStatusLeta, Lokacija polazak, Lokacija dolazak, Avion avion, DateTime vrijemePolaska, DateTime vrijemeDolaska, Double osnovnaCijena, Boolean naPopustuZaLoyalty, StatusLeta statusLeta)
        {
            this.ID = ID;
            this.kodZaStatusLeta = kodZaStatusLeta;
            this.polazak = polazak;
            this.dolazak = dolazak;
            this.avion = avion;
            this.vrijemePolaska = vrijemePolaska;
            this.vrijemeDolaska = vrijemeDolaska;
            this.osnovnaCijena = osnovnaCijena;
            this.naPopustuZaLoyalty = naPopustuZaLoyalty;
            this.statusLeta = statusLeta;
        }

        public Let() { }
        #endregion

        #region Methods
        public void promjeniStatus(StatusLeta status) 
        {
            statusLeta = status;
        }
        public double dajTrajanje()
        {
            return 0;
            //TODO
        }
        public void zavediKupljeneKarte(Kupovina kupovina)
        { 
            //TODO
        }
        #endregion

    }
}
