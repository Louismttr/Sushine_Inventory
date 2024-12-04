using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sushine_lnventory.Controllers
{
    public class Validations
    {

        //Efectos Txt o CmB

        //Txt
        public void EffectTxt(TextBox textBox, string placeholderText, Color placeholderColor, Color activeColor)
        {
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = activeColor;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = placeholderColor;
                }
            };
        }

        //Cmb
        public void EffectCmb(ComboBox comboBox, string placeholderText, Color placeholderColor, Color activeColor)
        {
            // Establecer el placeholder inicial
            comboBox.Text = placeholderText;
            comboBox.ForeColor = placeholderColor;

            // Evento cuando el ComboBox obtiene el foco
            comboBox.Enter += (s, e) =>
            {
                if (comboBox.Text == placeholderText)
                {
                    comboBox.Text = "";
                    comboBox.ForeColor = activeColor;
                }
            };

            // Evento cuando el ComboBox pierde el foco
            comboBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    comboBox.Text = placeholderText;
                    comboBox.ForeColor = placeholderColor;
                }
            };

            // Evento para seleccionar texto automáticamente si está el placeholder
            comboBox.DropDown += (s, e) =>
            {
                if (comboBox.Text == placeholderText)
                {
                    comboBox.Text = "";
                    comboBox.ForeColor = activeColor;
                }
            };
        }



    }
}
