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
    public partial class PantallaRegSalidaProducto : Form
    {
        public PantallaRegSalidaProducto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar el egreso?", "Confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //productoAlmacenSeleccionado.CantidadAlmacenada = Int32.Parse(NumBoxStock.Value.ToString());
                dataGridStock.Update();
                dataGridStock.Refresh();
                MessageBox.Show("Se registró el egreso correctamente", "Éxito");
            }
        }

        private void PantallaRegSalidaProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
