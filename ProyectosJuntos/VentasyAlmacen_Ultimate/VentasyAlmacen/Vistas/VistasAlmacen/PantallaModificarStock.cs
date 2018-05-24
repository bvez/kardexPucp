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
    public partial class PantallaModificarStock : Form
    {
        private AlmacenProductosBL productosBL;
        ProductoAlmacen productoAlmacenSeleccionado;
        Almacen almacenModificar;
        public PantallaModificarStock()
        {
            InitializeComponent();
        }

        public PantallaModificarStock(Almacen almacenModificar)
        {
            productosBL = new AlmacenProductosBL();
            this.almacenModificar = almacenModificar;
            InitializeComponent();
            dataGridStock.AutoGenerateColumns = false;
            dataGridStock.DataSource = productosBL.obtenerProductosAlmacen(almacenModificar.IdAlmacen);
        }

        private void dataGridStock_SelectionChanged(object sender, EventArgs e)
        {
            productoAlmacenSeleccionado = (ProductoAlmacen)dataGridStock.CurrentRow.DataBoundItem;
            this.actualizarInfoSeleccionado();
        }

        private void buttonUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado =  MessageBox.Show("Desea confirmar la actualización?", "Confirmacion", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                int nuevoStock = (int)NumBoxStock.Value;
                if (productosBL.actualizarStock(almacenModificar.IdAlmacen,productoAlmacenSeleccionado.Id,nuevoStock))
                {
                    productoAlmacenSeleccionado.CantidadAlmacenada = Int32.Parse(nuevoStock.ToString());
                    MessageBox.Show("Se actualizó el stock correctamente", "Éxito");
                    dataGridStock.Update();
                    dataGridStock.Refresh();
                    this.actualizarInfoSeleccionado();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar", "Error");
                }
            }
            else if(resultado == DialogResult.No)
            {
                NumBoxStock.Value = productoAlmacenSeleccionado.CantidadAlmacenada;
            }
        }

        private void actualizarInfoSeleccionado()
        {
            labelId.Text = productoAlmacenSeleccionado.Id.ToString();
            labelNombre.Text = productoAlmacenSeleccionado.Nombre;
            labelStock.Text = productoAlmacenSeleccionado.CantidadAlmacenada.ToString();
            NumBoxStock.Value = productoAlmacenSeleccionado.CantidadAlmacenada;
        }

        private void buttonAtras_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaAdministradorAlmacén padre = (PantallaAdministradorAlmacén)this.Owner;
            this.Dispose();
            Almacen almacenSeleccionado = padre.obtenerAlmacenSeleccionado();
            padre.abrirPantallaModificarStock(almacenSeleccionado);
        }
    }
}
