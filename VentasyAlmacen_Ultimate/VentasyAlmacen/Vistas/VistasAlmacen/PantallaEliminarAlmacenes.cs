using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using Entidades;

namespace FormulariosAlmacenes
{
    public partial class PantallaEliminarAlmacenes : Form
    {
        AlmacenesBL logicaAlmacenes;
        public PantallaEliminarAlmacenes()
        {
            logicaAlmacenes = new AlmacenesBL();
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = logicaAlmacenes.obtenerAlmacenesTodos();
        }

        private void PantallaEliminarAlmacenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar la actualización?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                //deshabilitar almacenes
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    Almacen almacenActual = (Almacen)row.DataBoundItem;
                    if(!logicaAlmacenes.actualizarAlmacenHabilitado(almacenActual.IdAlmacen, almacenActual.Habilitado))
                    {
                        MessageBox.Show("Error en la conexion con el servidor. Inténtelo nuevamente.", "Error");
                        return;
                    }
                }

                MessageBox.Show("Se han modificado los almacenes satisfactoriamente", "Exito");
                //this.Owner.Visible = true;
                //this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxDireccion.Text !="" || textBoxTelefono.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar y perder los cambios?", "Confirmacion", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string direccionInsertar = textBoxDireccion.Text.TrimStart(" ".ToCharArray());
            if(textBoxDireccion.Text == "" || direccionInsertar=="")
            {
                MessageBox.Show("Debe insertar una direccion.", "Error");
                return;
            }

            string telefonoInsertar = textBoxTelefono.Text.TrimStart(" ".ToCharArray());
            if (textBoxTelefono.Text == "" || telefonoInsertar == "")
            {
                MessageBox.Show("Debe ingresar un número telefónico", "Error");
                return;
            }

            DialogResult resultado = MessageBox.Show("Desea confirmar el registro con direccion: " + textBoxDireccion.Text + " y telefono: " + textBoxTelefono.Text + "?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                //registrar almacen
                int idAlmacen = logicaAlmacenes.crearAlmacen(direccionInsertar, telefonoInsertar);
                if (idAlmacen >= 0)
                {
                    MessageBox.Show("Se registró el almacén correctamente", "Éxito");
                    textBoxDireccion.Text = "";
                    textBoxTelefono.Text = "";
                }
                else
                {
                    MessageBox.Show("Error en la conexion con el servidor. Inténtelo nuevamente.");
                    return;
                }

                Almacen almacen = new Almacen();
                almacen.IdAlmacen = idAlmacen;
                almacen.Direccion = direccionInsertar;
                almacen.Telefono = telefonoInsertar;
                almacen.Habilitado = true;

                ((BindingList<Almacen>)dataGridView1.DataSource).Add(almacen);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }
    }
}
