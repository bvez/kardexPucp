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
    public partial class PantallaSeleccionarAlmacen : Form
    {
        public PantallaSeleccionarAlmacen()
        {
            //cargarAlmacenes();
            InitializeComponent();
            //DataGridSelectAlmacen.DataSource = listaAlmacenes;
        }
        public PantallaSeleccionarAlmacen(BindingList<Almacen> listaAlmacenesIn)
        {
            InitializeComponent();
            DataGridSelectAlmacen.DataSource = listaAlmacenesIn;
        }

        public void cargarAlmacenes()
        {
            Almacen almacen1 = new Almacen();
            almacen1.CodigoAlmacen = "Almacen 1";
            almacen1.CodigoSucursal = "Sucursal 1";
            almacen1.Direccion = "Direccion de almacen 1";
            almacen1.Telefono = "111-1111";

            Almacen almacen2 = new Almacen();
            almacen2.CodigoAlmacen = "Almacen 2";
            almacen2.CodigoSucursal = "Sucursal 2";
            almacen2.Direccion = "Direccion de almacen 2";
            almacen2.Telefono = "222-2222";

            //listaAlmacenes.Add(almacen1);
            //listaAlmacenes.Add(almacen2);
        }
        private void btnSelectAlmacenSgte_MouseClick(object sender, MouseEventArgs e)
        {
            //DataGridSelectAlmacen
            Almacen almacenSeleccionado = (Almacen)DataGridSelectAlmacen.CurrentRow.DataBoundItem;
            //nombreSelected.Text = almacenSeleccionado.Direccion;
            almacenSelected = almacenSeleccionado;
            this.Visible = false;
            //this.Dispose();
        }

        private Almacen almacenSelected = null;

        public Almacen AlmacenSeleccionado { get => almacenSelected; }

        private void btnSelectAlmacenAtras_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
