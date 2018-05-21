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

namespace FormulariosAlmacenes
{
    public partial class PantallaInsertarAlmacen : Form
    {
        public PantallaInsertarAlmacen()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = (new AlmacenesBL()).obtenerSucursalesDisponibles();
        }

        private void PantallaInsertarAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar el registro con direccion: \" "+ textBoxDireccion.Text +"\" y telefono: "+ textBoxTelefono.Text +"?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Se registró el almacén correctamente", "Éxito");
            }
        }
    }
}
