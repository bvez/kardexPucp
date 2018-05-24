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
    public partial class Form7RevisarPedAlm : Form
    {
        public Form7RevisarPedAlm()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscaVenta_Click(object sender, EventArgs e)
        {

        }

        private void btn_conf_estado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El estado ha sido actualizado", "Revisar Pedido a Almacén", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
