using Dana.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacionn
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
           Ventas laVenta = new Ventas();
            laVenta.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos elProducto = new Productos();
            elProducto.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes elCliente = new Clientes();
            elCliente.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras laCompra = new Compras();
            laCompra.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario elInventario = new Inventario();
            elInventario.Show();
        }

        private void Menus_Load(object sender, EventArgs e)
        {

        }
    }
}
