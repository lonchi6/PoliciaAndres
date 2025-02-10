using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policia.Models
{
    class Ciudadano
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string VigorCarnet { get; set; } // 'caducado' o 'en regla'
        public DateTime FechaExpiracion { get; set; }
        public int PuntosCarnet { get; set; }
    }
}
