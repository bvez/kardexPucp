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

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaIngresosSalidasProducto : Form
    {
        private int idAlmacen;
        private BindingList<ProductoAlmacen> listaProductos = null;
        private AlmacenesBL logicaAlmacenes = null;
        public PantallaIngresosSalidasProducto()
        {
            InitializeComponent();
            listaProductos = new BindingList<ProductoAlmacen>();
            dataGridPedido.AutoGenerateColumns = false;
            dataGridPedido.DataSource = listaProductos;
        }

        public PantallaIngresosSalidasProducto(int idAlmacen)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;
            listaProductos = new BindingList<ProductoAlmacen>();
            logicaAlmacenes = new AlmacenesBL();

            dataGridPedido.AutoGenerateColumns = false;
            dataGridPedido.DataSource = listaProductos;

            comboBoxAlmacenes.DataSource = logicaAlmacenes.obtenerAlmacenes();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int cantidadPedidos = dataGridPedido.RowCount;

            if (cantidadPedidos > 0)
            {
                string mensajeConf = "Desea confirmar ";
                if (radioBtnIngreso.Checked)
                {
                    mensajeConf += "el ingreso de ";
                }
                else if (radioBtnSalida.Checked)
                {
                    mensajeConf += "la salida de ";
                }

                mensajeConf += cantidadPedidos.ToString() + " producto";
                if (cantidadPedidos > 1)
                {
                    mensajeConf += "s?";
                }

                DialogResult res = MessageBox.Show(mensajeConf, "Confirmacion", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    //registrar pedido ingreso o salida
                }
            }
            else
            {
                MessageBox.Show("Debe registrar mínimo un ingreso/salida", "Error");
            }
            
        }

        private void radioBtnIngreso_CheckedChanged(object sender, EventArgs e)
        {
            labelAlmacen.Visible = false;
            comboBoxAlmacenes.Visible = false;

            labelEnvio.Visible = true;
            comboBoxEnvios.Visible = true;
        }

        private void radioBtnSalida_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvio.Visible = false;
            comboBoxEnvios.Visible = false;

            labelAlmacen.Visible = true;
            comboBoxAlmacenes.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*Mostrar los productos */
            ProductoAlmacen nuevoProducto;
            PantallaSeleccionarProducto newPant = new PantallaSeleccionarProducto(this.idAlmacen);
            newPant.ShowDialog();
            nuevoProducto = newPant.ProductoSeleccionado;
            if (nuevoProducto != null)
            {
                ((BindingList<ProductoAlmacen>)dataGridPedido.DataSource).Add(nuevoProducto);
                dataGridPedido.Refresh();
                dataGridPedido.Update();
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridPedido.CurrentRow != null)
            {
                ProductoAlmacen productoSeleccionado = (ProductoAlmacen)dataGridPedido.CurrentRow.DataBoundItem;
                BindingList<ProductoAlmacen> lista = (BindingList<ProductoAlmacen>)dataGridPedido.DataSource;
                lista.Remove(productoSeleccionado);
                dataGridPedido.Refresh();
                dataGridPedido.Update();
            }
        }

        private void PantallaIngresosSalidasProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridPedido.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Desea salir y eliminar los cambios?", "Confirmación", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
        }

        
    }
}
