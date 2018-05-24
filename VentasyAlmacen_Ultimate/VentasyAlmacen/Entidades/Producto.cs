namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private int id;
        private string codigoProducto;
        private bool habilitado;
        private string descripcion;
        private double precio;

        public Producto()
        {
        }

        public Producto(string nombre, int id, string codigoProducto, bool habilitado, string descripcion, double precio)
        {
            this.nombre = nombre;
            this.id = id;
            this.codigoProducto = codigoProducto;
            this.habilitado = habilitado;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return nombre;
        }

        public double Precio { get => precio; set => precio = value; }


    }
}