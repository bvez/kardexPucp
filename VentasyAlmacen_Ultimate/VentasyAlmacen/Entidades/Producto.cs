namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private string id;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}