using System.Collections.Generic;
using System.ComponentModel;

namespace Entidades
{
    public class Pedido
    {
        int id;
        int idVenta;
        string estado;
        BindingList<LineaProducto> productos;

        public Pedido(int id, int idVenta, string estado, BindingList<LineaProducto> productos)
        {
            this.id = id;
            this.idVenta = idVenta;
            this.estado = estado;
            this.productos = productos;
        }

        public int Id { get => id; set => id = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string Estado { get => estado; set => estado = value; }
        public BindingList<LineaProducto> Productos { get => productos; set => productos = value; }
    }
}