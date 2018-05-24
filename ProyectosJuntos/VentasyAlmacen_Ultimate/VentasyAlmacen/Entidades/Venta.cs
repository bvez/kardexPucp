using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Entidades
{
    public class Venta
    {
        private int id;
        private Cliente cliente;
        private EstadoVenta estado;
        private DateTime fechaRegistro;
        private BindingList<LineaProducto> productos;
        private double descuento;
        private string conceptodescuento;

        public int Id { get => id; set => id = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public EstadoVenta Estado { get => estado; set => estado = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public string Conceptodescuento { get => conceptodescuento; set => conceptodescuento = value; }
        public BindingList<LineaProducto> Productos { get => productos; set => productos = value; }

        public override string ToString()
        {
            return "Venta de código " + id + " registrada el " + fechaRegistro;
        }

        public Venta(int id, DateTime fechaRegistro)
        {
            this.id = id;
            this.fechaRegistro = fechaRegistro;
        }

        public Venta()
        {
        }

        public Venta(int id, Cliente cliente, EstadoVenta estado, DateTime fechaRegistro, BindingList<LineaProducto> productos, double descuento, string conceptodescuento)
        {
            this.id = id;
            this.cliente = cliente;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
            this.productos = productos;
            this.descuento = descuento;
            this.conceptodescuento = conceptodescuento;
        }
    }
}
