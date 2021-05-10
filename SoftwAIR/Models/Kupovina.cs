using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR.Models
{
    public abstract class Kupovina
    {
        public String statusKupovine;
        public int idKupovine;
        public DateTime datumKupovine;
        public int idKupca;

        public abstract void postaviStatus(String status);
        public abstract void odustani();
    }
}
