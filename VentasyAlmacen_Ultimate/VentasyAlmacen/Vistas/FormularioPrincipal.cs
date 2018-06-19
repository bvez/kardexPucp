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
using Ventas;
using System.Diagnostics;

namespace FormulariosAlmacenes
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
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
                //Console.WriteLine("Entra logueo");
                UsuariosBL usuarios = new UsuariosBL();
                BindingList<Almacen> almacenesSalida;
                int cantAlmacenesSalida;
                int rolSalida;
                bool usuarioCorrectoSalida;

                Usuario user;

                txtCargando.Visible = true;
                this.Refresh();
                this.Update();
                bool verificacionUsuario = usuarios.verificarUsuario(textBoxUsuario.Text, textBoxPassword.Text, out almacenesSalida, out cantAlmacenesSalida, out rolSalida, out usuarioCorrectoSalida, out user);
                txtCargando.Visible = false;

                if (verificacionUsuario)
                {
                    //se comprueba el usuario y contraseña
                    if (usuarioCorrectoSalida)
                    {
                        //Console.WriteLine("Usuario correcto");
                        //se esta pensando en hacer que el verificarUsuario devuelva un objeto Usuario que indique si es admin o no
                        if (rolSalida == 2)
                        {
                            pantallaAdmin(user.Nombre);
                        }
                        else if (rolSalida == 5 && cantAlmacenesSalida>1)
                        {
                            pantallaUsuario(almacenesSalida, user.Nombre);
                        }
                        else if (rolSalida == 5 && cantAlmacenesSalida == 1)
                        {
                            pantallaUsuario(almacenesSalida.ElementAt(0).IdAlmacen, user.Nombre);
                        }
                        else if(rolSalida == 1)
                        {
                            pantallaAdminVentas(user.Nombre);

                        }
                        else if(rolSalida == 6)
                        {
                            pantallaEjecutivoVentas(user.Nombre);
                        }
                        else
                        {
                            MessageBox.Show("No tiene los permisos suficientes para ingresar al área de Almacén o de Ventas.", "Error");
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

        private void pantallaAdmin(string nombre)
        {
            //A esta pantalla y a la pantalla de usuario simple se podria pasar al constructor el objeto Usuario
            PantallaAdministradorAlmacén formAdmin = new PantallaAdministradorAlmacén(nombre);
            if(formAdmin.almacenActual != null)
            {
                formAdmin.Owner = this;
                this.Visible = false;
                formAdmin.ShowDialog();
                formAdmin.Dispose();
            }
            
        }

        private void pantallaUsuario(int idAlmacen,string nombre)
        {
            PantallaUsuarioAlmacen formUsuario = new PantallaUsuarioAlmacen(nombre,idAlmacen);

            formUsuario.Owner = this;
            this.Visible = false;
            formUsuario.ShowDialog();
            formUsuario.Dispose();
        }

        private void pantallaUsuario(BindingList<Almacen> listaAlmacenes,string nombre)
        {
            //el usuario deberá seleccionar entre varios almacenes en los que está registrado
            PantallaSeleccionarAlmacen formSelectAlmacen = new PantallaSeleccionarAlmacen(listaAlmacenes);
            DialogResult resp = formSelectAlmacen.ShowDialog();

            if(resp == DialogResult.OK)
            {
                PantallaUsuarioAlmacen formUsuario = new PantallaUsuarioAlmacen(nombre, formSelectAlmacen.AlmacenSeleccionado.IdAlmacen, listaAlmacenes);
                formUsuario.Owner = this;
                this.Visible = false;
                formUsuario.ShowDialog();
                formUsuario.Dispose();
            }
            
        }

        private void FormularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Visible = true;
            Application.Exit();
            
        }
        private void pantallaAdminVentas(string nombre)
        {
            //A esta pantalla y a la pantalla de usuario simple se podria pasar al constructor el objeto Usuario
            PantallaAdminVentas formAdmin = new PantallaAdminVentas(nombre);
            formAdmin.Owner = this;
            //formAdmin.Visible = true;
            this.Visible = false;
            formAdmin.ShowDialog();
            formAdmin.Dispose();
        }

        private void pantallaEjecutivoVentas(string nombre)
        {
            PantallaUserVentas formUsuario = new PantallaUserVentas(nombre);

            formUsuario.Owner = this;
            this.Visible = false;
            formUsuario.ShowDialog();
            formUsuario.Dispose();
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

        private void button2_Click(object sender, EventArgs e)
        {
           Process.Start(@"cuentas.txt");
        }
    }
}
