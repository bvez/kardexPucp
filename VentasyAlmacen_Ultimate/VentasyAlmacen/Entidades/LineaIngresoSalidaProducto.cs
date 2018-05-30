using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LineaIngresoSalidaProducto
    {
        private int idLineaIngresoSalidaProducto;
        private Producto producto;
        private int cantidadIngresoSalida;
        private string observaciones;

        public int IdLineaIngresoSalidaProducto { get => idLineaIngresoSalidaProducto; set => idLineaIngresoSalidaProducto = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public string Nombre { get => producto.Nombre; }
        public string Descripcion { get => producto.Descripcion; }
        public string CodigoProducto { get => producto.CodigoProducto; }
        public int Id { get => producto.Id; }

        public int CantidadIngresoSalida { get => cantidadIngresoSalida; set => cantidadIngresoSalida = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
