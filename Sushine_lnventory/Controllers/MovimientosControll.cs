using Sushine_lnventory.Models;
using System;
using System.Windows.Forms;

namespace Sushine_lnventory.Controllers
{
    public class MovimientosControll
    {
        private Detalle_Movimiento modelo;
        private readonly ErrorProvider errorProvider;

        public MovimientosControll()
        {
            modelo = new Detalle_Movimiento();
        }

        public void RegistrarMovimiento(char codProd, int codEmpleado, int tipoMov, int cantidad)
        {
            modelo.RegistrarMovimiento(codProd, codEmpleado, tipoMov, cantidad);
        }

    }
}
