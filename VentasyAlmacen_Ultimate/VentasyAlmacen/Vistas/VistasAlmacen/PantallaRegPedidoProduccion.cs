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
using FormulariosAlmacenes.VistasAlmacen;


namespace FormulariosAlmacenes
{
    public partial class PantallaRegPedidoProduccion : Form
    {
        AlmacenProductosBL productosBL;
        AlmacenesBL almacenBL;
        BindingList<ProductoAlmacen> detallesPedido;
        int idAlmacen;
        //atributo del objeto Usuario

        public PantallaRegPedidoProduccion()
        {
            productosBL = new AlmacenProductosBL();
            almacenBL = new AlmacenesBL();
            InitializeComponent();
        }
        public PantallaRegPedidoProduccion(int idAlmacen)
        {
            productosBL = new AlmacenProductosBL();
            almacenBL = new AlmacenesBL();
            this.idAlmacen = idAlmacen;
            InitializeComponent();
            detallesPedido = new BindingList<ProductoAlmacen>();

            dataGridStock.AutoGenerateColumns = false;
            dataGridStock.DataSource = detallesPedido;
        }

        private void PantallaRegPedidoProduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PantallaSeleccionarProducto newPant = new PantallaSeleccionarProducto(idAlmacen);
            newPant.ShowDialog();
            ProductoAlmacen productoSeleccionado = newPant.ProductoSeleccionado;
            newPant.Dispose();

            detallesPedido = (BindingList<ProductoAlmacen>)dataGridStock.DataSource;

            if (productoSeleccionado != null)
                detallesPedido.Add(productoSeleccionado);

            dataGridStock.Update();
            dataGridStock.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridStock.CurrentRow != null)
            {
                ProductoAlmacen productoSeleccionado = (ProductoAlmacen)dataGridStock.CurrentRow.DataBoundItem;
                BindingList<ProductoAlmacen> lista = (BindingList<ProductoAlmacen>)dataGridStock.DataSource;
                lista.Remove(productoSeleccionado);
                dataGridStock.Refresh();
                dataGridStock.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar la solicitud?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                ProductoAlmacen productoAlmacenSeleccionado = (ProductoAlmacen)dataGridStock.CurrentRow.DataBoundItem;

                int idPedido = almacenBL.registrarPedidoProduccion(idAlmacen);



                if (idPedido > 0)
                    MessageBox.Show("Se registró el pedido correctamente", "Éxito");
                else
                    MessageBox.Show("Ocurrió un error al registrar el pedido, inténtelo nuevamente", "Error");
            }
        }
    }
}
