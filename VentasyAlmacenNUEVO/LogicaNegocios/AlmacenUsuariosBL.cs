using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using Entidades;

namespace LogicaNegocios
{
    public class AlmacenUsuariosBL
    {
        DatosUsuarios usuarios;
        public AlmacenUsuariosBL()
        {
            usuarios = new DatosUsuarios();
        }
        public bool verificarUsuario(string nombreUsuario,string contrasena)
        {
            bool valido = false;
            valido = usuarios.verificarUsuario(nombreUsuario, contrasena);
            return valido;
        }
    }
}
