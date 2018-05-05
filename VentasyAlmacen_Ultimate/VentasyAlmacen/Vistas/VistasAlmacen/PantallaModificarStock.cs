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

namespace FormulariosAlmacenes
{
    public partial class PantallaModificarStock : Form
    {
        public PantallaModificarStock()
        {
            InitializeComponent();
        }

        public PantallaModificarStock(Almacen almacenModificar)
        {
            this.almacenModificar = almacenModificar;
            InitializeComponent();
            dataGridStock.AutoGenerateColumns = false;
            dataGridStock.DataSource = almacenModificar.Productos;
        }

        private void PantallaModificarStock_Load(object sender, EventArgs e)
        {

        }

        private void dataGridStock_SelectionChanged(object sender, EventArgs e)
        {
            productoAlmacenSeleccionado = (ProductoAlmacen)dataGridStock.CurrentRow.DataBoundItem;
            labelId.Text = productoAlmacenSeleccionado.Id;
            labelNombre.Text = productoAlmacenSeleccionado.Nombre;
            labelStock.Text = productoAlmacenSeleccionado.CantidadAlmacenada.ToString();
            NumBoxStock.Value = productoAlmacenSeleccionado.CantidadAlmacenada;
        }

        private void buttonUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado =  MessageBox.Show("Desea confirmar la actualización?", "Confirmacion", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                productoAlmacenSeleccionado.CantidadAlmacenada = Int32.Parse(NumBoxStock.Value.ToString());
                MessageBox.Show("Se actualizó el stock correctamente", "Éxito");
                dataGridStock.Update();
                dataGridStock.Refresh();
            }
            else if(resultado == DialogResult.No)
            {
                NumBoxStock.Value = productoAlmacenSeleccionado.CantidadAlmacenada;
            }
        }

        ProductoAlmacen productoAlmacenSeleccionado;
        Almacen almacenModificar;

        private void buttonAtras_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
