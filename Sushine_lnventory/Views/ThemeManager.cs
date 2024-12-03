using System;
using System.Collections.Generic;
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

    }
}
