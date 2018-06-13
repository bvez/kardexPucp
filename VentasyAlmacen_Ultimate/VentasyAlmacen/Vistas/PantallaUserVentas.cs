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
using FormulariosAlmacenes;
using LogicaNegocios;

namespace Ventas
{
    public partial class PantallaUserVentas : Form
    {
        public PantallaUserVentas()
        {
            InitializeComponent();
        }
        public PantallaUserVentas(string nombre)
        {
            InitializeComponent();
            labelBienvenidaAdmin.Text = "Bienvenido " + nombre;
        }

        //lo que sucede cuando la pantalla de administrador se cierra
        private void PantallaUserVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;//el padre se activa
            //((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            this.Owner.Visible = true;
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();//se incluye el cierre de sesion
        }

        private void btn_regVenta_Click(object sender, EventArgs e)
        {
            Form1RegVentas regVentas = new Form1RegVentas();
            regVentas.Owner = this;
            regVentas.ShowDialog();
        }

        private void btn_reporteVentas_Click(object sender, EventArgs e)
        {
            Form3EmitirReporte reporteVentas = new Form3EmitirReporte();
            reporteVentas.Owner = this;
            reporteVentas.ShowDialog();
        }

        private void btn_regCliente_Click(object sender, EventArgs e)
        {
            Form8RegCliente regCliente = new Form8RegCliente();
            regCliente.Owner = this;
            regCliente.ShowDialog();
        }

        private void btn_ModifCliente_Click(object sender, EventArgs e)
        {
            Form9ModifCliente modifCliente = new Form9ModifCliente();
            modifCliente.Owner = this;
            modifCliente.ShowDialog();
        }

        private void btn_reporteClientes_Click(object sender, EventArgs e)
        {
            Form10EmitirReporteCl reporteClientes = new Form10EmitirReporteCl();
            reporteClientes.Owner = this;
            reporteClientes.ShowDialog();
        }
    }
}
