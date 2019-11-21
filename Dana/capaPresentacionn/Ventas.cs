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
        private object row;

        public Ventas()
        {
            InitializeComponent();
        }

        public  void llenarText()
        {
           

            GestorClientes cl = new GestorClientes();
            DataSet c;
            c = cl.ConsultarCliente("1");

            nombreCliente.Text = c.ToString();

            

            
            
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
    }
}
