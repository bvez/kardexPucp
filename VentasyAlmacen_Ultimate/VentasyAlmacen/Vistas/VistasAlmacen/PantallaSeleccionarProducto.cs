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
using Entidades;

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaSeleccionarProducto : Form
    {
        private AlmacenProductosBL productosBL;
        private ProductoAlmacen productoSeleccionado = null;
        
        /*
        public PantallaSeleccionarProducto()
        {
            productosBL = new AlmacenProductosBL();
            InitializeComponent();
            dataGridProductos.AutoGenerateColumns = false;
            dataGridProductos.DataSource = productosBL.obtenerProductosEmpresa();
        }
        */

        public PantallaSeleccionarProducto(int idAlmacen)
        {
            productosBL = new AlmacenProductosBL();
            InitializeComponent();
            dataGridProductos.AutoGenerateColumns = false;
            dataGridProductos.DataSource = productosBL.obtenerProductosAlmacen(idAlmacen);
        }

        public ProductoAlmacen ProductoSeleccionado { get => productoSeleccionado;}

        private void dataGridProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                this.productoSeleccionado = (ProductoAlmacen)dataGridProductos.CurrentRow.DataBoundItem;
                this.Dispose();
            }
        }

        private void btnSelectAlmacenAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelectAlmacenSgte_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                this.productoSeleccionado = (ProductoAlmacen)dataGridProductos.CurrentRow.DataBoundItem;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
            }
        }
    }
}
