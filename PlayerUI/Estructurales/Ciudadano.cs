using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI.Estructurales
{
    public class Ciudadano
    {
        public  Ciudadano(){}

        public int tipoDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public bool genero { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
