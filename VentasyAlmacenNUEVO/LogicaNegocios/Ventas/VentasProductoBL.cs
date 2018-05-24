using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos.Ventas;
using System.ComponentModel;

namespace LogicaNegocios.Ventas
{
    public class VentasProductoBL
    {
        private DatosProducto accesoDatos;

        public VentasProductoBL()
        {
            accesoDatos = new DatosProducto();
        }

        public BindingList<Producto> listarProductos()
        {
            return accesoDatos.listarProductos();
        }

    }
}
