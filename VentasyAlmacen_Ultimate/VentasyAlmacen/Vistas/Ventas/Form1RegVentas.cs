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
using LogicaNegocios;

namespace Ventas
{
    public partial class Form1RegVentas : Form
    {
        private BindingList<LineaProducto> listaProductos = new BindingList<LineaProducto>();
        private Form12BuscaCliente buscaVentana = null;
        private VentasVentaBL logicaNegocio;
        private DocumentoDePagoBL logicaDocPago;
        private double precioDoc;

        public Form1RegVentas()
        {
            InitializeComponent();
            dg_Productos.AutoGenerateColumns = false;
            dg_Productos.AllowUserToAddRows = false;
            dg_Productos.DataSource = listaProductos;

            logicaDocPago = new DocumentoDePagoBL();
            logicaNegocio = new VentasVentaBL();
            textBox2.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = buscaVentana.ObjetoSeleccionado;
            string estadoventa = "Registrado";
            DateTime fecharegistro = DateTime.Today;
            BindingList<LineaProducto> productosinsertar = listaProductos;
            double descuento = ((double)numericUpDown1.Value) / 100;
            string conceptodescuento = textBox1.Text;

            Venta v = new Venta(-1, cliente, estadoventa, fecharegistro, productosinsertar, descuento, conceptodescuento);
            logicaNegocio.insertarVenta(v);
            MessageBox.Show("La venta ha sido registrada exitosamente", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_agProd_Click(object sender, EventArgs e)
        {
            Form13BuscaProducto buscaProducto = new Form13BuscaProducto();
            if (buscaProducto.ShowDialog() == DialogResult.OK) {
                //listaProductos.Add(buscaProducto.ObjetoSeleccionado);
                double sum = 0d;
                int encontrado = 0;
                foreach (LineaProducto lp in listaProductos)
                {
                    if (lp.Producto.Id == ((LineaProducto)buscaProducto.ObjetoSeleccionado).Producto.Id)
                    {
                        LineaProducto aux = lp;
                        listaProductos.Remove(lp);
                        aux.Cantidad += ((LineaProducto)buscaProducto.ObjetoSeleccionado).Cantidad;
                        listaProductos.Add(aux);
                        encontrado++;
                        break;
                    }
                }
                if (encontrado == 0)
                {
                    listaProductos.Add((LineaProducto)buscaProducto.ObjetoSeleccionado);
                }

                foreach (LineaProducto lp in listaProductos)
                {
                    sum += lp.Cantidad * lp.Producto.Precio;
                }

                label_precio.Text = "Precio Total: " + sum.ToString();
                double newprecio = sum * (1 - ((double)numericUpDown1.Value / 100));
                label_precio_final.Text = "Precio Final: " + newprecio.ToString();
                precioDoc = newprecio;
            }
        }

        private void btn_QuitarProd_Click(object sender, EventArgs e)
        {
            if (dg_Productos.CurrentRow.DataBoundItem != null)
            {
                listaProductos.Remove((LineaProducto)dg_Productos.CurrentRow.DataBoundItem);
                MessageBox.Show("El producto ha sido retirado de la venta", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                double sum = 0d;
                foreach (LineaProducto lp in listaProductos)
                {
                    sum += lp.Producto.Precio;
                }
                label_precio.Text = "Precio Total" + sum.ToString();
                double newprecio = sum * (1 - ((double)numericUpDown1.Value / 100));
                label_precio_final.Text = "Precio Final: " + newprecio.ToString();
                precioDoc = newprecio;
            }
            else
            {
                MessageBox.Show("No se han seleccionado un producto de la lista", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btn_buscaCl_Click(object sender, EventArgs e)
        {
            buscaVentana = new Form12BuscaCliente();
            if (buscaVentana.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = buscaVentana.ObjetoSeleccionado.Id.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double sum = 0d;
            foreach (LineaProducto lp in listaProductos)
            {
                sum += lp.Producto.Precio;
            }
            label_precio.Text = "Precio Total" + sum.ToString();
            double newprecio = sum * (1-((double)numericUpDown1.Value / 100));
            label_precio_final.Text = "Precio Final: " + newprecio.ToString();
        }

        private void btn_regCliente_Click(object sender, EventArgs e)
        {
            Form8RegCliente regCliente = new Form8RegCliente();
            regCliente.Owner = this;
            if (regCliente.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = regCliente.IdCliente.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = buscaVentana.ObjetoSeleccionado;
            if (cliente is ClientePersona)
            {
                //generar boleta
                Boleta boleta = new Boleta((ClientePersona)cliente);
                boleta.Fecha = DateTime.Now;
                boleta.Items = listaProductos;
                boleta.Total = precioDoc;
                //generar pdf
                if (logicaDocPago.ImprimirBoleta(boleta, "prueba_boleta.pdf"))
                {
                    MessageBox.Show("Boleta generada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al generar la boleta.");
                }
                if (logicaDocPago.insertarBoleta(boleta))
                {
                    MessageBox.Show("Boleta insertada en BD correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar la boleta en BD");
                }
            }
            else
            {
                //generar factura
                Factura factura = new Factura((ClienteEmpresa)cliente);
                factura.Fecha = DateTime.Now;
                factura.Items = listaProductos;
                factura.Total = precioDoc;
                //generar pdf
                if (logicaDocPago.ImprimirFactura(factura, "prueba_factura.pdf"))
                {
                    MessageBox.Show("Factura generada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al generar la factura.");
                }
            }
        }
    }
}