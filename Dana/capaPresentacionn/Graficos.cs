using Dana.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace capaPresentacionn
{
    public partial class Graficos : Form
    {
      

        public Graficos()
        {
            InitializeComponent();
            cmb();
          

            chart1.Titles.Add("Estadísticas de Ventas");
        }
        

        //private void Chart1_Click(object sender, EventArgs e)
        //{
        //    cmb();
        //}

       public void cargarChart(string selec)
        {

            GestorVentas v = new GestorVentas();
            DataTable dt = new DataTable();
           

            
                
                if (selec.Equals("Ventas Semanal"))
                {

                    dt = v.cantidadVenta();

                }

                if (selec.Equals("Ventas Mensual"))
                {

                    dt = v.cantidadVentaMes();

                }

                if (selec.Equals("Ventas Anual"))
                {

                    dt = v.cantidadVentaAnio();

                }
            if (selec.Equals("Cantidad de Productos Semanal"))
            {

                dt = v.productoSemana();

            }
            if (selec.Equals("Cantidad de Productos Mensual"))
            {

                dt = v.productoMes();

            }
            if (selec.Equals("Cantidad de Productos Anual"))
            {

                dt = v.productoAnio();

            }








            DataRow dr;
            this.chart1.Palette = ChartColorPalette.Berry;
            //this.chart1.Titles.Add("Numero de ventas");



            for (int i = 0; i < dt.Rows.Count; i++)
            {

                dr = dt.Rows[i];
                Series series = this.chart1.Series.Add(dr.ItemArray[0].ToString());

                series.Points.Add(Convert.ToDouble(dr.ItemArray[1]));
            }
            //comboBox1.Items.Clear();
        }

        public void cmb()
        {
            comboBox1.Items.Add("Ventas Semanal");
            comboBox1.Items.Add("Ventas Mensual");
            comboBox1.Items.Add("Ventas Anual");
            comboBox1.Items.Add("Cantidad de Productos Semanal");
            comboBox1.Items.Add("Cantidad de Productos Mensual");
            comboBox1.Items.Add("Cantidad de Productos Anual");

            string selec = Convert.ToString(comboBox1.SelectedItem);



            cargarChart(selec);





        }

     

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            this.chart1.Series.Clear();
            
            cmb();
           

            comboBox1.Items.Clear();
           
            cmb();
          

        }

        private void ComboEstadistica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
