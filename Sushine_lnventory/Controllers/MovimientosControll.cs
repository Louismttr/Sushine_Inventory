using Sushine_lnventory.Models;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sushine_lnventory.Controllers
{
    public class MovimientosControll
    {
        private Detalle_Movimiento modelo;
        Conectar con = new Conectar();

        public MovimientosControll()
        {
            modelo = new Detalle_Movimiento();

        }

        public void CargarMovimientos(DataGridView dgv)
        {
            try
            {
                DataTable dt = modelo.ListarMov(); // Obtiene los movimientos del modelo
                dgv.DataSource = dt; // Asigna los datos al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RegistrarMovimiento(String codProd, int codEmpleado, int tipoMov, int cantidad)
        {
            modelo.RegistrarMovimiento(codProd, codEmpleado, tipoMov, cantidad);
        }
        //Buscar
        public DataTable BuscarMovimientos(int? idDetMov)
        {
            if (idDetMov.HasValue && idDetMov > 0) // Verifica si hay un ID válido
            {
                return modelo.ObtenerMovimientoPorId(idDetMov);
            }
            else
            {
                // Si no hay ID, devuelve todos los movimientos
                return modelo.ListarMov();
            }
        }

        // Método para exportar a Excel
        public void ExportarMovimientosAExcel(DataTable movimientos, string rutaArchivo)
        {
            modelo.ExportarAExcel(movimientos, rutaArchivo);
        }

        // Filtrar movimientos por producto y/o empleado
        public DataTable FiltrarMovimientos(string producto, int? empleado)
        {
            return modelo.FiltrarMovimientos(producto, empleado);
        }
    }
}
