
using System;

namespace Sushine_lnventory.Models
{
    public class Movimiento
    {
            public int Id { get; set; }
            public string Tipo { get; set; }
            public char CodProducto { get; set; }
            public int Cantidad { get; set; }
            public DateTime Fecha { get; set; }
    }
}
