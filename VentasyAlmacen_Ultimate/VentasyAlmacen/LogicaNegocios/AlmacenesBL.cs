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
        public BindingList<Almacen> obtenerAlmacenesTodos()
        {
            BindingList<Almacen> almacenes = datosAlm.obtenerAlmacenesTodos();

            return almacenes;
        }

        public BindingList<Almacen> obtenerAlmacenesHabilitados()
        {
            return datosAlm.obtenerAlmacenesHabilitados();
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

        public int registrarSalidaProductos(int idAlmacen, int idLocalDestino, string observaciones)
        {
            return datosAlm.insertarSalidaProductos(idAlmacen, idLocalDestino, observaciones);
        }

        public int registrarLineaSalidaProductos(int idSalidaProductos, int idProducto, int cantidad, string observaciones)
        {
            return datosAlm.insertarLineaSalidaProductos(idSalidaProductos, idProducto, cantidad, observaciones);
        }

        public int registrarIngresoProductos(int idAlmacen, int idLocalEmisor, string observaciones)
        {
            return datosAlm.insertarIngresoProductos(idAlmacen, idLocalEmisor, observaciones);
        }

        public int registrarLineaIngresoProductos(int idIngresoProductos, int idProducto, int cantidad, string observaciones)
        {
            return datosAlm.insertarLineaIngresoProductos(idIngresoProductos, idProducto, cantidad, observaciones);
        }
    }
}
