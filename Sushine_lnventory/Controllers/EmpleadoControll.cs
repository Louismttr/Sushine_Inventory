using Sushine_lnventory.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sushine_lnventory.Controllers
{
    public class EmpleadoControll
    {
        // Método para cargar los códigos de empleado en el ComboBox
        public void CargarCodigosEmpleado(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            // Obtener la lista de códigos desde el modelo
            List<int> codigos = Empleado.ObtenerCodigosEmpleado();

            // Llenar el ComboBox
            foreach (int codigo in codigos)
            {
                comboBox.Items.Add(codigo);
            }

            // Configurar la selección por defecto si es necesario
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
