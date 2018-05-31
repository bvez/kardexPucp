using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios.Ventas;
using Entidades;


namespace Ventas
{
    public partial class Form11BuscaVenta : Form
    {
        private VentasVentaBL logicaNegocios;
        private Venta objetoSeleccionado;

        public Venta ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        public Form11BuscaVenta()
        {
            InitializeComponent();
            logicaNegocios = new VentasVentaBL();
            dG_ModifVentas.AutoGenerateColumns = false;
            dG_ModifVentas.AllowUserToAddRows = false;
            dG_ModifVentas.DataSource = logicaNegocios.listarVentas();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_conf_busc_Click(object sender, EventArgs e)
        {
            if (dG_ModifVentas.SelectedCells.Count <= 0)
            {
                MessageBox.Show("No se ha seleccionado una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                objetoSeleccionado = (Venta)dG_ModifVentas.CurrentRow.DataBoundItem;
            }
        }
    }
}
