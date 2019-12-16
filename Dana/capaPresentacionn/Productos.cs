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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();

            cargarGridProducto();
            //CargarDatosProducto();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataSet dsProducto;
        DataTable dtProducto;

        public void cargarGridProducto()
        {
            using (GestorProductos elProducto = new GestorProductos())
            {
                dgvProducto.DataSource = elProducto.listarProducto();


                //dgvProducto.Columns["id_Producto"].Visible = false;
                //dgvProducto.Columns["nombre_Producto"].HeaderText = "Nombre";
                //dgvProducto.Columns["categoría_Producto"].HeaderText = "Categoria";
                //dgvProducto.Columns["genero_Producto"].HeaderText = "Genero";
                //dgvProducto.Columns["edad_Producto"].HeaderText = "Edad";
                //dgvProducto.Columns["precio_Producto"].HeaderText = "Precio";


            }
        }

        private void btnInsertar_Producto_Click(object sender, EventArgs e)
        {
            using (GestorProductos elProducto = new GestorProductos())
            {
                elProducto.ingresar_Producto(txtNombre_Producto.Text, txtCategoria_Producto.Text, txtGenero_Producto.Text,
                                            txtEdad_Producto.Text, double.Parse(txtPrecio_Producto.Text));
            }
            cargarGridProducto();
        }

        //private void CargarDatosProducto()
        //{
        //    txtNombre_Producto.Text = this.dtProducto.Rows[0]["id_Producto"].ToString();
        //    txtCategoria_Producto.Text = this.dtProducto.Rows[0]["nombre_Producto"].ToString();
        //    txtCategoria_Producto.Text = this.dtProducto.Rows[0]["categoria_Producto"].ToString();
        //    txtGenero_Producto.Text = this.dtProducto.Rows[0]["genero_Producto"].ToString();
        //    txtEdad_Producto.Text = this.dtProducto.Rows[0]["edad_Producto"].ToString();
        //    txtPrecio_Producto.Text = this.dtProducto.Rows[0]["precio_Producto"].ToString();

        //}
    }
}
