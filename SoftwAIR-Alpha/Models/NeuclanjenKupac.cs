using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwAIR_Alpha.Models
{
    public class NeuclanjenKupac : Kupac
    {
        public NeuclanjenKupac(int ID, String ime, String prezime, Boolean loyaltyClan, String email, String broj) : base (ID,ime,prezime,loyaltyClan,email,broj)
        { }
        public NeuclanjenKupac() { }
    }
}
