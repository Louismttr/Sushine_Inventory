using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Sushine_lnventory.Models;
using Sushine_lnventory.Controllers;
using System.Drawing;


namespace Sushine_lnventory.Views
{
    public partial class frm_Movimientos : Form
    {
        private Conectar con;
        int renglon;

        private readonly string _connectionString;
        Validations validations = new Validations();

        public frm_Movimientos()
        {
            InitializeComponent();

        }
        private void ListarMovimientos()
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
                    dGV_Movimientos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void frm_Movimientos_Load(object sender, EventArgs e)
        {
            ListarMovimientos();
            //CargarProductosPorCodigo();
            #region Efectos Txt y Cmb
            validations.EffectCmb(cmb_Productos, "Producto", Color.Gray, Color.Black);
            validations.EffectTxt(txtCostoUni, "Costo Unitario", Color.Gray, Color.Black);
            validations.EffectCmb(cmb_Empleados, "Empleados", Color.Gray, Color.Black);
            validations.EffectTxt(txtCantidad, "Cantidad", Color.Gray, Color.Black);
            validations.EffectTxt(txtBuscar, "Buscar...", Color.Gray, Color.Black);
            //filtro
            validations.EffectCmb(cmbFProd2, "Producto", Color.Gray, Color.Black);
            validations.EffectCmb(cmbFEmp2, "Empleado", Color.Gray, Color.Black);

            #endregion
        }

        private void dGV_Movimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dGV_Movimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dGV_Movimientos.Rows[e.RowIndex];

                    DateTime Fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
                    int Producto = Convert.ToInt32(row.Cells["Producto"].Value);
                    cmb_Productos.Text = Producto.ToString();

                    float CostoUnitario = Convert.ToSingle(row.Cells["CostoUnitario"].Value);
                    txtCostoUni.Text = CostoUnitario.ToString();

                    float PrecioVenta = Convert.ToSingle(row.Cells["PrecioVenta"].Value);
                    int Entradas = Convert.ToInt32(row.Cells["NumeroEntradas"].Value);
                    int Salidas = Convert.ToInt32(row.Cells["NumeroSalidas"].Value);
                    float TotalEntrada = Convert.ToSingle(row.Cells["TotalEntradas"].Value);
                    float TotalSalida = Convert.ToSingle(row.Cells["TotalSalidas"].Value);


                    //MessageBox.Show($"Fecha: {Fecha}, Producto: {Producto}, Costo: {CostoUnitario}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir los valores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          //try
        //    {
        //        // Capturar valores 
        //        char codProd = Convert.ToChar(cmb_Productos.SelectedValue);
        //        int codEmpleado = Convert.ToInt32(cmb_Empleados.SelectedValue);
        //        int tipoMov = rb_Entrada.Checked ? 1 : 2; // Asumiendo: Entrada=1, Salida=2
        //        int cantidad = int.Parse(txtCantidad.Text);

            //        // Instanciar y llamar al método
            //        Detalle_Movimiento servicio = new Detalle_Movimiento();

            //        string resultado = servicio.RegistrarMovimiento(codProd, codEmpleado, tipoMov, cantidad);

            //        // Mostrar resultado en la interfaz
            //        MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }
    }
}
