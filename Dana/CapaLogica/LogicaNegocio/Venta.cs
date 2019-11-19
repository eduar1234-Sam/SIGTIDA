﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dana.CapaLogica.LogicaNegocio
{
    public class Venta
    {
        #region Atributos
        protected int id_Venta;
        protected int id_Producto;
        protected DateTime fecha_Venta;
        #endregion

        #region Constructores
        public Venta(int Pid_Producto, DateTime Pfecha_Venta)
        {
            id_Venta = 0;
            id_Producto = Pid_Producto;
            fecha_Venta = Pfecha_Venta;
        }

        public Venta(int Pid_Venta, int Pid_Producto, DateTime Pfecha_Venta)
        {
            id_Venta = Pid_Venta;
            id_Producto = Pid_Producto;
            fecha_Venta = Pfecha_Venta;
        }
        #endregion

        #region Get´s y Set´s
        public int Id_Venta { get => id_Venta; set => id_Venta = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public DateTime Fecha_Venta { get => fecha_Venta; set => fecha_Venta = value; }
        #endregion
    }

}
