using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dana.CapaConexion;
using Dana.CapaLogica.LogicaNegocio;
using MySql.Data.MySqlClient;

namespace Dana.CapaLogica.Servicio
{
    public class ServicioProducto: servicio, IDisposable
    {
        private MySqlCommand miComando;
        private string respuesta;

        public ServicioProducto()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresar_Producto(Producto elProducto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorProducto");

            miComando.CommandText = "ingresar_Producto";

            miComando.Parameters.Add("@nom", MySqlDbType.VarChar);
            miComando.Parameters["@nom"].Value = elProducto.Nombre_Producto;

            miComando.Parameters.Add("@cat", MySqlDbType.VarChar);
            miComando.Parameters["@cat"].Value = elProducto.Categoria_Producto;

            miComando.Parameters.Add("@gen", MySqlDbType.VarChar);
            miComando.Parameters["@gen"].Value = elProducto.Genero_Producto;

            miComando.Parameters.Add("@edad", MySqlDbType.VarChar);
            miComando.Parameters["@edad"].Value = elProducto.Edad_Producto;

            miComando.Parameters.Add("@prec_Prod", MySqlDbType.Double);
            miComando.Parameters["@prec_Prod"].Value = elProducto.Precio_Producto;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Producto");

            return respuesta;
        }

        //public string modificarProducto(Producto elProducto)
        //{
        //    miComando = new MySqlCommand();
        //    Console.WriteLine("GestorProducto");

        //    miComando.Parameters.Add("@id_Producto", MySqlDbType.Int32);
        //    miComando.Parameters["@id_Producto"].Value = elProducto.Id_Producto;

        //    miComando.Parameters.Add("@nombre_Producto", MySqlDbType.VarChar);
        //    miComando.Parameters["@nombre_Producto"].Value = elProducto.nom;

        //    miComando.Parameters.Add("@categoria_Producto", MySqlDbType.VarChar);
        //    miComando.Parameters["@categoria_Producto"].Value = elProducto.cat;

        //    miComando.Parameters.Add("@genero_Producto", MySqlDbType.VarChar);
        //    miComando.Parameters["@genero_Producto"].Value = elProducto.gen;

        //    miComando.Parameters.Add("@edad_producto", MySqlDbType.VarChar);
        //    miComando.Parameters["@edad_Producto"].Value = elProducto.edad;

        //    miComando.Parameters.Add("@precio_Producto", MySqlDbType.Double);
        //    miComando.Parameters["@precio_Producto"].Value = elProducto.prec_Prod;

        //    respuesta = this.ejecutarSentencia(miComando);
        //    if (respuesta == "")
        //        respuesta += "se ha realizado correctamente la transaccion";


        //    Console.WriteLine(respuesta);
        //    Console.WriteLine("Fin del gestor modificar Producto");

        //    return respuesta;
        //}

        public DataTable listarProducto()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorProducto");

           // miComando.CommandText = "listarProducto";

            

            DataTable miDataSet = new DataTable();
            this.abrirConexion();

            miDataSet = this.seleccionarIn("listarProducto");
            this.cerrarConexion();

            return miDataSet;
        }

    }
}
