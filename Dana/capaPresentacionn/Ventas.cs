using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dana.CapaIntegracion;

namespace capaPresentacionn
{
    public partial class Ventas : Form
    {
       

        public Ventas()
        {
            InitializeComponent();

            cargarGridProducto();
        }

        public  void llenarText()
        {
           

            GestorClientes cl = new GestorClientes();
            DataSet c;
            c = cl.ConsultarCliente("1");
            DataRow datosResultado;
            datosResultado = c.Tables[0].Rows[0];




            this.nombreCliente.Text = datosResultado["nombre_Cliete"].ToString(); 

            this.apellidoCliente.Text= datosResultado["apellido_Cliente"].ToString();




        }
        public void cargarGridProducto()
        {
            GestorProductos cl = new GestorProductos();
            DataSet c;
            c = cl.listarProducto();
            DataRow datosResultado;
            datosResultado = c.Tables[0].Rows[0];




            this.nombreCliente.Text = datosResultado["nombre_Producto"].ToString();


            GestorProductos prod = new GestorProductos();
            comboProducto.DataSource = prod.listarProducto();
            comboProducto.DisplayMember = "genero_Producto".ToString();
        }
        

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarProducto_Click(object sender, EventArgs e)
        {
            llenarText();
        }

        private void ComboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
