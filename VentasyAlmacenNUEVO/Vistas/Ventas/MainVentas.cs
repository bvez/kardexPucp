using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class MainVentas : Form
    {
        public MainVentas()
        {
            InitializeComponent();
        }

        private void MainVentas_Load(object sender, EventArgs e) { }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Owner.Visible = true;
            this.Close();
        }

        private void btn_RegistrarVenta_Click(object sender, EventArgs e)
        {
            var RegVentas = new Form1RegVentas();
            RegVentas.ShowDialog();
        }

        private void btn_AsignarCliente_Click(object sender, EventArgs e)
        {
            var AsignCliente = new Form2AsignCliente();
            AsignCliente.ShowDialog();
        }

        private void btn_ReporteVentas_Click(object sender, EventArgs e)
        {
            var EmitirReporte = new Form3EmitirReporte();
            EmitirReporte.ShowDialog();
        }

        private void btn_RegCliente_Click(object sender, EventArgs e)
        {
            var RegCliente = new Form8RegCliente();
            RegCliente.ShowDialog();
        }

        private void btn_ModifCliente_Click(object sender, EventArgs e)
        {
            var ModifCliente = new Form9ModifCliente();
            ModifCliente.ShowDialog();
        }

        private void btn_ReporteCliente_Click(object sender, EventArgs e)
        {
            var EmitirReporteCl = new Form10EmitirReporteCl();
            EmitirReporteCl.ShowDialog();
        }

        private void btn_ModificarVenta_Click(object sender, EventArgs e)
        {
            var ModifVenta = new Form4ModifVenta();
            ModifVenta.ShowDialog();
        }

        private void btn_RevisarVenta_Click(object sender, EventArgs e)
        {
            var RevisarVenta = new Form5RevisarVenta();
            RevisarVenta.ShowDialog();
        }

        private void btn_EmitirPedidoAlmacen_Click(object sender, EventArgs e)
        {
            var EmitirPedAlm = new Form6EmitirPedAlm();
            EmitirPedAlm.ShowDialog();
        }

        private void btn_RevisarPedidoAlmac_Click(object sender, EventArgs e)
        {
            var RevisarPedAlm = new Form7RevisarPedAlm();
            RevisarPedAlm.ShowDialog();
        }

        private void MainVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
