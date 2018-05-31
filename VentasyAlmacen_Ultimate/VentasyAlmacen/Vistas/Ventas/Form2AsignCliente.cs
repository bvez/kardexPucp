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
using Entidades;

namespace Ventas
{
    public partial class Form2AsignCliente : Form
    {
        private Cliente cliente;
        private Venta venta;
        private VentasVentaBL logicaNegocios;

        public Form2AsignCliente()
        {
            InitializeComponent();
            logicaNegocios = new VentasVentaBL();
        }

        private void btn_buscaVenta_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form11BuscaVenta();
            if (BuscaVentana.ShowDialog() == DialogResult.OK)
            {
                venta = BuscaVentana.ObjetoSeleccionado;
                //carga el id a la ventanita
                mTB_IDVenta.Text = venta.Id.ToString();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_BuscaCliente_Click(object sender, EventArgs e)
        {
            var BuscaVentana = new Form12BuscaCliente();
            if (BuscaVentana.ShowDialog() == DialogResult.OK)
            {
                cliente = BuscaVentana.ObjetoSeleccionado;
                //carga el id a la ventanita
                mTB_IDCliente.Text = cliente.Id.ToString();
            }
        }
    }
}