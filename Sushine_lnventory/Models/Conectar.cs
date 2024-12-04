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

        private void ListarMovimientos(DataGridView data)
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

        public void listarMovimientos(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            //SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarDetMov";
           // cmd.Connection = connect;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
        }
    }
}
