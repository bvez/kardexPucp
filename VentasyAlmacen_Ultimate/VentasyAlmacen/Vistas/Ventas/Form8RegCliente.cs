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
        private int idCliente;
        private VentasClientesBL logicaNegocios;
        public Form8RegCliente()
        {
            InitializeComponent();
            logicaNegocios = new VentasClientesBL();

        }

        public int IdCliente { get => idCliente; set => idCliente = value; }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string direccion = tB_Dir.Text;
            int telefono = Int32.Parse(tB_Nro.Text);
            string correo = tB_correo.Text;
            int id;
            if (tabControl1.SelectedTab == tab1Juridica)
            {
                string nombre = tB_RazSoc.Text;
                string ruc = mtB_RUC.Text;
                string gironegocio = tB_giroNegocio.Text;
                ClienteEmpresa c = new ClienteEmpresa(-1, nombre, DateTime.Today, direccion, telefono.ToString(), correo, ruc, gironegocio);
                id = logicaNegocios.insertaCliente(c);
            } else
            {
                string nombres = tB_Nombres.Text;
                string apellidoP = tB_ApP.Text;
                string apellidoM = tB_ApM.Text;
                int dni = Int32.Parse(mTB_DNI.Text);
                Sexo sexo;
                if (rB_H.Checked) sexo = Sexo.Hombre;
                else sexo = Sexo.Mujer;
                ClientePersona c = new ClientePersona(-1, nombres, DateTime.Today, direccion, telefono.ToString(), correo, dni.ToString(), apellidoP, apellidoM, sexo);
                id = logicaNegocios.insertaCliente(c);
            }
            idCliente = id;
            MessageBox.Show("Se registro el usuario exitosamente");
            DialogResult = DialogResult.OK;
            
        }
    }
}
