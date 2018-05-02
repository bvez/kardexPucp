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

        public string Id
        {
            get { return productoAlmacenado.Id; }
        }
    }

}