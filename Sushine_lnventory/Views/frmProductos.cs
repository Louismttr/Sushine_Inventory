using Sushine_lnventory.Controllers;
using Sushine_lnventory.Models;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Sushine_lnventory.Views
{
    public partial class frmProductos : Form
    {
        CategoriasControll cat = new CategoriasControll();
        Conectar con = new Conectar();
        Validations validations = new Validations();
        ProductosControll Prod = new ProductosControll();
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        Validaciones_Models validaciones = new Validaciones_Models();


        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            #region Efectos txt y comboBox
            validations.EffectTxt(txtCodPro, "Código del Producto", Color.Gray, Color.Black);
            validations.EffectTxt(txtNamePro, "Nombre del Producto", Color.Gray, Color.Black);
            validations.EffectCmb(cmbCategorias, "Seleccione una categoría", Color.Gray, Color.Black);
            validations.EffectTxt(txtCostoUni, "Costo Unitario", Color.Gray, Color.Black);
            validations.EffectTxt(txtPrecioVenta, "Precio de Venta", Color.Gray, Color.Black);
            validations.EffectTxt(txtBuscar, "Buscar...", Color.Gray, Color.Black);
            #endregion
            con.ListarProDGV("ListarProducto", dGV_Productos);
            cat.CargarComboCategorias(cmbCategorias);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Prod.RegistrarProducto(txtCodPro, txtNamePro, txtCostoUni, txtPrecioVenta, cmbCategorias, eProv1);
            con.ListarProDGV("ListarProducto", dGV_Productos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            try
            {
                string codigoProducto = txtBuscar.Text.Trim(); // Obtiene el texto ingresado y elimina espacios innecesarios

                if (!string.IsNullOrWhiteSpace(codigoProducto)) // Verifica si el TextBox contiene un valor válido
                {
                    // Realizar la búsqueda por código de producto
                    var dt = Prod.BuscarProductos(codigoProducto);

                    if (dt.Rows.Count > 0)
                    {
                        dGV_Productos.DataSource = dt; // Mostrar los resultados en el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron movimientos con el código de producto especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Prod.CargarProductos(dGV_Productos); // Volver a cargar todos los datos
                    }
                }
                else
                {
                    // Si el TextBox está vacío, cargar todos los datos
                    Prod.CargarProductos(dGV_Productos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar el movimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.VerificarCodProducto(txtCodPro);
        }

        private void txtCostoUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtNamePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }
    }
}
