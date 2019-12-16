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
    public class GestorInventario : servicio, IDisposable
    {

        private string respuesta;
        private MySqlCommand miComando;

        public GestorInventario()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarInventario(int id_Producto,int cantidad_Producto)
        {
            Inventario nuevoInventario = new Inventario(id_Producto,cantidad_Producto);

            using (ServicioInventario elInventario = new ServicioInventario())
                return elInventario.ingresarInventario(nuevoInventario);
        }

        public DataTable ListarInventario()
        {
            using (ServicioInventario elInventario = new ServicioInventario())
                return elInventario.ListarInventario();
        }
    }
}
