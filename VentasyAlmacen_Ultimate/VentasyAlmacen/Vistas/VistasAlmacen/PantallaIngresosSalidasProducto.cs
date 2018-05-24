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
            dataGridIngresoSalida.AutoGenerateColumns = false;
            dataGridIngresoSalida.DataSource = listaProductos;
        }

        public PantallaIngresosSalidasProducto(int idAlmacen)
        {
            InitializeComponent();
            radioBtnEnvios.Checked = true;
            this.idAlmacen = idAlmacen;
            listaProductos = new BindingList<ProductoAlmacen>();
            logicaAlmacenes = new AlmacenesBL();

            dataGridIngresoSalida.AutoGenerateColumns = false;
            dataGridIngresoSalida.DataSource = listaProductos;

            comboBoxAlmacenes.DataSource = logicaAlmacenes.obtenerAlmacenes();

            Almacen almacenActual = logicaAlmacenes.obtenerAlmacen(idAlmacen);
            
            comboBoxEnvios.DataSource = null;
            comboBoxLocales.DataSource = logicaAlmacenes.obtenerLocales();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int cantidadPedidos = dataGridIngresoSalida.RowCount;

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
            if (radioBtnIngreso.Checked) {
                labelAlmacen.Visible = false;
                comboBoxAlmacenes.Visible = false;

                groupBox3.Visible = true;
            }
            
        }

        private void radioBtnSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSalida.Checked)
            {
                groupBox3.Visible = false;

                labelAlmacen.Visible = true;
                comboBoxAlmacenes.Visible = true;
            }

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
                ((BindingList<ProductoAlmacen>)dataGridIngresoSalida.DataSource).Add(nuevoProducto);
                dataGridIngresoSalida.Refresh();
                dataGridIngresoSalida.Update();
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridIngresoSalida.CurrentRow != null)
            {
                ProductoAlmacen productoSeleccionado = (ProductoAlmacen)dataGridIngresoSalida.CurrentRow.DataBoundItem;
                BindingList<ProductoAlmacen> lista = (BindingList<ProductoAlmacen>)dataGridIngresoSalida.DataSource;
                lista.Remove(productoSeleccionado);
                dataGridIngresoSalida.Refresh();
                dataGridIngresoSalida.Update();
            }
        }

        private void PantallaIngresosSalidasProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridIngresoSalida.RowCount > 0)
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

        private void radioBtnEnvios_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnEnvios.Checked)
            {
                comboBoxLocales.Enabled = false;
                comboBoxEnvios.Enabled = true;

                if(comboBoxEnvios.SelectedItem != null)
                {
                    comboBoxEnvios.SelectedItem;
                    dataGridIngresoSalida.DataSource = logicaAlmacenes.obtenerProductosSalida();
                }
            }
        }

        private void radioBtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnLocal.Checked)
            {
                comboBoxEnvios.Enabled = false;
                comboBoxLocales.Enabled = true;
            }
        }
    }
}
