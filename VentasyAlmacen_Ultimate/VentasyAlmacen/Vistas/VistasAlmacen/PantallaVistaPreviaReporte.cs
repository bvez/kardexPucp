using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaVistaPreviaReporte : Form
    {        

        public PantallaVistaPreviaReporte()
        {
            InitializeComponent();
            int[] arrNum = new int[] { 10,21,3,45};
            chart1.DataSource = arrNum;
            chart1.Series[0].Points.DataBindY(arrNum);
        }
    }
}
