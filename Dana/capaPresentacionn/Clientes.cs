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
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
            cargarGrid();
           
        }

        public void cargarGrid()
        {
            using (GestorClientes cl = new GestorClientes())
            {
                dataGridView1.DataSource = cl.listarCliente();
                dataGridView1.Columns["id_Cliente"].Visible=false;
                dataGridView1.Columns["cedulaCliente"].HeaderText = "Cedula";
                dataGridView1.Columns["nombre_Cliete"].HeaderText = "Nombre";
                dataGridView1.Columns["apellido_Cliente"].HeaderText = "Apellido";
                dataGridView1.Columns["telefono_Cliente"].HeaderText = "Telefono";
                dataGridView1.Columns["email"].HeaderText = "E-mail";
                dataGridView1.Columns["direccion_Cliente"].HeaderText = "Dirección";
               
                dataGridView1.Columns["estado_Cliente"].Visible = false;
            }
            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            GestorClientes cl = new GestorClientes();
            cl.InsertarCliente(nombre.Text, cedula.Text, apellido.Text, telefono.Text,

                mail.Text, direccion.Text, "A");
            cargarGrid();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
