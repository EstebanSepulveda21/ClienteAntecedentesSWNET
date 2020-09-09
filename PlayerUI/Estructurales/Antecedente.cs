using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI.Estructurales
{
    public class Antecedente
    {
        public Antecedente() { }

        public int id { get; set; }

        public string ciudadanoDI { get; set; }

        public string ciudad { get; set; }

        public DateTime fechaDelito { get; set; }

        public int sentencia { get; set; }

        public string estado { get; set; }
    }
}
