using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaVistaPreviaReporte : Form
    {
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public PantallaVistaPreviaReporte(BindingList<LineaIngresoSalidaProducto>listaEntrada)
        {
            InitializeComponent();
            //int[] arrNum = new int[] { 10,21,3,45};
            chart1.DataSource = listaEntrada;
            chart = chart1;
            //chart1.Series[0].Points.DataBindY(arrNum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
