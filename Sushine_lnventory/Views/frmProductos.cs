using Sushine_lnventory.Controllers;
using Sushine_lnventory.Models;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Sushine_lnventory.Views
{
    public partial class frmProductos : Form
    {
        CategoriasControll cat = new CategoriasControll();
        Conectar con = new Conectar();
        Validations validations = new Validations();
        ProductosControll Prod = new ProductosControll();
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;


        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
           // con.CodCmbB(cmbCategorias, "Categoria", "IdCategoria");
            con.ListarProDGV("ListarProducto", dGV_Productos);
            cat.CargarComboCategorias(cmbCategorias);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Prod.RegistrarProducto(txtCodPro, txtNamePro, txtCostoUni, txtPrecioVenta, cmbCategorias, eProv1);
            con.ListarProDGV("ListarProducto", dGV_Productos);
        }

    }
}
