namespace Entidades
{
    public class ProductoAlmacen
    {
        private int cantidadAlmacenada;
        private Producto productoAlmacenado;

        public int CantidadAlmacenada { get { return cantidadAlmacenada; } set { cantidadAlmacenada = value; } }
        public Producto ProductoAlmacenado { get { return productoAlmacenado; } set { productoAlmacenado = value; } }

        public string Nombre
        {
            get { return productoAlmacenado.Nombre; }
        }

        public int Id
        {
            get { return productoAlmacenado.Id; }
        }

        public string Descripcion
        {
            get { return productoAlmacenado.Descripcion; }
        }

        public string CodigoProducto
        {
            get { return productoAlmacenado.CodigoProducto; }
        }
    }

}