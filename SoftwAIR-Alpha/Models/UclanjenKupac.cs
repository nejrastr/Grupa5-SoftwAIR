using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class UclanjenKupac : Kupac
    {
        public UclanjenKupac(int ID, String ime, String prezime, Boolean loyaltyClan, String email, String broj) : base(ID, ime, prezime, loyaltyClan, email, broj)
        { }
        public UclanjenKupac() { }
    }
}
