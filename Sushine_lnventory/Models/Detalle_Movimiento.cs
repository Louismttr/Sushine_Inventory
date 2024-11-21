using System;
using System.Data;
using System.Data.SqlClient;

namespace Sushine_lnventory.Models
{
    public class Detalle_Movimiento
    {
        #region Connection String
            private readonly string _connectionString;

        public Detalle_Movimiento(string connectionString)
        {
            _connectionString = connectionString;
        }
        #endregion

        public int IdDetMov { get; set; }
        public Producto CodProducto { get; set; }
        public Empleado CodEmpleado { get; set; }
        public Tipo_Movimiento CodTipoMovimiento { get; set; }
        public DateTime FechaMov { get; set; } 
        public int CantidadDetMov { get; set; }

        public string RegistrarMovimiento(char codProducto, int codEmpleado, int tipoMovimiento, byte cantidad)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open(); // No sé si es necesario ponerlo aquí... es que no me acuerdo :ccccc

                    using (SqlCommand cmd = new SqlCommand("InsertarDetalleMov", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros al procedimiento almacenado
                        cmd.Parameters.AddWithValue("@Cod_Prod", codProducto);
                        cmd.Parameters.AddWithValue("@CodEmpleado", codEmpleado);
                        cmd.Parameters.AddWithValue("@TipoMov", tipoMovimiento);
                        cmd.Parameters.AddWithValue("@CantidadDetMov", cantidad);

                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        // Aquí va el close.connection?
                    }

                    return "Movimiento registrado exitosamente.";
                }
            }
            catch (SqlException ex)
            {
                // Manejar errores de SQL
                return $"Error al registrar el movimiento: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Manejar errores generales
                return $"Error inesperado: {ex.Message}";
            }
        }
    }




}
