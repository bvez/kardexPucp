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
        private int idAlmacen;
        public PantallaAnadirProducto()
        {
            InitializeComponent();
            logicaProductos = new AlmacenProductosBL();
        }

        public PantallaAnadirProducto(int idAlmacen)
        {
            InitializeComponent();
            logicaProductos = new AlmacenProductosBL();
            this.idAlmacen = idAlmacen;
            dataGridProductosRegistrables.AutoGenerateColumns = false;
            dataGridProductosRegistrables.DataSource = logicaProductos.obtenerProductosRegistrables(this.idAlmacen);
        }

        private void btnInsertarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            Producto productoSeleccionado = (Producto)dataGridProductosRegistrables.CurrentRow.DataBoundItem;
            DialogResult res = MessageBox.Show("Desea confirmar el registro del producto : \n" + productoSeleccionado.Id +
                "   "+productoSeleccionado.CodigoProducto+" "+productoSeleccionado.Nombre + " con stock inicial "+
                numericUpDown1.Value.ToString() +"?" ,"Confirmacion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (logicaProductos.registrarProductoAlmacen(this.idAlmacen, productoSeleccionado.Id, (int)numericUpDown1.Value))
                {
                    BindingList<Producto> productos = (BindingList<Producto>)dataGridProductosRegistrables.DataSource;

                    ProductoAlmacen prodAlmReciente = new ProductoAlmacen();
                    prodAlmReciente.ProductoAlmacenado = productoSeleccionado;
                    prodAlmReciente.CantidadAlmacenada = (int)numericUpDown1.Value;

                    productos.Remove(productoSeleccionado);

                    dataGridProductosRegistrables.DataSource = productos;
                    dataGridProductosRegistrables.Update();
                    dataGridProductosRegistrables.Refresh();

                    numericUpDown1.Value = 0;
                    MessageBox.Show("El producto se insertó correctamente", "Transaccion Exitosa");
                }
                else
                {
                    MessageBox.Show("El producto no se pudo insertar correctamente", "Error");
                }
            }
            
        }

        private void PantallaAnadirProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
        }

        private void dataGridProductosEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            productoSeleccionado = (Producto)dataGridProductosRegistrables.CurrentRow.DataBoundItem;
            labelNombre.Text = productoSeleccionado.Nombre;
        }

        private void btnAtras_MouseClick(object sender, MouseEventArgs e)
        {
            //PantallaAdministradorAlmacén padre = (PantallaAdministradorAlmacén)this.Owner;
            this.Dispose();
            //Almacen almacenSeleccionado =padre.obtenerAlmacenSeleccionado();
            //padre.abrirPantallaAnadirProducto(almacenSeleccionado);
        }
    }
}
