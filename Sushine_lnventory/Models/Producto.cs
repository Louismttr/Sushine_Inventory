using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Producto
    {
        public char Cod_Pd { get; set; }
        public string Nombre_Pd { get; set; }
        public string Descripcion_Pd { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PercioVenta { get; set; }
        public byte Estado_ { get; set; }
        public Categoria Cod_Categoria { get; set; }
    }
}
