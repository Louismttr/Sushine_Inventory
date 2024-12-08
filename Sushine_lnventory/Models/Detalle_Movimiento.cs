using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Sushine_lnventory.Models
{
    public class Detalle_Movimiento
    {

        public int IdDetMov { get; set; }
        public char CodProducto { get; set; }
        public int CodEmpleado { get; set; }
        public int CodTipoMovimiento { get; set; }
        public int CantidadDetMov { get; set; }

        public Detalle_Movimiento()
        {

        }

        public Detalle_Movimiento(int idDetMov, char codProducto, int codEmpleado, int codTipoMovimiento, int cantidadDetMov)
        {
            IdDetMov = idDetMov;
            CodProducto = codProducto;
            CodEmpleado = codEmpleado;
            CodTipoMovimiento = codTipoMovimiento;
            CantidadDetMov = cantidadDetMov;
        }

        //Listar Mov
        public DataTable ListarMov()
        {
            string query = "ListarDetMov"; // Procedimiento almacenado

            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                return dt;
            }
        }

        public void RegistrarMovimiento(string codProd, int codEmpleado, int tipoMov, int cantidad)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(connectionString))
            {
                try
                {
                    conector.Open();

                    // Configuración del comando para el procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand("InsertarDetalleMov", conector))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@Cod_Prod", codProd);
                        cmd.Parameters.AddWithValue("@CodEmpleado", codEmpleado);
                        cmd.Parameters.AddWithValue("@TipoMov", tipoMov);
                        cmd.Parameters.AddWithValue("@CantidadDetMov", cantidad);

                        // Ejecutar el procedimiento almacenado
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si el procedimiento fue exitoso
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Movimiento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se afectaron filas. Verifica los datos enviados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de SQL al registrar el movimiento: {sqlEx.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el movimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    if (conector.State == ConnectionState.Open)
                    {
                        conector.Close();
                    }

                }

            }

        }
        //Buscar
        public DataTable ObtenerMovimientoPorId(int? idDetMov)
        {
            string query = @"ObtenerMovId"; // Nombre del procedimiento almacenado
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (idDetMov.HasValue) // Si el ID tiene valor, agregar el parámetro
                {
                    cmd.Parameters.AddWithValue("@IdDetMov", idDetMov.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        // Obtener movimientos filtrados
        public DataTable FiltrarMovimientos(string producto, int? empleado)
        {
            string query = "SELECT dm.FechaMov as Fecha, p.CodProducto as Producto, p.CostoUnitario as CostoUnitario, " +
                           "p.PrecioVenta as PrecioVenta, dm.CantidadDetMov as Cantidad, dm.CodEmpleado as Empleado " +
                           "FROM DetalleMov dm INNER JOIN Producto p ON dm.Cod_Prod = p.CodProducto";

            if (!string.IsNullOrEmpty(producto))
                query += " AND Cod_Prod = @Cod_Prod";
            if (empleado.HasValue)
                query += " AND CodEmpleado = @CodEmpleado";

            // Configuración de conexión
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (!string.IsNullOrEmpty(producto))
                    cmd.Parameters.AddWithValue("@Cod_Prod", producto);

                if (empleado.HasValue)
                    cmd.Parameters.AddWithValue("@CodEmpleado", empleado.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable resultados = new DataTable();
                adapter.Fill(resultados);
                return resultados;
            }
        }

        // Exportar datos a Excel
        public void ExportarAExcel(DataTable movimientos, string rutaArchivo)
        {
            using (var package = new OfficeOpenXml.ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("DetalleMov");

                // Encabezados
                for (int i = 0; i < movimientos.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = movimientos.Columns[i].ColumnName;
                }

                // Datos
                for (int i = 0; i < movimientos.Rows.Count; i++)
                {
                    for (int j = 0; j < movimientos.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = movimientos.Rows[i][j];
                    }
                }

                // Guardar archivo
                FileInfo archivo = new FileInfo(rutaArchivo);
                package.SaveAs(archivo);
            }
        }

    }
}
