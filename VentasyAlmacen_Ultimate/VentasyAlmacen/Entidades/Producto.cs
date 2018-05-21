namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private int id;
        private string codigoProducto;
        private bool habilitado;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}