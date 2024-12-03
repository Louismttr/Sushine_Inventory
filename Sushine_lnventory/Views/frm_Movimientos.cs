using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Sushine_lnventory.Models;


namespace Sushine_lnventory.Views
{
    public partial class frm_Movimientos : Form
    {
        public frm_Movimientos()
        {
            InitializeComponent();
        }
        #region Connection String
        private readonly string _connectionString;

        public frm_Movimientos(string connectionString)
        {
            _connectionString = connectionString;
        }
        #endregion

        #region MetodoConexion_No termiando
        private void conexion()
        {
            var constring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            try
            {
                using (SqlConnection conector = new SqlConnection(constring))
                {
                    conector.Open();
                    DataTable dataTable = new DataTable();
                    string query = @"SELECT * FROM DetalleMov";
                    SqlCommand cmd = new SqlCommand(query, conector);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frm_Movimientos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar valores 
                char codProd = Convert.ToChar(cmb_Productos.SelectedValue);
                int codEmpleado = Convert.ToInt32(cmb_Empleados.SelectedValue);
                int tipoMov = rb_Entrada.Checked ? 1 : 2; // Asumiendo: Entrada=1, Salida=2
                int cantidad = int.Parse(txtCantidad.Text);

                // Instanciar y llamar al método
                Detalle_Movimiento servicio = new Detalle_Movimiento();
                
                string resultado = servicio.RegistrarMovimiento(codProd, codEmpleado, tipoMov, cantidad);

                // Mostrar resultado en la interfaz
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///A
        ///
        //Metodo para elistar productos
        private void CargarProductosPorCodigo()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    // Consulta SQL para obtener los códigos y nombres de los productos
                    string query = "SELECT CodProducto, NombreProducto FROM Producto";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Asignar el DataTable como fuente de datos del ComboBox
                    cmb_Productos.DataSource = dt;

                    // Mostrar el código del producto como texto visible
                    cmb_Productos.DisplayMember = "CodProducto";

                    // Usar el código del producto como valor interno
                    cmb_Productos.ValueMember = "CodProducto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
