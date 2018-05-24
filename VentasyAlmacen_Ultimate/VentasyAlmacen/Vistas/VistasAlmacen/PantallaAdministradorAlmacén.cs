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

        public Almacen obtenerAlmacenSeleccionado()
        {
            Almacen almacenSeleccionado;
            PantallaSeleccionarAlmacen pantallaAlmacenes;

            pantallaAlmacenes = new PantallaSeleccionarAlmacen();
            pantallaAlmacenes.ShowDialog();

            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;
            return almacenSeleccionado;
        }

        //lo que sucede cuando la pantalla de administrador se cierra
        private void PantallaAdministradorAlmacén_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Enabled = true;//el padre se activa
            ((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            this.Owner.Visible = true;
        }


        private void btnProductosDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            Almacen almacenSeleccionado = obtenerAlmacenSeleccionado();
            abrirPantallaProductosAlmacen(almacenSeleccionado);
        }

        public void abrirPantallaProductosAlmacen(Almacen almacenSeleccionado)
        {
            if (almacenSeleccionado != null)
            {
                PantallaProductosAlmacen pantallaProductos = new PantallaProductosAlmacen(almacenSeleccionado.IdAlmacen);
                pantallaProductos.Owner = this;
                //this.Visible = false;
                pantallaProductos.ShowDialog();
            }
        }

        private void BtnAnadirProducto_MouseClick(object sender, MouseEventArgs e)
        {
            Almacen almacenSeleccionado = obtenerAlmacenSeleccionado() ;
            abrirPantallaAnadirProducto(almacenSeleccionado);
            
        }
        public void abrirPantallaAnadirProducto(Almacen almacenSeleccionado)
        {
            if (almacenSeleccionado != null)
            {
                PantallaAnadirProducto pantallaAnadirProducto = new PantallaAnadirProducto(almacenSeleccionado.IdAlmacen);
                pantallaAnadirProducto.Owner = this;
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

        private void btnActualizarAlmacenes_Click(object sender, EventArgs e)
        {
            PantallaActualizarAlmacenes pantallaActualizarAlmacenes = new PantallaActualizarAlmacenes();
            pantallaActualizarAlmacenes.Owner = this;
            pantallaActualizarAlmacenes.ShowDialog();
        }

        private void btnModificarStock_MouseClick(object sender, MouseEventArgs e)
        {
            Almacen almacenSeleccionado = obtenerAlmacenSeleccionado();
            abrirPantallaModificarStock(almacenSeleccionado);
        }

        public void abrirPantallaModificarStock(Almacen almacenSeleccionado)
        {
            if (almacenSeleccionado != null)
            {
                PantallaModificarStock pantallaStock = new PantallaModificarStock(almacenSeleccionado);
                pantallaStock.Owner = this;
                pantallaStock.ShowDialog();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();//se incluye el cierre de sesion
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Almacen almacenSeleccionado = obtenerAlmacenSeleccionado();

            abrirPantallaReporteFechas(almacenSeleccionado);
        }
        public void abrirPantallaReporteFechas(Almacen almacenSeleccionado)
        {
            if (almacenSeleccionado != null)
            {
                PantallaReporteFechas pantallaReporte = new PantallaReporteFechas();
                pantallaReporte.Owner = this;
                pantallaReporte.ShowDialog();
            }
        }

        private void btnModificarStock_Click(object sender, EventArgs e)
        {

        }
    }
}
