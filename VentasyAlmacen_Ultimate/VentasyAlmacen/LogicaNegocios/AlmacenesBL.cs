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
        private DatosAlmacenes datosAlm;
        public AlmacenesBL()
        {
            datosAlm = new DatosAlmacenes();
        }
        public BindingList<Almacen> obtenerAlmacenes()
        {
            BindingList<Almacen> almacenes = datosAlm.obtenerAlmacenes();

            return almacenes;
        }

        public BindingList<Sucursal> obtenerSucursalesDisponibles()
        {
            return datosAlm.listarSucursalesDisponible();
        }
    }
}
