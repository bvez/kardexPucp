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
    public partial class Form7RevisarPedAlm : Form
    {
        private VentasPedidoAlmacBL logicaNegocios;

        public Form7RevisarPedAlm()
        {
            InitializeComponent();
            logicaNegocios = new VentasPedidoAlmacBL();
            mT_venta.Enabled = false;
            comboBox1.Items.Add("Registrado");
            comboBox1.Items.Add("Confirmado por Almacén");
            comboBox1.Items.Add("Rechazado");
            comboBox1.Items.Add("Anulado");
            comboBox1.Items.Add("En transporte");
            comboBox1.Items.Add("Finalizado");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscaVenta_Click(object sender, EventArgs e)
        {
            Form15BuscaPedido buscaPedido = new Form15BuscaPedido();
            buscaPedido.Owner = this;
            if (buscaPedido.ShowDialog() == DialogResult.OK) {
                mT_venta.Text = buscaPedido.ObjSeleccionado.Id.ToString();
                comboBox1.SelectedItem = buscaPedido.ObjSeleccionado.Estado;
                if ((buscaPedido.ObjSeleccionado.Estado == "Rechazado")|| (buscaPedido.ObjSeleccionado.Estado == "Anulado")|| (buscaPedido.ObjSeleccionado.Estado == "Finalizado"))
                {
                    MessageBox.Show("El estado del pedido seleccionado no puede modificarse.");
                    comboBox1.Enabled = false;
                }
            }
                
        }

        private void btn_conf_estado_Click(object sender, EventArgs e)
        {
            
            if ((comboBox1.SelectedItem.ToString() == "Confirmado por Almacén")|| (comboBox1.SelectedItem.ToString() == "Rechazado"))
            {
                MessageBox.Show("Modificación de estado no autorizada", "Revisar Pedido a Almacén", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("El estado ha sido actualizado", "Revisar Pedido a Almacén", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                logicaNegocios.modificarEstado(comboBox1.SelectedItem.ToString(), Int32.Parse(mT_venta.Text));
            }
        }
    }
}