using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public string CorreoElectronico { get; set; }
        public string Pass { get; set; }
        public string RolUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Empleado codempleado { get; set; } // :D momento Ramdon de la Luisa

    }
}
