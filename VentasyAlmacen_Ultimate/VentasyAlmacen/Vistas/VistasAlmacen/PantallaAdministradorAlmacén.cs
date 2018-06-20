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
        public Almacen almacenActual;
        public PantallaAdministradorAlmacén()
        {
            InitializeComponent();
        }
        public PantallaAdministradorAlmacén(string nombre)
        {
            this.almacenActual = this.obtenerAlmacenSeleccionado();
            
            if (almacenActual != null)
            {
                InitializeComponent();
                labelBienvenidaAdmin.Text = "Bienvenido " + nombre;
                labelAlmacen.Text = "Almacén " + this.almacenActual.IdAlmacen.ToString();
                (new AlmacenProductosBL()).actualizarAlmacenPedidoProd();
            }
            else
            {
                //this.Close();
            }
        }

        public Almacen obtenerAlmacenSeleccionado()
        {
            Almacen almacenSeleccionado;
            PantallaSeleccionarAlmacen pantallaAlmacenes;

            pantallaAlmacenes = new PantallaSeleccionarAlmacen();
            pantallaAlmacenes.ShowDialog();

            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            pantallaAlmacenes.Dispose();
            return almacenSeleccionado;
        }

        //lo que sucede cuando la pantalla de administrador se cierra
        private void PantallaAdministradorAlmacén_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioPrincipal form = (FormularioPrincipal)this.Owner;
            //Console.WriteLine("Cierra sesion admin");
            //this.Owner.Enabled = true;//el padre se activa
            ((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            form.Visible = true;
            this.Owner = null;
        }


        public void abrirPantallaProductosAlmacen(Almacen almacenSeleccionado)
        {
            if (almacenSeleccionado != null)
            {
                PantallaProductosAlmacen pantallaProductos = new PantallaProductosAlmacen(almacenSeleccionado.IdAlmacen,'A');
                pantallaProductos.Owner = this;
                //this.Visible = false;
                pantallaProductos.ShowDialog();
                pantallaProductos.Dispose();
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
                pantallaAnadirProducto.Dispose();
            }
        }

        private void btnActualizarAlmacenes_Click(object sender, EventArgs e)
        {
            PantallaEliminarAlmacenes newPant = new PantallaEliminarAlmacenes();
            newPant.Owner = this;
            newPant.ShowDialog();
            newPant.Dispose();
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
                pantallaStock.Dispose();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();//se incluye el cierre de sesion
        }
        public void abrirPantallaReporteFechas(Almacen almacenSeleccionado)
        {
            if (almacenSeleccionado != null)
            {
                PantallaReporteFechas pantallaReporte = new PantallaReporteFechas();
                pantallaReporte.Owner = this;
                pantallaReporte.ShowDialog();
                pantallaReporte.Dispose();
            }
        }

        private void btnModificarStock_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.almacenActual = obtenerAlmacenSeleccionado();
            if(almacenActual != null)
                labelAlmacen.Text = "Almacén " + this.almacenActual.IdAlmacen.ToString();
        }

        private void btnProductosDisponibl_Click(object sender, EventArgs e)
        {
            abrirPantallaProductosAlmacen(this.almacenActual);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirPantallaReporteFechas(this.almacenActual);
        }
    }
}
