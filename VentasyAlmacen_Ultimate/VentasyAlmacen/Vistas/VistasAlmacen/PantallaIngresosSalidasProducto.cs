using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaIngresosSalidasProducto : Form
    {
        private int idAlmacen;
        public PantallaIngresosSalidasProducto()
        {
            InitializeComponent();
        }

        public PantallaIngresosSalidasProducto(int idAlmacen)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if(dataGridPedido.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Desea salir y eliminar los cambios?", "Confirmación", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
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

        private void radioBtnSalida_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*Mostrar los productos */
            PantallaSeleccionarProducto newPant = new PantallaSeleccionarProducto();
            newPant.ShowDialog();
        }
    }
}
