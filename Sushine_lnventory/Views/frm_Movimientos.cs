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
        private MovimientosControll Mov = new MovimientosControll();

        public frm_Movimientos()
        {
            InitializeComponent();
        }


        private void frm_Movimientos_Load(object sender, EventArgs e)
        {
            con.ListarProDGV("ListarDetMov", dGV_Movimientos);
            prod.CargarCodigosProducto(cmb_Productos);
            emp.CargarCodigosEmpleado(cmb_Empleados);
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
            char codProducto = Convert.ToChar(cmb_Empleados.SelectedValue);
            int codEmpleado = Convert.ToInt32(cmb_Empleados.SelectedValue);

            // Llamar al método para registrar el movimiento
            Mov.RegistrarMovimiento(codProducto, codEmpleado, tipoMov, cantidad);

        }

        private void cmb_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.RellenarCostoUnitario(cmb_Productos, txtCostoU);
        }
    }
}
