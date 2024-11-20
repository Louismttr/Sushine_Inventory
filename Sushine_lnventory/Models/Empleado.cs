using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Empleado : Persona
    {
        public int Id { get; set; }
        public int EstadoEmpleado { get; set; }
        public DateTime FechaCont { get; set; }
        public Puesto Puesto { get; set; } // Composición

    }
}
