using System.Collections.Generic;
using System.ComponentModel;

namespace Entidades
{
    public class Almacen : Sucursal
    {
        private int idAlmacen;
        private string _codigoAlmacen;
        private BindingList<ProductoAlmacen> _productos;
        private bool habilitado;

        public BindingList<ProductoAlmacen> Productos { get { return _productos; } set { _productos = value; } }
        public string CodigoAlmacen { get { return _codigoAlmacen; } set { _codigoAlmacen = value; } }

        public int IdAlmacen { get => idAlmacen; set => idAlmacen = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public bool Deshabilitado { get => !habilitado;}

        //public string IdAlmacenS { get => idAlmacen.ToString();}

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

        override public string ToString()
        {
            return "Almacen " + idAlmacen.ToString() + " --- " + this.Direccion;
        }
    }
}