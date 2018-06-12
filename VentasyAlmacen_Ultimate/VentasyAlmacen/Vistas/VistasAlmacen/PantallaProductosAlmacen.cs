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
        public PantallaProductosAlmacen()
        {
            InitializeComponent();
            
        }

        //inicializacion con lista de productos
        public PantallaProductosAlmacen(int idAlmacen)
        {
            almacenProductos = new AlmacenProductosBL();
            //BindingList<int> enteros = new BindingList<int>();
            InitializeComponent();
            tablaProductosAlmacen.AutoGenerateColumns = false;
            tablaProductosAlmacen.DataSource = almacenProductos.obtenerProductosAlmacen(idAlmacen);
        }

        //Lo que sucede cuando se cierra el formulario
        private void PantallaProductosAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button2_MouseClick(object sender, MouseEventArgs e)
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
