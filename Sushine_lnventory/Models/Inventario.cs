using System;

namespace Sushine_lnventory.Models
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public Producto CodProducto { get; set; }
        public int Cantidad { get; set; }
        public Detalle_Movimiento CodDetalleMovimiento { get; set; }

    }
}
