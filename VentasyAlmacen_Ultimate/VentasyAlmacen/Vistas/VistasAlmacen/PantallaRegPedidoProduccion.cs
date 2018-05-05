using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAlmacenes
{
    public partial class PantallaRegPedidoProduccion : Form
    {
        public PantallaRegPedidoProduccion()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar la solicitud?", "Confirmacion", MessageBoxButtons.YesNo);
            
            if (resultado == DialogResult.Yes)
            {
                //productoAlmacenSeleccionado.CantidadAlmacenada = Int32.Parse(NumBoxStock.Value.ToString());
                dataGridStock.Update();
                dataGridStock.Refresh();
                MessageBox.Show("Se registró el pedido correctamente","Éxito");
            }
        }

        private void PantallaRegPedidoProduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
