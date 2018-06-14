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
    public partial class Form9ModifCliente : Form
    {
        private VentasClientesBL logicaNegocios;

        public Form9ModifCliente()
        {
            InitializeComponent();
            logicaNegocios = new VentasClientesBL();
            dG_ModifJuridica.AutoGenerateColumns = false;
            dG_ModifJuridica.AllowUserToAddRows = false;
            dG_ModifJuridica.Columns[0].Width = 35;
            dG_ModifJuridica.Columns[1].Width = 200;
            dG_ModifJuridica.DataSource = logicaNegocios.listarClientesJuridicos();
            dG_ModifNatural.AutoGenerateColumns = false;
            dG_ModifNatural.AllowUserToAddRows = false;
            dG_ModifNatural.Columns[0].Width = 35;
            dG_ModifNatural.Columns[1].Width = 200;
            dG_ModifNatural.DataSource = logicaNegocios.listarClientesNaturales();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            if (tabControl1.SelectedTab == tab1Juridica)
            {
                cliente = new ClienteEmpresa(((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).Id, tB_RazSoc.Text,DateTime.Now, tB_Dir.Text, tB_Nro.Text, tB_correo.Text, mtB_RUC.Text, tB_giroNegocio.Text);
                MessageBox.Show("Se actualizará cliente jurídico");
            }
            else
            {
                MessageBox.Show("Se actualizará cliente natural");
                Sexo sexo;
                if (rB_H.Checked)
                    sexo = Sexo.Hombre;
                else
                    sexo = Sexo.Mujer;
                cliente = new ClientePersona(((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).Id, tB_Nombres.Text, DateTime.Now, tB_Dir.Text, tB_Nro.Text, tB_correo.Text, mTB_DNI.Text, tB_ApP.Text, tB_ApM.Text, sexo);
            }
            logicaNegocios.modificaCliente(cliente);
        }

        private void dG_ModifJuridica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cliente cargado en el sistema");
            tB_RazSoc.Text = ((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).nombre;
            mtB_RUC.Text = ((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).ruc.ToString();
            tB_giroNegocio.Text = ((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).giroNegocio;
            tB_Dir.Text = ((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).direccion;
            tB_Nro.Text = ((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).telefonoContacto.ToString();
            tB_correo.Text = ((ClienteEmpresa)dG_ModifJuridica.CurrentRow.DataBoundItem).email;
        }

        private void dG_ModifNatural_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cliente cargado en el sistema");
            tB_Nombres.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).nombre;
            tB_ApM.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).Apellido_M;
            tB_ApP.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).Apellido_P;
            mTB_DNI.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).dni.ToString();
            if (((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).sexo == Sexo.Hombre)
                rB_H.Checked = true;
            else rB_M.Checked = true;
            tB_Dir.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).direccion;
            tB_Nro.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).telefonoContacto.ToString();
            tB_correo.Text = ((ClientePersona)dG_ModifNatural.CurrentRow.DataBoundItem).email;
        }
    }
}
