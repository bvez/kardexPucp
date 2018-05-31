using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios.Ventas;

namespace Ventas
{
    public partial class Form14AnularVenta : Form
    {
        private VentasVentaBL logicaNegocios;

        public Form14AnularVenta()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            logicaNegocios = new VentasVentaBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11BuscaVenta busca = new Form11BuscaVenta();
            busca.Owner = this;
            if (busca.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = busca.ObjetoSeleccionado.Id.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logicaNegocios.anularVenta(Int32.Parse(textBox1.Text));
            MessageBox.Show("Venta anulada con éxito");
        }
    }
}
