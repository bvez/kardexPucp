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
using FormulariosAlmacenes.Ventas;
using LogicaNegocios.Ventas;

namespace Ventas
{
    public partial class Form6EmitirPedAlm : Form
    {
        private BindingList<LineaProducto> listaProductos = new BindingList<LineaProducto>();
        private VentasPedidoAlmacBL logicaNegocio;

        public Form6EmitirPedAlm()
        {
            InitializeComponent();
            dg_Productos.AutoGenerateColumns = false;
            dg_Productos.AllowUserToAddRows = false;
            dg_Productos.DataSource = listaProductos;
            logicaNegocio = new VentasPedidoAlmacBL();
            mT_venta.Enabled = false;
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
            if (BuscaVentana.ShowDialog() == DialogResult.OK)
            {
                mT_venta.Text = BuscaVentana.ObjetoSeleccionado.Id.ToString();
            }
        }

        private void btn_agProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mT_venta.Text))
            {
                MessageBox.Show("No se ha seleccionado una venta");
            }
            else
            {
                Form16SelectLineaProd buscaProducto = new Form16SelectLineaProd(Int32.Parse(mT_venta.Text));
                if (buscaProducto.ShowDialog() == DialogResult.OK)
                {
                    int encontrado = 0;
                    foreach (LineaProducto lp in listaProductos)
                    {
                        if (lp == ((LineaProducto)buscaProducto.ObjetoSeleccionado))
                        {
                            MessageBox.Show("El producto ya ha sido añadido al pedido");
                            encontrado++;
                            break;
                        }
                    }
                    if (encontrado == 0)
                    {
                        listaProductos.Add((LineaProducto)buscaProducto.ObjetoSeleccionado);
                    }
                }
            }
        }

        private void btn_QuitarProd_Click(object sender, EventArgs e)
        {
            if (dg_Productos.CurrentRow.DataBoundItem != null)
            {
                listaProductos.Remove((LineaProducto)dg_Productos.CurrentRow.DataBoundItem);
                MessageBox.Show("El producto ha sido retirado de la venta", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se han seleccionado un producto de la lista", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(-1, Int32.Parse(mT_venta.Text), "Registrado", listaProductos);
            logicaNegocio.insertarPedido(pedido, null);
            MessageBox.Show("El pedido ha sido registrada exitosamente", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
