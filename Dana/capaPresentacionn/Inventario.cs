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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cargarGridInventario();
            cargarComboInventario();
        }

        public void cargarGridInventario()
        {
            using (GestorInventario elInventario = new GestorInventario())
            {
                dgvInventario.DataSource = elInventario.ListarInventario();

                /*
                dgvVeterinario.Columns["Veterinario_id"].Visible = false;
                dgvVeterinario.Columns["Veterinario_cedula"].HeaderText = "Cedula";
                dgvVeterinario.Columns["Veterinario_nombre"].HeaderText = "Nombre";
                dgvVeterinario.Columns["Veterinario_telefono"].HeaderText = "Telefono";
                dgvVeterinario.Columns["Veterinario_direccion"].HeaderText = "Direccion";
                dgvVeterinario.Columns["Veterinario_estado"].Visible = false;
                */

            }
        }

        public void cargarComboInventario()
        {
            using (GestorProductos elProducto = new GestorProductos())
            {
                CBIdProducto_Inventario.DataSource = elProducto.listarProducto();
                CBIdProducto_Inventario.ValueMember = "Id_Producto";
                CBIdProducto_Inventario.DisplayMember = "Nombre_Producto";
            }
        }

        private void btnInsertar_Inventario_Click(object sender, EventArgs e)
        {
            using (GestorInventario elProducto = new GestorInventario())
            {
                elProducto.InsertarInventario(int.Parse(CBIdProducto_Inventario.SelectedValue.ToString()),int.Parse(txtCantidad_Producto.Text));
            }
            cargarGridInventario();
        }
    }
}
