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
using LogicaNegocios;

namespace FormulariosAlmacenes
{
    public partial class PantallaAnadirProducto : Form
    {
        private Producto productoSeleccionado;
        private AlmacenProductosBL logicaProductos;
        private int idAlmacen;
        public ProductoAlmacen prodAlmReciente;
        public PantallaAnadirProducto()
        {
            InitializeComponent();
            logicaProductos = new AlmacenProductosBL();
        }

        public PantallaAnadirProducto(int idAlmacen)
        {
            InitializeComponent();
            logicaProductos = new AlmacenProductosBL();
            this.idAlmacen = idAlmacen;
            this.prodAlmReciente = null;
            dataGridProductosRegistrables.AutoGenerateColumns = false;
            dataGridProductosRegistrables.DataSource = logicaProductos.obtenerProductosRegistrables(this.idAlmacen);

            txtNumResultados.Text = ((BindingList<Producto>)dataGridProductosRegistrables.DataSource).Count.ToString() + " Resultado(s)";
            txtNumResultados.Visible = true;
        }

        private void btnInsertarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            Producto productoSeleccionado;
            if (dataGridProductosRegistrables.CurrentRow != null)
            {
                productoSeleccionado = (Producto)dataGridProductosRegistrables.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
                return;
            }

            DialogResult res = MessageBox.Show("Desea confirmar el registro del producto : \n" + productoSeleccionado.Id +
                "   "+productoSeleccionado.CodigoProducto+" "+productoSeleccionado.Nombre + " con stock inicial "+
                numericUpDown1.Value.ToString() +"?" ,"Confirmacion", MessageBoxButtons.YesNo);


            if (res == DialogResult.Yes)
            {
                if (logicaProductos.registrarProductoAlmacen(this.idAlmacen, productoSeleccionado.Id, (int)numericUpDown1.Value))
                {
                    BindingList<Producto> productos = (BindingList<Producto>)dataGridProductosRegistrables.DataSource;

                    prodAlmReciente = new ProductoAlmacen();
                    prodAlmReciente.ProductoAlmacenado = productoSeleccionado;
                    prodAlmReciente.CantidadAlmacenada = (int)Math.Round(numericUpDown1.Value);

                    productos.Remove(productoSeleccionado);

                    dataGridProductosRegistrables.DataSource = productos;
                    dataGridProductosRegistrables.Update();
                    dataGridProductosRegistrables.Refresh();

                    numericUpDown1.Value = 0;
                    MessageBox.Show("El producto se insertó correctamente", "Transaccion Exitosa");
                }
                else
                {
                    MessageBox.Show("El producto no se pudo insertar correctamente", "Error");
                }
            }
            
        }

        private void PantallaAnadirProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
        }

        private void dataGridProductosEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            productoSeleccionado = (Producto)dataGridProductosRegistrables.CurrentRow.DataBoundItem;
            labelNombre.Text = productoSeleccionado.Nombre;
        }

        private void btnAtras_MouseClick(object sender, MouseEventArgs e)
        {
            //PantallaAdministradorAlmacén padre = (PantallaAdministradorAlmacén)this.Owner;
            this.Dispose();
            //Almacen almacenSeleccionado =padre.obtenerAlmacenSeleccionado();
            //padre.abrirPantallaAnadirProducto(almacenSeleccionado);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                button1.PerformClick();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "")
            {
                txtCargando.Visible = true;
                txtCargando.Refresh();
                txtCargando.Update();

                dataGridProductosRegistrables.DataSource = logicaProductos.obtenerProductosRegistrables(this.idAlmacen,Int32.Parse(textBox1.Text), textBox2.Text);
                dataGridProductosRegistrables.Refresh();
                dataGridProductosRegistrables.Update();

                txtCargando.Visible = false;
                txtCargando.Refresh();
                txtCargando.Update();

                txtNumResultados.Text = ((BindingList<Producto>)dataGridProductosRegistrables.DataSource).Count.ToString() + " Resultado(s)";
                txtNumResultados.Refresh();
                txtNumResultados.Update();
            }
            else if(textBox2.Text != null && textBox2.Text != "")
            {
                txtCargando.Visible = true;
                txtCargando.Refresh();
                txtCargando.Update();

                dataGridProductosRegistrables.DataSource = logicaProductos.obtenerProductosRegistrables(this.idAlmacen,textBox2.Text);
                dataGridProductosRegistrables.Refresh();
                dataGridProductosRegistrables.Update();

                txtCargando.Visible = false;
                txtCargando.Refresh();
                txtCargando.Update();

                txtNumResultados.Text = ((BindingList<Producto>)dataGridProductosRegistrables.DataSource).Count.ToString() + " Resultado(s)";
                txtNumResultados.Refresh();
                txtNumResultados.Update();
            }
            else if(textBox2.Text == null || textBox2.Text == "")
            {
                txtCargando.Visible = true;
                txtCargando.Refresh();
                txtCargando.Update();

                dataGridProductosRegistrables.DataSource = logicaProductos.obtenerProductosRegistrables(this.idAlmacen);
                dataGridProductosRegistrables.Refresh();
                dataGridProductosRegistrables.Update();

                txtCargando.Visible = false;
                txtCargando.Refresh();
                txtCargando.Update();

                txtNumResultados.Text = ((BindingList<Producto>)dataGridProductosRegistrables.DataSource).Count.ToString() + " Resultado(s)";
                txtNumResultados.Refresh();
                txtNumResultados.Update();
            }
            //actualizar las etiquetas
            if(dataGridProductosRegistrables.CurrentRow != null)
            {
                labelNombre.Text = ((Producto)dataGridProductosRegistrables.CurrentRow.DataBoundItem).Nombre;
            }
            else
            {
                labelNombre.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button1.PerformClick();
            }
        }
    }
}
