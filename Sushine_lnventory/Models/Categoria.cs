using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre_Ct { get; set; }
        public string Descripcion_Ct { get; set; }
        public bool EstadoCat { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string nombre_Ct, string descripcion_Ct, bool estadoCat)
        {
            Id = id;
            Nombre_Ct = nombre_Ct;
            Descripcion_Ct = descripcion_Ct;
            EstadoCat = estadoCat;
        }

        public List<Categoria> ObtenerCategoriasActivas()
        {
            List<Categoria> categorias = new List<Categoria>();
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection conector = new SqlConnection(connectionString))
            {
                try
                {
                    conector.Open();

                    string query = "SELECT IdCategoria, NombreCategoria, DescripcionCategoria, EstadoCat " +
                                   "FROM Categoria " +
                                   "WHERE EstadoCat = 1"; // Filtra solo categorías activas

                    using (SqlCommand cmd = new SqlCommand(query, conector))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categorias.Add(new Categoria
                                {
                                    Id = reader.GetInt32(0),                        // Mapea IdCategoria
                                    Nombre_Ct = reader.GetString(1),               // Mapea NombreCategoria
                                    Descripcion_Ct = reader.GetString(2),          // Mapea DescripcionCategoria
                                    EstadoCat = reader.GetBoolean(3)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las categorías activas: " + ex.Message);
                }
            }

            return categorias;
        }
    }
}
