using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Sushine_lnventory.Models
{
    public class Empleado : Persona
    {

        public int Id { get; set; }
        public int EstadoEmpleado { get; set; }
        public DateTime FechaCont { get; set; }
        public Puesto Puesto { get; set; } // Composición


        public Empleado(char cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, char celular, char sexo,
        int id, int estadoEmpleado, DateTime fechacont) :
            base(cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, celular, sexo)
        {
           this.Id = id;
           this.EstadoEmpleado = estadoEmpleado;
           this.FechaCont = fechacont;
        }

        //Listar Id empelados en combobox
        public static List<int> ObtenerCodigosEmpleado()
        {
            var listaCodigos = new List<int>();

            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(connectionString))
            {
                string query = "SELECT IdEmpleado FROM Empleado WHERE EstadoEmpleado = 1";

                SqlCommand cmd = new SqlCommand(query, conector);

                try
                {
                    conector.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaCodigos.Add(Convert.ToInt32(reader["IdEmpleado"]));
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    System.Windows.Forms.MessageBox.Show($"Error al obtener códigos de empleado: {ex.Message}");
                }
            }

            return listaCodigos;
        }

    }
}
