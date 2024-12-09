using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sushine_lnventory.Views
{
    public partial class frm_PantallaInicio : Form
    {
        ThemeManager tM = new ThemeManager();

        public frm_PantallaInicio()
        {
            InitializeComponent();
        }
        
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            tM.TogglePanelWidth(pnlMenuVertical, 188, 50); 
        }

        //Abrir formularios
        private void btn_Movimientos_Click(object sender, EventArgs e)
        {
            tM.LoadFormIntoPanel(pnlContenedor, new frm_Movimientos());
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            tM.LoadFormIntoPanel(pnlContenedor, new frm_Empleados());
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            tM.LoadFormIntoPanel(pnlContenedor, new frmProductos());
        }

        private void btn_Inventarios_Click(object sender, EventArgs e)
        {
            tM.LoadFormIntoPanel(pnlContenedor, new frm_Inventario());
        }

        private void btn_Movimientos_Click_1(object sender, EventArgs e)
        {
            tM.LoadFormIntoPanel(pnlContenedor, new frm_Movimientos());
        }

        
    }
}
