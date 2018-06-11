namespace Entidades
{
    public class Usuario
    {
        private string user;
        private int rol;
        private string nombre;
        public Usuario()
        {

        }
        public Usuario(string usuario, int rol, string nombre)
        {
            this.User = usuario;
            this.Rol = rol;
            this.Nombre = nombre;
        }

        public string User { get => user; set => user = value; }
        public int Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}