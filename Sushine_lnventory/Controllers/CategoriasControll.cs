using Sushine_lnventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushine_lnventory.Controllers
{
    public class CategoriasControll
    {
        Categoria categoriaModel = new Categoria();
        public void CargarComboCategorias(ComboBox cboCategorias)
        {

            var categorias = categoriaModel.ObtenerCategoriasActivas();

            cboCategorias.DataSource = categorias;
            cboCategorias.DisplayMember = "Id"; // Muestra el IdCategoria en el ComboBox
            cboCategorias.ValueMember = "Id";   // El valor seleccionado será el IdCategoria
            cboCategorias.SelectedIndex = -1;   // Deja el ComboBox sin selección inicial
        }
    }
}
