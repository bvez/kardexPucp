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

namespace FormulariosAlmacenes
{
    public partial class PantallaUsuarioAlmacen : Form
    {
        private Almacen almacenUsuario;
        public PantallaUsuarioAlmacen()
        {
            InitializeComponent();
        }
        public PantallaUsuarioAlmacen(string nombre)
        {
            InitializeComponent();
            //al loguarse, se debe hacer una asociacion con el almacén
            labelBienvenidaUsuario.Text = "Bienvenido " + nombre;
        }

        private void PantallaUsuarioAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void buttonStock_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaProductosAlmacen pantallaProductosAlmacen = new PantallaProductosAlmacen(this.almacenUsuario);
            pantallaProductosAlmacen.Owner = this;
            this.Visible = false;
            pantallaProductosAlmacen.ShowDialog();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonRegPedidos_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaRegPedidoProduccion newPant = new PantallaRegPedidoProduccion();
            newPant.Owner = this;
            this.Visible = false;
            newPant.ShowDialog();
        }

        private void buttonIngreso_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaRegIngresosProducto newPant = new PantallaRegIngresosProducto();
            newPant.Owner = this;
            this.Visible = false;
            newPant.ShowDialog();
        }

        private void buttonSalidas_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaRegSalidaProducto newPant = new PantallaRegSalidaProducto();
            newPant.Owner = this;
            this.Visible = false;
            newPant.ShowDialog();
        }

        private void buttonReporteFechas_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaReporteFechas newPant = new PantallaReporteFechas();
            newPant.Owner = this;
            this.Visible = false;
            newPant.ShowDialog();
        }
    }
}
