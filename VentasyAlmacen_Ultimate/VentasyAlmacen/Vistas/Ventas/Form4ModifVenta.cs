using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form4ModifVenta : Form
    {
        public Form4ModifVenta()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscaCl_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form12BuscaCliente();
            BuscaVentana.ShowDialog();
        }

        private void btn_reg_camb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los cambios han sido registrados exitosamente", "Modificar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
