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
using LogicaNegocios.Ventas;

namespace FormulariosAlmacenes.Ventas
{
    public partial class Form16SelectLineaProd : Form
    {
        private VentasVentaBL logicaNegocios;
        private LineaProducto objetoSeleccionado;

        public LineaProducto ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        public Form16SelectLineaProd(int id_venta)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            logicaNegocios = new VentasVentaBL();
            dataGridView1.DataSource = logicaNegocios.lineasVenta(id_venta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count <= 0)
            {
                MessageBox.Show("No se ha seleccionado una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                objetoSeleccionado = (LineaProducto)dataGridView1.CurrentRow.DataBoundItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
