using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushine_lnventory.Views
{
    public class ThemeManager
    {
        // Cambiar el ancho de un panel Menu
        public void TogglePanelWidth(Panel panel, int expandedWidth, int collapsedWidth)
        {
            if (panel.Width == expandedWidth)
            {
                panel.Width = collapsedWidth;
            }
            else
            {
                panel.Width = expandedWidth;
            }
        }

        //abrir formularios
        public void LoadFormIntoPanel(Panel container, Form childForm)
        {
            if (container.Controls.Count > 0)
            {
                container.Controls.RemoveAt(0);
            }

            if (childForm == null)
                throw new ArgumentNullException(nameof(childForm), "The child form cannot be null.");

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            container.Controls.Add(childForm);
            container.Tag = childForm;
            childForm.Show();
        }

        //Dinamismo botones
        //public void SetButtonClickEffect(Button button, Color clickColor, Image clickImage, Color defaultColor, Image defaultImage)
        //{
        //    button.Click += (s, e) =>
        //    {
        //        // Cambiar color e imagen al hacer clic
        //        button.ForeColor = clickColor;
        //        button.Image = clickImage;
        //    };

        //    button.MouseLeave += (s, e) =>
        //    {
        //        // Restaurar color e imagen al salir del botón
        //        button.ForeColor = defaultColor;
        //        button.Image = defaultImage;
        //    };
        //}

        //
        public void Cbtn(Button button, Color clickBackColor, Color clickForeColor, Image clickImage)
        {
            button.Click += (s, e) =>
            {
                // Cambiar propiedades del botón al hacer clic
                button.BackColor = clickBackColor;
                button.ForeColor = clickForeColor;
                button.Image = clickImage;
            };
        }


    }
}
