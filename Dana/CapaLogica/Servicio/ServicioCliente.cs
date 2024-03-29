﻿using System;
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
    public class ServicioCliente: servicio , IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public ServicioCliente()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCliente");

            miComando.CommandText = "IngresarCliente";

            miComando.Parameters.Add("@nom", MySqlDbType.VarChar);
            miComando.Parameters["@nom"].Value = elCliente.Nombre_Cliente;

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = elCliente.Cedula_Cliente;

            miComando.Parameters.Add("@ap", MySqlDbType.VarChar);
            miComando.Parameters["@ap"].Value = elCliente.Apellido_Cliente;

            miComando.Parameters.Add("@tel", MySqlDbType.VarChar);
            miComando.Parameters["@tel"].Value = elCliente.Telefono_Cliente;

            miComando.Parameters.Add("@mail", MySqlDbType.VarChar);
            miComando.Parameters["@mail"].Value = elCliente.Email;

            miComando.Parameters.Add("@dir", MySqlDbType.VarChar);
            miComando.Parameters["@dir"].Value = elCliente.Direccion_Cliente;

            miComando.Parameters.Add("@estado_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@estado_Cliente"].Value = elCliente.Estado_Cliente;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Cliente");

            return respuesta;
        }

        public string ModificarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCliente");

            miComando.CommandText = "ModificarCliente";

            miComando.Parameters.Add("@id_Cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_Cliente"].Value = elCliente.Id_Cliente;

            miComando.Parameters.Add("@nombre_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@nombre_Cliente"].Value = elCliente.Nombre_Cliente;

            miComando.Parameters.Add("@apellido:Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@apellido_Cliente"].Value = elCliente.Nombre_Cliente;

            miComando.Parameters.Add("@telefono_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@telefono_Cliente"].Value = elCliente.Telefono_Cliente;

            miComando.Parameters.Add("@email", MySqlDbType.VarChar);
            miComando.Parameters["@email"].Value = elCliente.Email;

            miComando.Parameters.Add("@direccion_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@direccion_Cliente"].Value = elCliente.Direccion_Cliente;

            miComando.Parameters.Add("@estado_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@estado_Cliente"].Value = elCliente.Estado_Cliente;

            respuesta = this.ejecutarSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizadol correctamente la transaccion";
            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor modificar Cliente");

            return respuesta;
        }

        public DataSet ConsultarCliente(string id_Cliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCliente");

            miComando.CommandText = "ConsultarCliente";

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = id_Cliente;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable listarCliente()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCliente");

            //miComando.CommandText = "listarCliente";

            //miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            //miComando.Parameters["@ced"].Value = id_Cliente;

            DataTable miDataTable = new DataTable();
            this.abrirConexion();

            miDataTable = this.seleccionarIn("listarCliente");
            this.cerrarConexion();

            return miDataTable;
        }

    }
}
