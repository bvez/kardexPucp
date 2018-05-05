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

namespace FormulariosAlmacenes
{
    public partial class PantallaAnadirProducto : Form
    {
        private Producto productoSeleccionado;
        public PantallaAnadirProducto()
        {
            InitializeComponent();
        }

        public PantallaAnadirProducto(BindingList<ProductoAlmacen> productosRegistradosAlmacen, BindingList<Producto> productosRegistradosEmpresa)
        {
            InitializeComponent();
            dataGridProductosAlmacen.AutoGenerateColumns = false;
            dataGridProductosEmpresa.AutoGenerateColumns = false;
            dataGridProductosAlmacen.DataSource = productosRegistradosAlmacen;
            dataGridProductosEmpresa.DataSource = productosRegistradosEmpresa;
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
