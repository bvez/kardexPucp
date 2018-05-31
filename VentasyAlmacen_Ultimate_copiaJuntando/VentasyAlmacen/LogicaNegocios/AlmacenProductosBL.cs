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
        public BindingList<Producto> obtenerProductosRegistrables(int idAlmacen)
        {
            return accesoDatosProductos.obtenerProductosRegistrables(idAlmacen);
        }

        public bool registrarProductoAlmacen(int idAlmacen,int idProducto,int stockInicial)
        {
            return accesoDatosProductos.insertarProductoAlmacen(idAlmacen, idProducto, stockInicial);
        }

        public bool actualizarStock(int idAlmacen,int idProducto,int nuevoStock)
        {
            return accesoDatosProductos.actualizarStock(idAlmacen, idProducto, nuevoStock);
        }
    }
}
