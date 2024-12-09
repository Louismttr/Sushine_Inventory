using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sushine_lnventory.Models;

namespace Sushine_lnventory.Controllers
{
    public class ProductosControll 
    {
        Producto modelo = new Producto();

        public void CargarProductos(DataGridView dgv)
        {
            try
            {
                DataTable dt = modelo.ListarPro(); // Obtiene los movimientos del modelo
                dgv.DataSource = dt; // Asigna los datos al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarCodigosProducto(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            // Obtener la lista de códigos desde el modelo
            List<string> codigos = Producto.ObtenerCodigosProducto();

            // Llenar el ComboBox
            foreach (string codigo in codigos)
            {
                comboBox.Items.Add(codigo);
            }

            // Configurar la selección por defecto si es necesario
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        private Producto productoModel = new Producto();

        public void RegistrarProducto(TextBox txtCodigo, TextBox txtNombre, TextBox txtCosto, TextBox txtPrecio, ComboBox cboCategoria, ErrorProvider errorProvider)
        {
            // Limpia los errores previos
            errorProvider.Clear();

            bool esValido = true;

            // Validar código del producto
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider.SetError(txtCodigo, "El código del producto es obligatorio.");
                esValido = false;
            }

            // Validar nombre del producto
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre del producto es obligatorio.");
                esValido = false;
            }

            // Validar costo unitario
            if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                errorProvider.SetError(txtCosto, "Ingrese un costo unitario válido.");
                esValido = false;
            }

            // Validar precio de venta
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                errorProvider.SetError(txtPrecio, "Ingrese un precio de venta válido.");
                esValido = false;
            }

            // Validar categoría
            if (cboCategoria.SelectedIndex == -1)
            {
                errorProvider.SetError(cboCategoria, "Debe seleccionar una categoría.");
                esValido = false;
            }

            // Si todo es válido, registrar el producto
            if (esValido)
            {
                var productoModel = new Producto();
                productoModel.InsertarProducto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    costo,
                    precio,
                    Convert.ToInt32(cboCategoria.SelectedValue)
                );
            }
        }

        public DataTable BuscarProductos(string idPro)
        {
            if (!string.IsNullOrWhiteSpace(idPro)) // Verifica si el ID del producto no es nulo o vacío
            {
                try
                {
                    return modelo.ObtenerProductoPorId(idPro); // Llama al método del modelo para obtener el producto por ID
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al buscar movimientos: {ex.Message}", ex);
                }
            }
            else
            {
                try
                {
                    return modelo.ListarPro(); // Devuelve todos los productos si no se proporciona un ID
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al listar productos: {ex.Message}", ex);
                }
            }
        }

    }
}
