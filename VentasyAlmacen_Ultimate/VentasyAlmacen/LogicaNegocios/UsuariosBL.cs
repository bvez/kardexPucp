using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using Entidades;

namespace LogicaNegocios
{
    public class UsuariosBL
    {
        DatosUsuarios usuarios;
        public UsuariosBL()
        {
            usuarios = new DatosUsuarios();
        }

        public bool verificarUsuario(string usuario, string contrasena)
        {
            return usuarios.verificarUsuario(usuario, contrasena);
        }
        public bool verificarUsuario(string nombreUsuario,string contrasena, out BindingList<Almacen> listaAlmacenes,out int cantidadAlmacenes,out int _rol,out bool usuarioCorrecto,out Usuario usuarioSalida)
        {
            return usuarios.verificarUsuario(nombreUsuario, contrasena,out listaAlmacenes,out cantidadAlmacenes,out _rol,out usuarioCorrecto,out usuarioSalida);
        }
    }
}
