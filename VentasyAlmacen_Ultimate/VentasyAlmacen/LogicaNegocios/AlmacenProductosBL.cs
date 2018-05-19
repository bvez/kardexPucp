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
    }
}
