using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios.Ventas;
using Entidades;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form15BuscaPedido : Form
    {
        private VentasPedidoAlmacBL logicaNegocios;
        private Pedido objSeleccionado;

        public Form15BuscaPedido()
        {
            InitializeComponent();
            logicaNegocios = new VentasPedidoAlmacBL();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = logicaNegocios.listarPedidos();
        }

        public Pedido ObjSeleccionado { get => objSeleccionado; set => objSeleccionado = value; }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count <= 0)
            {
                MessageBox.Show("No se ha seleccionado un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                objSeleccionado = (Pedido)dataGridView1.CurrentRow.DataBoundItem;
            }
        }
    }
}
