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
        private int cantidadSalida;
        private string observaciones;

        public int IdLineaIngresoSalidaProducto { get => IdLineaIngresoSalidaProducto; set => IdLineaIngresoSalidaProducto = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public int CantidadIngresoSalida { get => cantidadSalida; set => cantidadSalida = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
