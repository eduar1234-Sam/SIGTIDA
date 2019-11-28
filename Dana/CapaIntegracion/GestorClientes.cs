using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dana.CapaConexion;
using Dana.CapaLogica.LogicaNegocio;
using Dana.CapaLogica.Servicio;
using MySql.Data.MySqlClient;

namespace Dana.CapaIntegracion
{
    public class GestorClientes : servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public GestorClientes()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarCliente(string nombre, string ced, string ap, string tel, string mail,
              string dir, string est)
        {
            Cliente nuevoInventario = new Cliente(nombre, ced, ap, tel, mail, dir, est);

            using (ServicioCliente elInventario = new ServicioCliente())
                return elInventario.ingresarCliente(nuevoInventario);
        }
        public DataSet ConsultarCliente(string id)
        {
            using (ServicioCliente comp = new ServicioCliente())
            {

                return comp.ConsultarCliente(id);


            }

        }
        public DataTable listarCliente()
        {
            using (ServicioCliente comp = new ServicioCliente())
            {

                return comp.listarCliente();


            }

        }
    }
}
