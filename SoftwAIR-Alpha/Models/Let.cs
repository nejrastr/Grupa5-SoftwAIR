using SoftwAIR_Alpha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class Let
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; } 

        [Required]
        public Lokacija polazak { get; set; } 

        [Required]
        public Lokacija dolazak { get; set; }

        [Required]
        public Avion avion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime vrijemePolaska { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime vrijemeDolaska { get; set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Vrijednost mora biti veca od 0!" )]
        public Double osnovnaCijena { get; set; }

        [Required]
        public Boolean naPopustuZaLoyalty { get; set; }

        [Required]
        [EnumDataType(typeof(EnumStatusLeta))]
        public EnumStatusLeta statusLeta { get; set; }
        #endregion

        #region Constructor
        public Let(int ID, Lokacija polazak, Lokacija dolazak, Avion avion, DateTime vrijemePolaska, DateTime vrijemeDolaska, Double osnovnaCijena, Boolean naPopustuZaLoyalty, EnumStatusLeta statusLeta)
        {
            this.ID = ID;
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
        public void promjeniStatus(EnumStatusLeta status) 
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
