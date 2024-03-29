﻿using System;
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
    public class GestorDetalles : servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public GestorDetalles()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string ingresarDetalle(int idP, int idV, int cant)
        {

            Detalle nuevoProducto = new Detalle(idP, idV, cant);

            using (ServicioDetalle elProducto = new ServicioDetalle())
                return elProducto.ingresarDetalle(nuevoProducto);

        }

       public DataTable cargarDetalle(int id)
       {
            using (ServicioDetalle comp = new ServicioDetalle())
           {

              return comp.CargarDetalle(id);


           }

        }

        public DataTable cargarTotal()
        {
            using (ServicioDetalle comp = new ServicioDetalle())
            {

                return comp.CargaTotal();


            }

        }

    }
}
