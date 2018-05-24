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
    public partial class Form6EmitirPedAlm : Form
    {
        public Form6EmitirPedAlm()
        {
            InitializeComponent();
        }

        private void mT_venta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscaVenta_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form11BuscaVenta();
            BuscaVentana.ShowDialog();
        }

        private void btn_agProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto ha sido agregado al pedido", "Emitir Pedido a Almacén", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_QuitarProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto ha sido retirado del pedido", "Emitir Pedido a Almacén", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El pedido ha sido registrado con éxito", "Emitir Pedido a Almacén", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
