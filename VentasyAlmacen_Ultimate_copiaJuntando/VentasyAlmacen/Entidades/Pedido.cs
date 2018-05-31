namespace Entidades
{
    public class Pedido
    {
        int id;
        int idVenta;
        string estado;

        public Pedido(int id, int idVenta, string estado)
        {
            this.id = id;
            this.idVenta = idVenta;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}