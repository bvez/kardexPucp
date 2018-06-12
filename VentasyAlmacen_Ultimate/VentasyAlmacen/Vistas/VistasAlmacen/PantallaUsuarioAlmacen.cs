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
        public PantallaUsuarioAlmacen(string nombreUsuario,int idAlmacen)
        {
            InitializeComponent();
            //al loguarse, se debe hacer una asociacion con el almacén
            labelBienvenidaUsuario.Text = "Bienvenido " + nombreUsuario;
            codAlmacen = idAlmacen;
        }

        public void setAlmacen(string codigo)
        {
            //codAlmacen = codigo;
        }
        private void PantallaUsuarioAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Cierra sesion user");
            ((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            this.Owner.Visible = true;
        }
        private void buttonStock_MouseClick(object sender, MouseEventArgs e)
        {
            //para cada pantalla se debe enviar el objeto Usuario
            PantallaProductosAlmacen pantallaProductosAlmacen = new PantallaProductosAlmacen(codAlmacen,'U');
            pantallaProductosAlmacen.Owner = this;
            //this.Visible = false;
            pantallaProductosAlmacen.ShowDialog();
            pantallaProductosAlmacen.Dispose();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonRegPedidos_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaRegPedidoProduccion newPant = new PantallaRegPedidoProduccion(codAlmacen);
            newPant.Owner = this;
            //this.Visible = false;
            newPant.ShowDialog();
            newPant.Dispose();
        }

        private void buttonIngreso_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaIngresosSalidasProducto newPant = new PantallaIngresosSalidasProducto(codAlmacen);
            newPant.Owner = this;
            //this.Visible = false;
            newPant.ShowDialog();
            newPant.Dispose();
        }


        private void buttonReporteFechas_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaReporteFechas newPant = new PantallaReporteFechas();
            newPant.Owner = this;
            //this.Visible = false;
            newPant.ShowDialog();
            newPant.Dispose();
        }
    }
}
