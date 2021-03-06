using System;
using System.Collections.Generic;

namespace IS_Turizmas.Models
{
    public partial class Reitingai
    {
        public int Reitingas { get; set; }
        public DateTime Data { get; set; }
        public int Id { get; set; }
        public int FkMarsrutas { get; set; }
        public int FkRegistruotasVartotojas { get; set; }

        public virtual Marsrutai FkMarsrutasNavigation { get; set; }
        public virtual RegistruotiVartotojai FkRegistruotasVartotojasNavigation { get; set; }
    }
}
