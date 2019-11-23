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
        public int idV; 

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

            generarVenta(int.Parse( datosResultado["id_Cliente"].ToString()));




        }

        public void generarVenta(int id)
        {
            GestorVentas v = new GestorVentas();
            v.InsertarVenta(id);

            MessageBox.Show("Generando Venta.");

            DataSet c;
            c = v.ultimaVenta();
            DataRow datosResultado;
            datosResultado = c.Tables[0].Rows[0];
            idV = int.Parse(datosResultado["r"].ToString());


        }
        public void cargarGridProducto()
        {

            GestorProductos p = new GestorProductos();

            comboProducto.DataSource = p.listarProducto();
            comboProducto.DisplayMember = "nombre_Producto";
            comboProducto.ValueMember = "id_Producto";
            

          
        }

        public void cargaDetalle(int id)
        {
            GestorDetalles d = new GestorDetalles();
            dataGridView1.DataSource = d.cargarDetalle(id);


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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            cargaDetalle(idV);
        }
    }
}
