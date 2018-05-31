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
    public class AlmacenUsuariosBL
    {
        DatosUsuarios usuarios;
        public AlmacenUsuariosBL()
        {
            usuarios = new DatosUsuarios();
        }
        public bool verificarUsuario(string nombreUsuario,string contrasena, out BindingList<Almacen> listaAlmacenes,out int cantidadAlmacenes,out int _rol,out bool usuarioCorrecto)
        {
            return usuarios.verificarUsuario(nombreUsuario, contrasena,out listaAlmacenes,out cantidadAlmacenes,out _rol,out usuarioCorrecto);
        }
    }
}
