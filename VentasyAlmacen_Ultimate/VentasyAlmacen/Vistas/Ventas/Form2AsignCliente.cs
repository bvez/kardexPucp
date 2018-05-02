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
    public partial class Form2AsignCliente : Form
    {
        public Form2AsignCliente()
        {
            InitializeComponent();
        }

        private void btn_buscaVenta_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form11BuscaVenta();
            BuscaVentana.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscaCliente_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form12BuscaCliente();
            BuscaVentana.ShowDialog();
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente ha sido asignado con éxito a la venta", "Asignar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
