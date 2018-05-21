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
        private int codAlmacen;
        //atributo objeto Usuario
        //private Almacen almacenUsuario;
        public PantallaUsuarioAlmacen()
        {
            InitializeComponent();
        }
        public PantallaUsuarioAlmacen(string nombre)
        {
            InitializeComponent();
            //al loguarse, se debe hacer una asociacion con el almacén
            labelBienvenidaUsuario.Text = "Bienvenido " + nombre;
            codAlmacen = Int32.Parse(nombre);
        }

        public void setAlmacen(string codigo)
        {
            //codAlmacen = codigo;
        }
        private void PantallaUsuarioAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            this.Owner.Visible = true;
        }
        private void buttonStock_MouseClick(object sender, MouseEventArgs e)
        {
            //para cada pantalla se debe enviar el objeto Usuario
            PantallaProductosAlmacen pantallaProductosAlmacen = new PantallaProductosAlmacen(codAlmacen);
            pantallaProductosAlmacen.Owner = this;
            //this.Visible = false;
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
            //this.Visible = false;
            newPant.ShowDialog();
        }

        private void buttonIngreso_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaIngresosSalidasProducto newPant = new PantallaIngresosSalidasProducto();
            newPant.Owner = this;
            //this.Visible = false;
            newPant.ShowDialog();
        }


        private void buttonReporteFechas_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaReporteFechas newPant = new PantallaReporteFechas();
            newPant.Owner = this;
            //this.Visible = false;
            newPant.ShowDialog();
        }
    }
}
