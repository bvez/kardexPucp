using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocumentoDePago
    {
        private int id;
        private double total;
        private DateTime fecha;
        //el cliente se maneja en cada subclase
        private BindingList<LineaProducto> items;
        private int estado; //1: pagado 0:por pagar. Ponerlo como enumerado despues

        public DocumentoDePago()
        {
            items = new BindingList<LineaProducto>();
        }

        public int Id { get => id; set => id = value; }
        public double Total { get => total; set => total = value; }
        public BindingList<LineaProducto> Items { get => items; set => items = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
