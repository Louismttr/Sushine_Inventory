using Sushine_lnventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushine_lnventory.Views
{
    public partial class frm_Empleados : Form
    {
        Conectar con = new Conectar();
        Validaciones_Models validaciones = new Validaciones_Models();
        public frm_Empleados()
        {
            InitializeComponent();
        }

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            con.ListarProDGV("ListarEmpleado", dGV_Empleados);
        }

        private void txtPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);

        }

        private void txtPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);

        }

        private void txtSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);

        }

        private void txtNIdenti_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.VerificarCedula( txtNIdenti);
        }

    }
}
