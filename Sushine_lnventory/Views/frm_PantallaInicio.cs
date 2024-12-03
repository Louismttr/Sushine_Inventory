using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sushine_lnventory.Views
{
    public partial class frm_PantallaInicio : Form
    {
        ThemeManager themeManager = new ThemeManager();

        public frm_PantallaInicio()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            themeManager.TogglePanelWidth(pnlMenuVertical, 188, 50);
        }

        private void btn_Movimientos_Click(object sender, EventArgs e)
        {
            themeManager.LoadFormIntoPanel(pnlContenedor, new frm_Movimientos());
        }
    }
}
