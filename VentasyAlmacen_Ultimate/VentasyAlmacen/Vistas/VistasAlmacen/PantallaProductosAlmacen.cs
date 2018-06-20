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
    public partial class PantallaProductosAlmacen : Form
    {
        private AlmacenProductosBL almacenProductos;
        private int idAlmacen;
        private ProductoAlmacen productoAlmacenSeleccionado;
        private AlmacenProductosBL productosBL;
        public PantallaProductosAlmacen()
        {
            InitializeComponent();
            
        }

        //inicializacion con lista de productos
        public PantallaProductosAlmacen(int idAlmacen)
        {
            productosBL = new AlmacenProductosBL();
            almacenProductos = new AlmacenProductosBL();
            //BindingList<int> enteros = new BindingList<int>();
            InitializeComponent();
            tablaProductosAlmacen.AutoGenerateColumns = false;
            tablaProductosAlmacen.DataSource = almacenProductos.obtenerProductosAlmacen(idAlmacen);
            this.idAlmacen = idAlmacen;
        }

        public PantallaProductosAlmacen(int idAlmacen,char tipoUser)
        {
            productosBL = new AlmacenProductosBL();
            almacenProductos = new AlmacenProductosBL();
            //BindingList<int> enteros = new BindingList<int>();
            InitializeComponent();
            this.idAlmacen = idAlmacen;
            if(tipoUser == 'A')
            {
                //admin
                this.Height = 510;
                this.Width = 841;
                btnInsertarProducto.Enabled = true;
                btnModificarStock.Enabled = true;
                button2.Location = new Point(685, 367);
            }
            else if (tipoUser == 'U')
            {
                //usuario normal
                this.Height = 523;
                this.Width = 510;
                btnInsertarProducto.Enabled = false;
                btnModificarStock.Enabled = false;
                button2.Location = new Point(352, 433);
            }
            tablaProductosAlmacen.AutoGenerateColumns = false;
            tablaProductosAlmacen.DataSource = almacenProductos.obtenerProductosAlmacen(idAlmacen);

            txtNumResultados.Text = ((BindingList<ProductoAlmacen>)tablaProductosAlmacen.DataSource).Count.ToString() + " Resultado(s)";
            txtNumResultados.Visible = true;
        }

        //Lo que sucede cuando se cierra el formulario
        private void PantallaProductosAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                int idBuscar = Int32.Parse(textBoxId.Text);

                txtCargando.Visible = true;
                txtCargando.Refresh();
                txtCargando.Update();

                tablaProductosAlmacen.DataSource = almacenProductos.obtenerProductosAlmacen(this.idAlmacen, idBuscar, textBoxNombre.Text, (int)Math.Round(numStockMin.Value), (int)Math.Round(numStockMax.Value));
                tablaProductosAlmacen.Refresh();
                tablaProductosAlmacen.Update();

                txtCargando.Visible = false;
                txtCargando.Refresh();
                txtCargando.Update();

                txtNumResultados.Text = ((BindingList<ProductoAlmacen>)tablaProductosAlmacen.DataSource).Count.ToString() + " Resultado(s)";
                txtNumResultados.Refresh();
                txtNumResultados.Update();
            }
            else
            {
                txtCargando.Visible = true;
                txtCargando.Refresh();
                txtCargando.Update();

                tablaProductosAlmacen.DataSource = almacenProductos.obtenerProductosAlmacen(this.idAlmacen, textBoxNombre.Text, (int)Math.Round(numStockMin.Value), (int)Math.Round(numStockMax.Value));
                tablaProductosAlmacen.Refresh();
                tablaProductosAlmacen.Update();

                txtCargando.Visible = false;
                txtCargando.Refresh();
                txtCargando.Update();

                txtNumResultados.Text = ((BindingList<ProductoAlmacen>)tablaProductosAlmacen.DataSource).Count.ToString() + " Resultado(s)";
                txtNumResultados.Refresh();
                txtNumResultados.Update();
            }

            if (tablaProductosAlmacen.CurrentRow != null)
            {
                nombreSeleccionado.Text = ((ProductoAlmacen)tablaProductosAlmacen.CurrentRow.DataBoundItem).Nombre;
                stockActualSeleccionado.Text = ((ProductoAlmacen)tablaProductosAlmacen.CurrentRow.DataBoundItem).CantidadAlmacenada.ToString();
                nuevoStockNumBox.Value = ((ProductoAlmacen)tablaProductosAlmacen.CurrentRow.DataBoundItem).CantidadAlmacenada;
            }
            else
            {
                stockActualSeleccionado.Text = nombreSeleccionado.Text = "";
                nuevoStockNumBox.Value = 0;
            }
            
        }

        private void numStockMin_ValueChanged(object sender, EventArgs e)
        {
            if (numStockMin.Value >= numStockMax.Value)
            {
                numStockMax.Value = numStockMin.Value;
            }
        }

        private void numStockMax_ValueChanged(object sender, EventArgs e)
        {
            if(numStockMax.Value <= numStockMin.Value)
            {
                numStockMin.Value = numStockMax.Value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tablaProductosAlmacen.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
                return;
            }

            if (Math.Round(nuevoStockNumBox.Value) == Int32.Parse(stockActualSeleccionado.Text))
                return;
            
            DialogResult resultado = MessageBox.Show("Desea confirmar la actualización?", "Confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int nuevoStock = (int)nuevoStockNumBox.Value;
                if (productosBL.actualizarStock(idAlmacen, productoAlmacenSeleccionado.Id, nuevoStock))
                {
                    productoAlmacenSeleccionado.CantidadAlmacenada = Int32.Parse(nuevoStock.ToString());
                    MessageBox.Show("Se actualizó el stock correctamente", "Éxito");
                    tablaProductosAlmacen.Update();
                    tablaProductosAlmacen.Refresh();
                    this.actualizarInfoSeleccionado();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar", "Error");
                }
            }
            else if (resultado == DialogResult.No)
            {
                nuevoStockNumBox.Value = productoAlmacenSeleccionado.CantidadAlmacenada;
            }
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            PantallaAnadirProducto pantalla = new PantallaAnadirProducto(this.idAlmacen);
            pantalla.ShowDialog();
            if (pantalla.prodAlmReciente != null)
            {
                ((BindingList<ProductoAlmacen>)tablaProductosAlmacen.DataSource).Add(pantalla.prodAlmReciente);
                tablaProductosAlmacen.Refresh();
                tablaProductosAlmacen.Update();
            }
            pantalla.Dispose();
        }

        private void tablaProductosAlmacen_SelectionChanged(object sender, EventArgs e)
        {
            productoAlmacenSeleccionado = (ProductoAlmacen)tablaProductosAlmacen.CurrentRow.DataBoundItem;
            this.actualizarInfoSeleccionado();
        }

        private void actualizarInfoSeleccionado()
        {
            nombreSeleccionado.Text = productoAlmacenSeleccionado.Nombre;
            stockActualSeleccionado.Text = productoAlmacenSeleccionado.CantidadAlmacenada.ToString();
            //Console.WriteLine(productoAlmacenSeleccionado.CantidadAlmacenada);
            nuevoStockNumBox.Value = productoAlmacenSeleccionado.CantidadAlmacenada;
        }

        private void nuevoStockNumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                PantallaAdministradorAlmacén padre = (PantallaAdministradorAlmacén)this.Owner;
                this.Dispose();
                Almacen almacenSeleccionado = padre.obtenerAlmacenSeleccionado();
                padre.abrirPantallaProductosAlmacen(almacenSeleccionado);
            }
            catch(Exception excepcion)//entra aqui porque su padre no es administrador
            {
                this.Dispose();
            }
            */

            /*
            if(this.Owner is PantallaAdministradorAlmacén)
            {
                PantallaAdministradorAlmacén padre = (PantallaAdministradorAlmacén)this.Owner;
                this.Dispose();
                Almacen almacenSeleccionado = padre.obtenerAlmacenSeleccionado();
                padre.abrirPantallaProductosAlmacen(almacenSeleccionado);
            }
            else
            {
                this.Dispose();
            }*/
            this.Dispose();
        }
    }
}
