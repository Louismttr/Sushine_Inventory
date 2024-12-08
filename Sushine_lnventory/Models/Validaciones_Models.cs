using System;
using System.Linq;
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


    }
}
