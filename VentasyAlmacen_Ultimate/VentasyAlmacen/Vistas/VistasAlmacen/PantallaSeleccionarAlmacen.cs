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
        private BindingList<Almacen> listaAlmacenes;
        private Almacen almacenSelected = null;
        public PantallaSeleccionarAlmacen()
        {
            almacenSelected = null;
            InitializeComponent();
            DataGridSelectAlmacen.AutoGenerateColumns = false;
            logicaAlmacenes = new AlmacenesBL();
            listaAlmacenes = logicaAlmacenes.obtenerAlmacenesHabilitados();
            DataGridSelectAlmacen.DataSource = listaAlmacenes;
        }
        public PantallaSeleccionarAlmacen(BindingList<Almacen> listaAlmacenesIn)
        {
            almacenSelected = null;
            listaAlmacenes = listaAlmacenesIn;
            InitializeComponent();
            btnActualizarAlmacenes.Visible = false;
            btnActualizarAlmacenes.Enabled = false;
            label1.Text = "Antes de continuar, seleccione un almacén:";
            DataGridSelectAlmacen.AutoGenerateColumns = false;
            DataGridSelectAlmacen.DataSource = listaAlmacenesIn;
        }

        private void btnSelectAlmacenSgte_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public Almacen AlmacenSeleccionado { get => almacenSelected; }

        private void btnSelectAlmacenAtras_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnActualizarAlmacenes_Click(object sender, EventArgs e)
        {
            PantallaEliminarAlmacenes newPant = new PantallaEliminarAlmacenes();
            newPant.Owner = this;
            newPant.ShowDialog();
            newPant.Dispose();
            listaAlmacenes = logicaAlmacenes.obtenerAlmacenesHabilitados();
            DataGridSelectAlmacen.DataSource = listaAlmacenes;
            DataGridSelectAlmacen.Refresh();
            DataGridSelectAlmacen.Update();
        }

        private void btnSelectAlmacenAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelectAlmacenSgte_Click(object sender, EventArgs e)
        {
            //DataGridSelectAlmacen
            Almacen almacenSeleccionado = (Almacen)DataGridSelectAlmacen.CurrentRow.DataBoundItem;

            //nombreSelected.Text = almacenSeleccionado.Direccion;
            almacenSelected = almacenSeleccionado;
            this.Visible = false;
            this.Dispose();
        }
    }
}
