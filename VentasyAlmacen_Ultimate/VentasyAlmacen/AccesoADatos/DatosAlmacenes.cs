using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class DatosAlmacenes
    {
        public BindingList<Almacen> obtenerAlmacenes()
        {
            BindingList<Almacen> almacenes = new BindingList<Almacen>();

            BindingList<ProductoAlmacen> listaProductoAlmacen1 = new BindingList<ProductoAlmacen>();
            BindingList<ProductoAlmacen> listaProductoAlmacen2 = new BindingList<ProductoAlmacen>();
            BindingList<ProductoAlmacen> listaProductoAlmacen3 = new BindingList<ProductoAlmacen>();

            DatosAlmacenProductos accesoProductos = new DatosAlmacenProductos();
            BindingList<Producto> productos = accesoProductos.obtenerProductosEmpresa();

            ProductoAlmacen pack1_1 = new ProductoAlmacen();
            pack1_1.ProductoAlmacenado = productos.ElementAt(0);
            pack1_1.CantidadAlmacenada = 10;

            ProductoAlmacen pack1_2 = new ProductoAlmacen();
            pack1_2.ProductoAlmacenado = productos.ElementAt(1);
            pack1_2.CantidadAlmacenada = 10;

            ProductoAlmacen pack2_1 = new ProductoAlmacen();
            pack2_1.ProductoAlmacenado = productos.ElementAt(1);
            pack2_1.CantidadAlmacenada = 20;

            ProductoAlmacen pack2_2 = new ProductoAlmacen();
            pack2_2.ProductoAlmacenado = productos.ElementAt(2);
            pack2_2.CantidadAlmacenada = 20;

            ProductoAlmacen pack3 = new ProductoAlmacen();
            pack3.ProductoAlmacenado = productos.ElementAt(2);
            pack3.CantidadAlmacenada = 30;

            listaProductoAlmacen1.Add(pack1_1);
            listaProductoAlmacen1.Add(pack1_2);

            listaProductoAlmacen2.Add(pack2_1);
            listaProductoAlmacen2.Add(pack2_2);

            listaProductoAlmacen3.Add(pack3);

            Almacen almacen1 = new Almacen();
            almacen1.CodigoAlmacen = "ALM01";
            almacen1.CodigoSucursal = "Sucursal 1";
            almacen1.Direccion = "Direccion de almacen 1";
            almacen1.Telefono = "111-1111";
            almacen1.Productos = listaProductoAlmacen1;

            Almacen almacen2 = new Almacen();
            almacen2.CodigoAlmacen = "ALM02";
            almacen2.CodigoSucursal = "Sucursal 2";
            almacen2.Direccion = "Direccion de almacen 2";
            almacen2.Telefono = "222-2222";
            almacen2.Productos = listaProductoAlmacen2;

            Almacen almacen3 = new Almacen();
            almacen3.CodigoAlmacen = "ALM03";
            almacen3.CodigoSucursal = "Sucursal 3";
            almacen3.Direccion = "Direccion de almacen 3";
            almacen3.Telefono = "333-3333";
            almacen3.Productos = listaProductoAlmacen3;

            almacenes.Add(almacen1);
            almacenes.Add(almacen2);
            almacenes.Add(almacen3);

            return almacenes;
        }
    }
}
