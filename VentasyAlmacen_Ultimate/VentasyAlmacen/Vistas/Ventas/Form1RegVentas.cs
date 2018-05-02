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
    public partial class Form1RegVentas : Form
    {
        public Form1RegVentas()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La venta ha sido registrada exitosamente", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void btn_agProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto ha sido agregado a la venta", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_QuitarProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto ha sido retirado de la venta", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_buscaCl_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form12BuscaCliente();
            BuscaVentana.ShowDialog();
        }
    }
}
