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

        private int buscarProductoAlmacen(ProductoAlmacen productoAlmacen)
        {
            BindingList<ProductoAlmacen> lista = (BindingList<ProductoAlmacen>)dataGridStock.DataSource;
            int index = 0;
            foreach(ProductoAlmacen prodAlm in lista)
            {
                if (prodAlm.Id == productoAlmacen.Id)
                    return index;
                index++;
            }
            return -1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PantallaSeleccionarProducto newPant = new PantallaSeleccionarProducto(idAlmacen);
            newPant.ShowDialog();
            ProductoAlmacen productoSeleccionado = newPant.ProductoSeleccionado;
            newPant.Dispose();

            detallesPedido = (BindingList<ProductoAlmacen>)dataGridStock.DataSource;

            if (productoSeleccionado != null && buscarProductoAlmacen(productoSeleccionado) == -1)
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
            if (!verificarCamposLineaPedido())
                return;
            if(dataGridStock.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una fila para continuar", "Error");
                return;
            }
            DialogResult resultado = MessageBox.Show("Desea confirmar la solicitud?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                ProductoAlmacen productoAlmacenSeleccionado = (ProductoAlmacen)dataGridStock.CurrentRow.DataBoundItem;

                bool registroCorrecto;
                int idPedido = almacenBL.registrarPedidoProduccion(idAlmacen,out registroCorrecto);
                if (!registroCorrecto)
                {
                    MessageBox.Show("Error en la conexion. Inténtelo nuevamente.","Error");
                    return;
                }
                else
                {
                    foreach(DataGridViewRow row in dataGridStock.Rows)
                    {
                        int idProducto = Int32.Parse(row.Cells["Id"].Value.ToString());
                        int cantidadPedido = Int32.Parse(row.Cells["CantidadSolicitar"].Value.ToString());
                        string observaciones;
                        if (row.Cells["Observaciones"].Value != null)
                        {
                            observaciones = row.Cells["Observaciones"].Value.ToString();
                        }
                        else
                        {
                            observaciones = "";
                        }

                        almacenBL.registrarLineaPedido(idPedido, idProducto, cantidadPedido, observaciones, out registroCorrecto);

                        if (!registroCorrecto)
                        {
                            MessageBox.Show("Error en la conexion. Inténtelo nuevamente.");
                            //regresar borrando el pedido
                            return;
                        }
                    }
                }
                //registrar todos los detalles del pedido

                dataGridStock.DataSource = null;
                dataGridStock.Refresh();
                dataGridStock.Update();

                if (idPedido > 0)
                    MessageBox.Show("Se registró el pedido correctamente", "Éxito");
                else
                    MessageBox.Show("Ocurrió un error al registrar el pedido, inténtelo nuevamente", "Error");
            }
        }

        private bool verificarCamposLineaPedido()
        {
            foreach(DataGridViewRow row in dataGridStock.Rows)
            {
                int cantidadPedido;
                if(row.Cells["CantidadSolicitar"].Value == null || !Int32.TryParse(row.Cells["CantidadSolicitar"].Value.ToString(),out cantidadPedido) || cantidadPedido < 0)
                {
                    MessageBox.Show("Ha insertado incorrectamente una cantidad", "Error");
                    dataGridStock.CurrentCell = row.Cells["CantidadSolicitar"];
                    return false;
                }
            }
            return true;
        }

        private void dataGridStock_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column3_KeyPress);
            if (dataGridStock.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column3_KeyPress);
                }
            }
        }

        private void Column3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
