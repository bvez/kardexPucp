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
using LogicaNegocios;

namespace FormulariosAlmacenes
{
    public partial class PantallaAnadirProducto : Form
    {
        private Producto productoSeleccionado;
        private AlmacenProductosBL logicaProductos;
        public PantallaAnadirProducto()
        {
            InitializeComponent();
            logicaProductos = new AlmacenProductosBL();
        }

        public PantallaAnadirProducto(BindingList<ProductoAlmacen> productosRegistradosAlmacen)
        {
            InitializeComponent();
            logicaProductos = new AlmacenProductosBL();

            dataGridProductosAlmacen.AutoGenerateColumns = false;
            dataGridProductosEmpresa.AutoGenerateColumns = false;
            dataGridProductosAlmacen.DataSource = productosRegistradosAlmacen;
            dataGridProductosEmpresa.DataSource = logicaProductos.obtenerProductosEmpresa();
        }

        private void btnInsertarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("El producto se insertó correctamente","Transaccion Exitosa");
            //MessageBox.Show("El producto no se pudo insertar correctamente", "Error");
        }

        private void PantallaAnadirProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
        }

        private void dataGridProductosEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            productoSeleccionado = (Producto)dataGridProductosEmpresa.CurrentRow.DataBoundItem;
            labelNombre.Text = productoSeleccionado.Nombre;
            labelCodigo.Text = productoSeleccionado.Id;
        }
    }
}
