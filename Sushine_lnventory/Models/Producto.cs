using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushine_lnventory.Models
{
    public class Producto
    {
        #region Connection String
        private readonly string _connectionString;

        public Producto(string connectionString)
        {
            _connectionString = connectionString;
        }
        #endregion

        public char Cod_Pd { get; set; }
        public string Nombre_Pd { get; set; }
        public string Descripcion_Pd { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PercioVenta { get; set; }
        public byte Estado_ { get; set; }
        public Categoria Cod_Categoria { get; set; } // Agregación

       

    }
}
