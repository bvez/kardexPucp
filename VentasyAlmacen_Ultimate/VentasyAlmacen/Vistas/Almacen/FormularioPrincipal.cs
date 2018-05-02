using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAlmacenes
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(pictureHelp, "Introduzca 'admin' si desea ingresar como administrador");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.logueo();
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.logueo();
            }
        }

        private void logueo()
        {
            //aqui deberia verificarse el usuario y contraseña
            //y deberia obtenerse el nombre real del usuario
            if(textBoxUsuario.Text == "admin")
            {
                pantallaAdmin();
            }
            else
            {
                pantallaUsuario();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.logueo();
        }

        private void pantallaAdmin()
        {
            PantallaAdministradorAlmacén formAdmin = new PantallaAdministradorAlmacén(textBoxUsuario.Text);
            formAdmin.Owner = this;
            //formAdmin.Visible = true;
            this.Visible = false;
            formAdmin.ShowDialog();
        }

        private void pantallaUsuario()
        {
            PantallaUsuarioAlmacen formUsuario = new PantallaUsuarioAlmacen(textBoxUsuario.Text);
            formUsuario.Owner = this;
            this.Visible = false;
            formUsuario.ShowDialog();
        }

        private void FormularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
