using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos;

namespace LogicaNegocios
{
    public class AlmacenesBL
    {
        public BindingList<Almacen> obtenerAlmacenes()
        {
            DatosAlmacenes datosAlm = new DatosAlmacenes();
            BindingList<Almacen> almacenes = datosAlm.obtenerAlmacenes();

            return almacenes;
        }
    }
}
