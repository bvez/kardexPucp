using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos.Ventas;
using Entidades;

namespace LogicaNegocios.Ventas
{
    public class VentasVentaBL
    {
        private DatosVentas accesoDatos;

        public VentasVentaBL()
        {
            accesoDatos= new DatosVentas();
        }

        public BindingList<Venta> listarVentas()
        {
            return accesoDatos.listarVentas();
        }

        public int insertarVenta (Venta obj)
        {
            return accesoDatos.insertarVenta(obj);
        }

        public bool asignarCliente (int idVenta, int idCliente)
        {
            return accesoDatos.asignarCliente(idVenta, idCliente);
        }

    }
}
