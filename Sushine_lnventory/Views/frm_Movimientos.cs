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
        ProductosControll prod = new ProductosControll();
        EmpleadoControll emp = new EmpleadoControll();
        private Conectar con = new Conectar();
        Validations validations = new Validations();
        Validaciones_Models validaciones = new Validaciones_Models();
        private MovimientosControll Mov = new MovimientosControll();

        public frm_Movimientos()
        {
            InitializeComponent();
            cmbFProd2.SelectedIndexChanged += cmbFProd2_SelectedIndexChanged;
            cmbFEmp2.SelectedIndexChanged += cmbFEmp2_SelectedIndexChanged;
        }


        private void frm_Movimientos_Load(object sender, EventArgs e)
        {
            Mov.CargarMovimientos(dGV_Movimientos);
            #region Efectos comboBox y txt
            validations.EffectCmb(cmb_Productos, "Producto", Color.Gray, Color.Black);
            validations.EffectTxt(txtCantidad, "Cantidad", Color.Gray, Color.Black);
            validations.EffectCmb(cmb_Empleados, "Empleados", Color.Gray, Color.Black);
            validations.EffectTxt(txtBuscar, "Buscar...", Color.Gray, Color.Black);
            //Filtros 
            validations.EffectCmb(cmbFProd2, "Producto", Color.Gray, Color.Black);
            validations.EffectCmb(cmbFEmp2, "Empleados", Color.Gray, Color.Black);
            #endregion
            //Cargando comboBox para registro
            prod.CargarCodigosProducto(cmb_Productos);
            emp.CargarCodigosEmpleado(cmb_Empleados);
            //Cargando comboBox para filtros
            con.CodCmbB(cmbFProd2, "Producto", "CodProducto");
            con.CodCmbB(cmbFEmp2, "Empleado", "IdEmpleado");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmb_Productos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el empleado esté seleccionado
            if (cmb_Empleados.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determinar el tipo de movimiento
            int tipoMov = rb_Entrada.Checked ? 1 : rb_Salida.Checked ? 2 : 0;
            if (tipoMov == 0)
            {
                MessageBox.Show("Debe seleccionar el tipo de movimiento (Entrada o Salida).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la cantidad sea un número válido
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores seleccionados
            string codProducto = cmb_Productos.Text;
            int codEmpleado = Convert.ToInt32(cmb_Empleados.Text);

            // Llamar al método para registrar el movimiento
            Mov.RegistrarMovimiento(codProducto, codEmpleado, tipoMov, cantidad);
            con.ListarProDGV("ListarDetMov", dGV_Movimientos);
        }

        private void cmb_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.RellenarCostoUnitario(cmb_Productos, txtCostoU);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            try
            {
                // Verificar si el TextBox contiene un valor
                if (int.TryParse(txtBuscar.Text, out int idDetMov))
                {
                    // Realizar la búsqueda por ID
                    var dt = Mov.BuscarMovimientos(idDetMov);

                    if (dt.Rows.Count > 0)
                    {
                        dGV_Movimientos.DataSource = dt; // Mostrar los resultados
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron movimientos con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.ListarMo(dGV_Movimientos); // Volver a cargar todos los datos
                    }
                }
                else if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    // Si el TextBox está vacío, cargar todos los datos
                    Mov.CargarMovimientos(dGV_Movimientos);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar el movimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDecargar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataTable movimientos = dGV_Movimientos.DataSource as DataTable;

                    if (movimientos != null && movimientos.Rows.Count > 0)
                    {
                        Mov.ExportarMovimientosAExcel(movimientos, sfd.FileName);
                        MessageBox.Show("Datos exportados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void cmbFProd2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarMovimientos();
        }
        private void cmbFEmp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarMovimientos();
        }

        //Filtrar
        private void FiltrarMovimientos()
        {
            // Obtener valores seleccionados
            string productoId = cmbFProd2.SelectedIndex > 0 ? cmbFProd2.Text?.ToString() : null;
            int? empleadoId = null;

            if (cmbFEmp2.SelectedIndex > 0 && int.TryParse(cmbFEmp2.Text?.ToString(), out int empleadoCodigo))
            {
                empleadoId = empleadoCodigo;
            }

            // Si no hay selección en ambos, cargar todos los datos
            // Verificar si ambos valores son nulos o vacíos
            if (string.IsNullOrEmpty(productoId) && !empleadoId.HasValue)
            {
                // Si no hay filtro, cargar todos los datos
                Mov.CargarMovimientos(dGV_Movimientos);
            }
            else
            {
                // Si hay filtro, aplicar la consulta al controlador
                dGV_Movimientos.DataSource = Mov.FiltrarMovimientos(productoId, empleadoId);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

    }
}
