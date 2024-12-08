using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushine_lnventory.Models
{
    public class Conectar
    {

        public void ListarMo(DataGridView data)
        {

            var constring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(constring))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = new SqlCommand("ListarDetMov", conector);
                    DataTable dataTable = new DataTable();
                    conector.Open();
                    dataAdapter.Fill(dataTable);
                    data.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        public void ListarProDGV(string storedProcedure, DataGridView dataGridView)
        {
            // Obtener la cadena de conexión desde el archivo de configuración
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Configurar el SqlDataAdapter con el procedimiento almacenado proporcionado
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(storedProcedure, connection))
                    {
                        dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                        // Crear el DataTable para llenar los datos
                        DataTable dataTable = new DataTable();

                        // Abrir conexión y llenar el DataTable
                        connection.Open();
                        dataAdapter.Fill(dataTable);

                        // Asignar los datos al DataGridView proporcionado
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones mostrando un mensaje de error
                    MessageBox.Show($"Error al listar movimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //ComboBox, por Codigos
        public void CodCmbB(ComboBox comboBox, string tabla, string columna)
        {
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox), "El ComboBox no está inicializado.");
            if (string.IsNullOrEmpty(tabla) || string.IsNullOrEmpty(columna))
                throw new ArgumentException("El nombre de la tabla o columna no puede estar vacío.");

            var constring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(constring))
            {
                try
                {
                    conector.Open();
                    string query = $"SELECT {columna} FROM {tabla}";

                    using (SqlCommand cmd = new SqlCommand(query, conector))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    comboBox.Items.Add(reader[columna].ToString());
                                }
                            }
                        }
                    }

                    if (comboBox.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos para cargar en el ComboBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de SQL: {sqlEx.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos en el ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Rellenar CostoUnitario
        public void RellenarCostoUnitario(ComboBox comboBox, TextBox textBox)
        {
            if (comboBox.SelectedItem == null)
            {
                textBox.Text = string.Empty; // Limpiar el campo si no hay selección
                return;
            }

            var constring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(constring))
            {
                try
                {
                    conector.Open();
                    string query = "SELECT CostoUnitario FROM Producto WHERE CodProducto = @CodProducto";
                    using (SqlCommand cmd = new SqlCommand(query, conector))
                    {
                        cmd.Parameters.AddWithValue("@CodProducto", comboBox.SelectedItem.ToString());

                        var result = cmd.ExecuteScalar();
                        textBox.Text = result != null ? result.ToString() : "No encontrado";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el costo unitario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
