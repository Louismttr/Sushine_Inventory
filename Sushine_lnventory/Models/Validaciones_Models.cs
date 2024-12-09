using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sushine_lnventory.Models
{
    public class Validaciones_Models
    {
        // Validar si el TextBox está vacío
        public static bool IsTextBoxEmpty(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Este campo es obligatorio.");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, string.Empty); // Limpiar el error
                return false;
            }
        }

        public static void OnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evitar la entrada
            }
        }

        // Validar que solo se permitan letras en el TextBox
        public static void OnlyLetters(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Evitar la entrada
            }
        }

        // Validar selección en un ComboBox
        public static bool IsComboBoxSelected(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBox, "Debe seleccionar una opción.");
                return false;
            }
            else
            {
                errorProvider.SetError(comboBox, string.Empty); // Limpiar el error
                return true;
            }
        }

        // Validar que un RadioButton esté seleccionado
        public static bool IsRadioButtonChecked(GroupBox groupBox, ErrorProvider errorProvider)
        {
            if (!groupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
            {
                errorProvider.SetError(groupBox, "Debe seleccionar una opción.");
                return false;
            }
            else
            {
                errorProvider.SetError(groupBox, string.Empty); // Limpiar el error
                return true;
            }
        }
        //Validar el ingreso de solo numeros
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo acepta números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        //Validar el ingreso de solo letras
        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 182 && e.KeyChar <= 223) || (e.KeyChar >= 225 && e.KeyChar <= 232) || (e.KeyChar >= 234 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo acepta texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        //Validacion de GroupBox vacios

        public bool VerificarCamposVacios(Control control, GroupBox gb)
        {
            bool dato = false;
            foreach (var input in control.Controls)
            {
                if (input is TextBox)
                {
                    if (((TextBox)input).Text == string.Empty)
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ((TextBox)input).Focus();
                        dato = false;
                    }
                    dato = true;
                }

                else if (input is ComboBox)
                {
                    if (((ComboBox)input).SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un dato", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ((ComboBox)input).Focus();
                        dato = false;
                    }
                    dato = true;
                }
            }
            foreach (var input in gb.Controls)
            {
                if (input is TextBox)
                {
                    if (((TextBox)input).Text == string.Empty)
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ((TextBox)input).Focus();
                        dato = false;
                    }
                    dato = true;
                }

                else if (input is ComboBox)
                {
                    if (((ComboBox)input).SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un dato", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ((ComboBox)input).Focus();
                        dato = false;
                    }
                    dato = true;
                }
            }

            return dato;
        }

        //Validar Ingreso correcto de valores en el atributo Cedula

        public bool VerificarCedula(TextBox cedula)
        {
            string patron = @"^\d{12}[A-Z]$";

            if (Regex.IsMatch(cedula.Text, patron))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe escribir correctamente la cedula", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Validar Ingreso del Codigo del Producto
        public bool VerificarCodProducto(TextBox CodProducto)
        {
            string patron = @"^\d{5}$";

            if (Regex.IsMatch(CodProducto.Text, patron))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe escribir correctamente el código del producto - Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }




    }
}
