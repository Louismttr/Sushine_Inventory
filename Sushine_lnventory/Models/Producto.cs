using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
        public Categoria Cod_Categoria { get; set; } // Agregación

        public Producto(char cod_Pd, string nombre_Pd, string descripcion_Pd, decimal costoUnitario, decimal percioVenta, byte estado_, Categoria cod_Categoria)
        {
            Cod_Pd = cod_Pd;
            Nombre_Pd = nombre_Pd;
            Descripcion_Pd = descripcion_Pd;
            CostoUnitario = costoUnitario;
            PercioVenta = percioVenta;
            Estado_ = estado_;
            Cod_Categoria = cod_Categoria;
        }

        public Producto()
        {

        }
        // Método para obtener los códigos de producto
        public static List<string> ObtenerCodigosProducto()
        {
            var listaCodigos = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(connectionString))
            {
                string query = "SELECT CodProducto FROM Producto WHERE Estado = 1";

                SqlCommand cmd = new SqlCommand(query, conector);

                try
                {
                    conector.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaCodigos.Add(reader["CodProducto"].ToString().Trim());
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    System.Windows.Forms.MessageBox.Show($"Error al obtener códigos de producto: {ex.Message}");
                }
            }

            return listaCodigos;
        }
        //Listar en DGV
        public DataTable ListarPro()
        {
            string query = "ListarProducto"; // Procedimiento almacenado

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

        //Registrar Producto

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public void InsertarProducto(string codPro, string nombreProducto, decimal costoUnitario, decimal precioVenta, int codCategoria)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertarProducto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodPro", codPro);
                        cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                        cmd.Parameters.AddWithValue("@CostoUnitario", costoUnitario);
                        cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                        cmd.Parameters.AddWithValue("@Cod_Categoria", codCategoria);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el producto. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }

                }
            }
        }
        public DataTable ObtenerProductoPorId(string idPro)
        {
            const string query = "ObtDetProducto"; // Nombre del procedimiento almacenado
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro solo si se proporciona un ID
                if (!string.IsNullOrWhiteSpace(idPro))
                {
                    cmd.Parameters.AddWithValue("@CodP", idPro);
                }
                else
                {
                    throw new ArgumentException("El parámetro 'idPro' no puede estar vacío.", nameof(idPro));
                }

                // Ejecutar el comando y llenar el DataTable
                var dt = new DataTable();
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo eficiente de errores
                    throw new Exception($"Error al obtener el producto: {ex.Message}", ex);
                }

                return dt;
            }
        }
    }
}
