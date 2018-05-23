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
    public partial class PantallaSeleccionarAlmacen : Form
    {
        private AlmacenesBL logicaAlmacenes;
        private Almacen almacenSelected = null;
        public PantallaSeleccionarAlmacen()
        {
            InitializeComponent();
            DataGridSelectAlmacen.AutoGenerateColumns = false;
            logicaAlmacenes = new AlmacenesBL();
            DataGridSelectAlmacen.DataSource = logicaAlmacenes.obtenerAlmacenes();
        }
        public PantallaSeleccionarAlmacen(BindingList<Almacen> listaAlmacenesIn)
        {
            InitializeComponent();
            DataGridSelectAlmacen.DataSource = listaAlmacenesIn;
        }

        private void btnSelectAlmacenSgte_MouseClick(object sender, MouseEventArgs e)
        {
            //DataGridSelectAlmacen
            Almacen almacenSeleccionado = (Almacen)DataGridSelectAlmacen.CurrentRow.DataBoundItem;
                
            //nombreSelected.Text = almacenSeleccionado.Direccion;
            almacenSelected = almacenSeleccionado;
            this.Visible = false;
            this.Dispose();
        }

        public Almacen AlmacenSeleccionado { get => almacenSelected; }

        private void btnSelectAlmacenAtras_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
