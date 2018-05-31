using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using Entidades;

namespace Ventas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            if (textBoxUsuario.Text != "" && textBoxPassword.Text != "")
            {
                AlmacenUsuariosBL usuarios = new AlmacenUsuariosBL();
                if (usuarios.verificarUsuario(textBoxUsuario.Text, textBoxPassword.Text))
                {
                    //se esta pensando en hacer que el verificarUsuario devuelva un objeto Usuario que indique si es admin o no
                    if (textBoxUsuario.Text == "admin")
                    {
                        pantallaAdmin();
                    }
                    else
                    {
                        pantallaUsuario();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña válidos");
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.logueo();
            }
        }

        private void pantallaAdmin()
        {
            //A esta pantalla y a la pantalla de usuario simple se podria pasar al constructor el objeto Usuario
            PantallaAdminVentas formAdmin = new PantallaAdminVentas(textBoxUsuario.Text);
            formAdmin.Owner = this;
            //formAdmin.Visible = true;
            this.Visible = false;
            formAdmin.ShowDialog();
        }

        private void pantallaUsuario()
        {
            PantallaUserVentas formUsuario = new PantallaUserVentas(textBoxUsuario.Text);

            formUsuario.Owner = this;
            this.Visible = false;
            formUsuario.ShowDialog();
        }

        private void FormularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
            
        }

        private void button1_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        public void limpiarCampos()
        {
            this.textBoxPassword.Text = "";
            this.textBoxUsuario.Text = "";
        }
    }
}