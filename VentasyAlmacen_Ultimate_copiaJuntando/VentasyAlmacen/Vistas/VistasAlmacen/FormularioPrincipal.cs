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
            if (textBoxUsuario.Text != "" && textBoxPassword.Text != "")
            {
                AlmacenUsuariosBL usuarios = new AlmacenUsuariosBL();
                BindingList<Almacen> almacenesSalida;
                int cantAlmacenesSalida;
                int rolSalida;
                bool usuarioCorrectoSalida;

                if (usuarios.verificarUsuario(textBoxUsuario.Text, textBoxPassword.Text,out almacenesSalida,out cantAlmacenesSalida,out rolSalida,out usuarioCorrectoSalida))
                {
                    //se comprueba el usuario y contraseña
                    if (usuarioCorrectoSalida)
                    {
                        //se esta pensando en hacer que el verificarUsuario devuelva un objeto Usuario que indique si es admin o no
                        if (rolSalida == 2)
                        {
                            pantallaAdmin();
                        }
                        else if (rolSalida == 5 && cantAlmacenesSalida>1)
                        {
                            pantallaUsuario(almacenesSalida);
                        }
                        else if (rolSalida == 5 && cantAlmacenesSalida == 1)
                        {
                            pantallaUsuario(almacenesSalida.ElementAt(0).IdAlmacen);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o la contraseña no son válidos.", "Error");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error en la conexión","Error");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
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
            PantallaAdministradorAlmacén formAdmin = new PantallaAdministradorAlmacén(textBoxUsuario.Text);
            formAdmin.Owner = this;
            //formAdmin.Visible = true;
            this.Visible = false;
            formAdmin.ShowDialog();
        }

        private void pantallaUsuario(int idAlmacen)
        {
            PantallaUsuarioAlmacen formUsuario = new PantallaUsuarioAlmacen(textBoxUsuario.Text,idAlmacen);

            formUsuario.Owner = this;
            this.Visible = false;
            formUsuario.ShowDialog();
        }

        private void pantallaUsuario(BindingList<Almacen> listaAlmacenes)
        {
            //el usuario deberá seleccionar entre varios almacenes en los que está registrado
            PantallaSeleccionarAlmacen formSelectAlmacen = new PantallaSeleccionarAlmacen(listaAlmacenes);
            formSelectAlmacen.ShowDialog();

            PantallaUsuarioAlmacen formUsuario = new PantallaUsuarioAlmacen(textBoxUsuario.Text,formSelectAlmacen.AlmacenSeleccionado.IdAlmacen);

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
