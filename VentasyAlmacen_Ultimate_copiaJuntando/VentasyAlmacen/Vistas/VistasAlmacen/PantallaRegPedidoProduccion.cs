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
    public partial class PantallaRegPedidoProduccion : Form
    {
        AlmacenProductosBL productosBL;
        AlmacenesBL almacenBL;
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

            dataGridStock.AutoGenerateColumns = false;
            dataGridStock.DataSource = productosBL.obtenerProductosAlmacen(idAlmacen);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar la solicitud?", "Confirmacion", MessageBoxButtons.YesNo);
            
            if (resultado == DialogResult.Yes)
            {
                ProductoAlmacen productoAlmacenSeleccionado = (ProductoAlmacen) dataGridStock.CurrentRow.DataBoundItem;
                int cantidad = (int)numericUpDown1.Value;
                int idPedido = almacenBL.registrarPedidoProduccion(idAlmacen,productoAlmacenSeleccionado.Id,cantidad);
                dataGridStock.Update();
                dataGridStock.Refresh();
                if(idPedido>0)
                    MessageBox.Show("Se registró el pedido correctamente","Éxito");
                else
                    MessageBox.Show("Ocurrió un error al registrar el pedido, inténtelo nuevamente", "Error");
            }
        }

        private void PantallaRegPedidoProduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
