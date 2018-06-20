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
    public partial class PantallaActualizarAlmacenes : Form
    {
        public PantallaActualizarAlmacenes()
        {
            InitializeComponent();
        }

        private void PantallaActualizarAlmacenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
        }

        private void btnInsertAlmacen_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaInsertarAlmacen newPant = new PantallaInsertarAlmacen();
            newPant.Owner = this;
            this.Visible = false;
            newPant.ShowDialog();
        }

        private void btnInhabilitarAlmacen_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaEliminarAlmacenes newPant = new PantallaEliminarAlmacenes();
            newPant.Owner = this;
            this.Visible = false;
            newPant.ShowDialog();
        }
    }
}
