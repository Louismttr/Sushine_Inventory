using Sushine_lnventory.Models;
using System;
using System.Windows.Forms;

namespace Sushine_lnventory.Controllers
{
    public class MovimientosControll
    {
        private Detalle_Movimiento modelo;

        public MovimientosControll()
        {
            modelo = new Detalle_Movimiento();

        }

        public void RegistrarMovimiento(String codProd, int codEmpleado, int tipoMov, int cantidad)
        {
            modelo.RegistrarMovimiento(codProd, codEmpleado, tipoMov, cantidad);
        }
    }
}
