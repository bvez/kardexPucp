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

namespace Ventas
{
    public partial class PantallaAdminVentas : Form
    {
        public PantallaAdminVentas()
        {
            InitializeComponent();
        }
        public PantallaAdminVentas(string nombre)
        {
            InitializeComponent();
            labelBienvenidaAdmin.Text = "Bienvenido " + nombre;
        }

        private void btn_modificaVenta_Click(object sender, EventArgs e)
        {
            Form4ModifVenta modifVenta = new Form4ModifVenta();
            modifVenta.Owner = this;
            modifVenta.ShowDialog();
        }

        private void btn_estadoVenta_Click(object sender, EventArgs e)
        {
            Form5RevisarVenta revisarVenta = new Form5RevisarVenta();
            revisarVenta.Owner = this;
            revisarVenta.ShowDialog();
        }

        private void btn_emitirPedido_Click(object sender, EventArgs e)
        {
            Form6EmitirPedAlm emitirPedido = new Form6EmitirPedAlm();
            emitirPedido.Owner = this;
            emitirPedido.ShowDialog();
        }

        private void btn_estadoPedido_Click(object sender, EventArgs e)
        {
            Form7RevisarPedAlm estadoPedido = new Form7RevisarPedAlm();
            estadoPedido.Owner = this;
            estadoPedido.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();//se incluye el cierre de sesion
        }

        //lo que sucede cuando la pantalla de administrador se cierra
        private void PantallaAdminVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;//el padre se activa
            //((FormularioPrincipal)this.Owner).limpiarCampos();
            MessageBox.Show("Su sesión se cerró correctamente", "Éxito");
            this.Owner.Visible = true;
        }

        private void btn_anularVenta_Click(object sender, EventArgs e)
        {
            Form14AnularVenta anulaVenta = new Form14AnularVenta();
            anulaVenta.Owner = this;
            anulaVenta.ShowDialog();
        }
    }
}
