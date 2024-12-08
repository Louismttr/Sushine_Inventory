using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

    }
}
