using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sushine_lnventory.Models;

namespace Sushine_lnventory.Controllers
{
    public class ProductosControll
    {
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

    }
}
