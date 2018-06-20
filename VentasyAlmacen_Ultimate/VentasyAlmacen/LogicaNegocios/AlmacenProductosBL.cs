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
    public class AlmacenProductosBL
    {
        private DatosAlmacenes accesoDatosAlmacen;
        private DatosAlmacenProductos accesoDatosProductos;

        public AlmacenProductosBL()
        {
            accesoDatosAlmacen = new DatosAlmacenes();
            accesoDatosProductos = new DatosAlmacenProductos();
        }

        public BindingList<Producto> obtenerProductosEmpresa()
        {
            BindingList<Producto> productos = accesoDatosProductos.obtenerProductosEmpresa();

            return productos;
        }


        public BindingList<ProductoAlmacen> obtenerProductosAlmacen(int idAlmacen)
        {
            return accesoDatosProductos.obtenerProductosAlmacen(idAlmacen);
        }
        public BindingList<ProductoAlmacen> obtenerProductosAlmacen(int idAlmacen, string nombreBuscar, int limInferior, int limSuperior)
        {
            return accesoDatosProductos.obtenerProductosAlmacen(idAlmacen, nombreBuscar, limInferior, limSuperior);
        }
        public BindingList<ProductoAlmacen> obtenerProductosAlmacen(int idAlmacen, int idProd, string nombreBuscar, int limInferior, int limSuperior)
        {
            return accesoDatosProductos.obtenerProductosAlmacen(idAlmacen,idProd, nombreBuscar, limInferior, limSuperior);
        }
        public BindingList<Producto> obtenerProductosRegistrables(int idAlmacen)
        {
            return accesoDatosProductos.obtenerProductosRegistrables(idAlmacen);
        }

        public BindingList<Producto> obtenerProductosRegistrables(int idAlmacen,string nombreBuscar)
        {
            return accesoDatosProductos.obtenerProductosRegistrables(idAlmacen,nombreBuscar);
        }
        public BindingList<Producto> obtenerProductosRegistrables(int idAlmacen, int idProducto, string nombreBuscar)
        {
            return accesoDatosProductos.obtenerProductosRegistrables(idAlmacen, idProducto, nombreBuscar);
        }

        public bool registrarProductoAlmacen(int idAlmacen,int idProducto,int stockInicial)
        {
            return accesoDatosProductos.insertarProductoAlmacen(idAlmacen, idProducto, stockInicial);
        }

        public bool actualizarStock(int idAlmacen,int idProducto,int nuevoStock)
        {
            return accesoDatosProductos.actualizarStock(idAlmacen, idProducto, nuevoStock);
        }
        public bool actualizarAlmacenPedidoProd()
        {
            return accesoDatosProductos.actualizarAlmacenPedidoProduccion();
        }
    }
}
