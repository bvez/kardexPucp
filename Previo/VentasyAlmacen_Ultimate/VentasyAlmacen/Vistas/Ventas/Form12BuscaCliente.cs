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
using LogicaNegocios.Ventas;

namespace Ventas
{
    public partial class Form12BuscaCliente : Form
    {
        private VentasClientesBL logicaNegocios;
        private Cliente objetoSeleccionado = null;

        public Cliente ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        public Form12BuscaCliente()
        {
            InitializeComponent();
            logicaNegocios = new VentasClientesBL();
            dG_Naturales.AutoGenerateColumns = false;
            dG_Naturales.AllowUserToAddRows = false;
            dG_Naturales.DataSource = logicaNegocios.listarClientesNaturales();
            dG_Juridicos.AutoGenerateColumns = false;
            dG_Juridicos.AllowUserToAddRows = false;
            dG_Juridicos.DataSource = logicaNegocios.listarClientesJuridicos();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_conf_busc_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (dG_Naturales.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("No se ha seleccionado un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    objetoSeleccionado = (Cliente)dG_Naturales.CurrentRow.DataBoundItem;
                }
            }
            else
            {
                if (dG_Juridicos.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("No se ha seleccionado un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    objetoSeleccionado = (Cliente)dG_Juridicos.CurrentRow.DataBoundItem;
                }
            }
        }
    }
}