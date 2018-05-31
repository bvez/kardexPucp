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
    public partial class Form5RevisarVenta : Form
    {
        private VentasVentaBL logicaNegocios;
        public Form5RevisarVenta()
        {
            InitializeComponent();
            logicaNegocios = new VentasVentaBL();
            mT_venta.Enabled = false;
            comboBox1.Items.Add("Registrado");
            comboBox1.Items.Add("Confirmado");
            comboBox1.Items.Add("Anulado");
            comboBox1.Items.Add("En despacho");
            comboBox1.Items.Add("Finalizado");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscaVenta_Click(object sender, EventArgs e)
        {
            Form11BuscaVenta buscaVenta = new Form11BuscaVenta();
            buscaVenta.Owner = this;
            if (buscaVenta.ShowDialog() == DialogResult.OK)
            {
                mT_venta.Text = buscaVenta.ObjetoSeleccionado.Id.ToString();
                comboBox1.SelectedItem = buscaVenta.ObjetoSeleccionado.Estado;
                if ((buscaVenta.ObjetoSeleccionado.Estado == "Finalizado") || (buscaVenta.ObjetoSeleccionado.Estado == "Anulado"))
                {
                    MessageBox.Show("El estado del pedido seleccionado no puede modificarse.");
                    comboBox1.Enabled = false;
                }
            }
        }

        private void btn_conf_estado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El estado ha sido actualizado", "Revisar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            logicaNegocios.modificarEstado(comboBox1.SelectedItem.ToString(), Int32.Parse(mT_venta.Text));
        }
    }
}