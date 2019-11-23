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
    public class ServicioVenta : servicio, IDisposable
    {
        MySqlCommand miComando;
        private string respuesta;



        public ServicioVenta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresarVenta(Venta laVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("IngresarVenta");

            miComando.CommandText = "IngresarVenta";

            miComando.Parameters.Add("@idC", MySqlDbType.Int32);
            miComando.Parameters["@idC"].Value = laVenta.Id_Cliente;

           



            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Venta");

            return respuesta;
        }

        public DataSet ultimaVenta()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorVenta");

            miComando.CommandText = "ultimaVenta";

           

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
    }
}
