using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;


namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaSeleccionarProducto : Form
    {
        AlmacenProductosBL productosBL;
        public PantallaSeleccionarProducto()
        {
            productosBL = new AlmacenProductosBL();
            InitializeComponent();
            dataGridProductos.AutoGenerateColumns = false;
            dataGridProductos.DataSource = productosBL.obtenerProductosEmpresa();
        }

        public PantallaSeleccionarProducto(int idAlmacen)
        {
            productosBL = new AlmacenProductosBL();
            InitializeComponent();
            dataGridProductos.AutoGenerateColumns = false;
            dataGridProductos.DataSource = productosBL.obtenerProductosAlmacen(idAlmacen);
        }
    }
}
