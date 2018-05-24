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

namespace Ventas
{
    public partial class Form13BuscaProducto : Form
    {
        private VentasProductoBL logicaNegocios;
        private LineaProducto objetoSeleccionado;

        public LineaProducto ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        public Form13BuscaProducto()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            logicaNegocios = new VentasProductoBL();
            dataGridView1.DataSource = logicaNegocios.listarProductos();
        }

        private void Form13BuscaProducto_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } else if (numericUpDown1.Value > 0)
            {
                this.DialogResult = DialogResult.OK;
                objetoSeleccionado = new LineaProducto(Convert.ToInt32(numericUpDown1.Value), (Producto)dataGridView1.CurrentRow.DataBoundItem);
            } else MessageBox.Show("La cantidad ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}