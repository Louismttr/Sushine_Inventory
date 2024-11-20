using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Detalle_Movimiento
    {
        public int IdDetMov { get; set; } // Clave primaria
        public string Cod_Prod { get; set; } // Clave foránea hacia Producto
        public int CodEmpleado { get; set; } // Clave foránea hacia Empleado
        public int TipoMov { get; set; } // Clave foránea hacia TipoMovimiento
        public DateTime FechaMov { get; set; } // Fecha del movimiento
        public int CantidadDetMov { get; set; } // Cantidad del movimiento

        
        public Producto Producto { get; set; }
        public Empleado Empleado { get; set; }
        public Tipo_Movimiento TipoMovimiento { get; set; }
    }
}
