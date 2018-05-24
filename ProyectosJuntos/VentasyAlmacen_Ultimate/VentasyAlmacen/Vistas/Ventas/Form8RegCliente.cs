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
    public partial class Form8RegCliente : Form
    {
        public Form8RegCliente()
        {
            InitializeComponent();
            VentasClientesBL logicaNegocios = new VentasClientesBL();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab1Juridica)
            {
                string nombre = tB_RazSoc.Text;
                string ruc = mtB_RUC.Text;
                string gironegocio = tB_giroNegocio.Text;

            } else
            {

            }
        }
    }
}
