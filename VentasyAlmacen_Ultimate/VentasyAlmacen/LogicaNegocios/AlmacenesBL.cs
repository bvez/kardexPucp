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

        public Almacen obtenerAlmacen(int idAlmacen)
        {
            return datosAlm.obtenerAlmacen(idAlmacen);
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

        public BindingList<Sucursal> obtenerLocales()
        {
            return datosAlm.listarLocales();
        }

        public BindingList<SalidaProducto> obtenerEnviosPendientesAlmacen(int idLocalAlmacen)
        {
            return datosAlm.listarEnviosPendientesAlmacen(idLocalAlmacen);
        }

        public BindingList<LineaIngresoSalidaProducto> obtenerProductosSalida(int idSalidaProductos)
        {
            return datosAlm.listarProductosSalida(idSalidaProductos);
        }

        public BindingList<LineaIngresoSalidaProducto> obtenerProductosIngreso(int idIngresoProductos)
        {
            return datosAlm.listarProductosIngreso(idIngresoProductos);
        }
    }
}
