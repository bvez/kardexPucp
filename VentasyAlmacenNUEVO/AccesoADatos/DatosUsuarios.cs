using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class DatosUsuarios
    {
        public bool verificarUsuario(string usuario,string contrasena)
        {
            bool valido = false;
            try
            {
                
                valido = true;
                
            }
            catch(Exception e)
            {

            }
            return valido;
        }
    }
}
