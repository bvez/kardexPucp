using System.Collections.Generic;
using System.ComponentModel;

namespace Entidades
{
    public class Almacen : Sucursal
    {
        private string _codigoAlmacen;
        private BindingList<ProductoAlmacen> _productos;

        public BindingList<ProductoAlmacen> Productos { get { return _productos; } set { _productos = value; } }
        public string CodigoAlmacen { get { return _codigoAlmacen; } set { _codigoAlmacen = value; } }
        public void anadirProducto(Producto newProducto, int stockInicial)
        {

        }

        public void actualizarStock(string codProducto, int newStock)
        {

        }

        public string obtenerReporte()
        {
            string resp = "";
            return resp;
        }
    }
}