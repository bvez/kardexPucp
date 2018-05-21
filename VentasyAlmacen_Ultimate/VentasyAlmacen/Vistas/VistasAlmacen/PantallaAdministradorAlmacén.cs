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
using FormulariosAlmacenes.VistasAlmacen;
using LogicaNegocios;

namespace FormulariosAlmacenes
{
    public partial class PantallaAdministradorAlmacén : Form
    {
        public PantallaAdministradorAlmacén()
        {
            InitializeComponent();
        }
        public PantallaAdministradorAlmacén(string nombre)
        {
            InitializeComponent();
            labelBienvenidaAdmin.Text = "Bienvenido " + nombre;
        }

        //lo que sucede cuando la pantalla de administrador se cierra
        private void PantallaAdministradorAlmacén_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Enabled = true;//el padre se activa
            this.Owner.Visible = true;
        }


        private void btnProductosDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;
            Almacen almacenSeleccionado;

            //seleccion de almacen
            pantallaAlmacenes = new PantallaSeleccionarAlmacen();
            pantallaAlmacenes.ShowDialog();

            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;


            if(almacenSeleccionado != null)
            {
                PantallaProductosAlmacen pantallaProductos = new PantallaProductosAlmacen(almacenSeleccionado.IdAlmacen);
                pantallaProductos.Owner = this;
                //this.Visible = false;
                pantallaProductos.ShowDialog();
            }
            
        }

        private void BtnAnadirProducto_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;
            Almacen almacenSeleccionado;

            //seleccion de almacen
            pantallaAlmacenes = new PantallaSeleccionarAlmacen();
            pantallaAlmacenes.ShowDialog();
            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            if(almacenSeleccionado!= null)
            {
                PantallaAnadirProducto pantallaAnadirProducto = new PantallaAnadirProducto(almacenSeleccionado.IdAlmacen);
                //pantallaAnadirProducto.Owner = this;
                //this.Visible = false;
                pantallaAnadirProducto.ShowDialog();
            }
            
        }

        private void btnActualizarAlmacenes_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaActualizarAlmacenes pantallaActualizarAlmacenes = new PantallaActualizarAlmacenes();
            pantallaActualizarAlmacenes.Owner = this;
            //this.Visible = false;
            pantallaActualizarAlmacenes.ShowDialog();
        }

        private void btnModificarStock_MouseClick(object sender, MouseEventArgs e)
        {
            this.ModificarStock();
        }

        public void ModificarStock()
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;

            Almacen almacenSeleccionado;

            //seleccion de almacen
            pantallaAlmacenes = new PantallaSeleccionarAlmacen();
            pantallaAlmacenes.ShowDialog();

            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            if (almacenSeleccionado != null)
            {
                PantallaModificarStock pantallaStock = new PantallaModificarStock(almacenSeleccionado);
                pantallaStock.ShowDialog();
            }
        }

        private void buttonCerrarSesion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;
            Almacen almacenSeleccionado;

            pantallaAlmacenes = new PantallaSeleccionarAlmacen();
            pantallaAlmacenes.ShowDialog();

            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            if (almacenSeleccionado != null)
            {
                PantallaReporteFechas pantallaReporte = new PantallaReporteFechas();
                pantallaReporte.Owner = this;
                pantallaReporte.ShowDialog();
            }
        }
    }
}
