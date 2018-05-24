using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LineaProducto
    {
        private int cantidad;
        private Producto producto;

        public LineaProducto(int cantidad, Producto producto)
        {
            Cantidad = cantidad;
            Producto = producto;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Producto Producto { get => producto; set => producto = value; }
    }
}
