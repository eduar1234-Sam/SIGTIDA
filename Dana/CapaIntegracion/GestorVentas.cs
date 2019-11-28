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
    public class GestorVentas: servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public GestorVentas()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarVenta(int Id_Cliente)
        {
            Venta nuevaVenta = new Venta(Id_Cliente);

            using (ServicioVenta laVenta = new ServicioVenta())
                return laVenta.ingresarVenta(nuevaVenta);
        }

        public DataSet ultimaVenta()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.ultimaVenta();


            }

        }

        public DataTable cantidadVenta()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.numeroVenta();


            }

        }

        public DataTable cantidadVentaMes()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.numeroVentaMes();


            }

        }
        public DataTable cantidadVentaAnio()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.numeroVentaAnio();


            }

        }

        public DataTable productoSemana()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.productoSemana();


            }

        }
        public DataTable productoMes()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.productoMes();


            }

        }
        public DataTable productoAnio()
        {
            using (ServicioVenta comp = new ServicioVenta())
            {

                return comp.productoAnio();


            }

        }



    }
}
