using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAlmacenes
{
    public partial class PantallaEliminarAlmacenes : Form
    {
        public PantallaEliminarAlmacenes()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar la actualización?", "Confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //deshabilitar almacenes
                MessageBox.Show("Se han deshabilitado los almacenes satisfactoriamente", "Exito");
                this.Owner.Visible = true;
                this.Close();
            }
            
        }
    }
}
