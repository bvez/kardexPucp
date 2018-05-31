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
    public class VentasPedidoAlmacBL
    {
        private DatosPedidoAlmac accesoDatos;

        public VentasPedidoAlmacBL()
        {
            accesoDatos = new DatosPedidoAlmac();
        }

        public BindingList<Pedido> listarPedidos()
        {
            return accesoDatos.listarPedidos();
        }

        public void modificarEstado(string estado, int id)
        {
            accesoDatos.modificarEstado(estado, id);
        }
    }
}
