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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            cargarGridCompra();
            cargarComboCompra();
        }

        public void cargarGridCompra()
        {
            using (GestorCompras laCompra = new GestorCompras())
            {
                dgvCompras.DataSource = laCompra.ListarCompra();

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

        public void cargarComboCompra()
        {
            using (GestorCompras laCompra = new GestorCompras())
            {
                CBIdProducto_Compras.DataSource = laCompra.ListarCompra();
                CBIdProducto_Compras.ValueMember = "Id_Producto";
                CBIdProducto_Compras.DisplayMember = "Nombre_Producto";
            }
        }

        private void btnInsertar_Compra_Click(object sender, EventArgs e)
        {
            using (GestorCompras laCompra = new GestorCompras())
            {
                laCompra.InsertarCompra(int.Parse(txtIdCompra_Compra.Text), int.Parse(CBIdProducto_Compras.SelectedValue.ToString()),
                                        int.Parse(txtCantidadProducto_Compra.Text), double.Parse(txtPrecio_Compra.Text));
            }
            cargarGridCompra();
        }

        private void lblFecha_Compra_Click(object sender, EventArgs e)
        {

        }

        private void CBIdProducto_Compras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void DgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
