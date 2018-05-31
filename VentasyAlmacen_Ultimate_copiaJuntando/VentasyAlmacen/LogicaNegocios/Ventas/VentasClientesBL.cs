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
    public class VentasClientesBL
    {
        private DatosClientes accesoDatos;
        public VentasClientesBL()
        {
            accesoDatos = new DatosClientes();
        }

        public BindingList <ClientePersona> listarClientesNaturales()
        {
            return accesoDatos.listarClientesNaturales();
        }

        public BindingList<ClienteEmpresa> listarClientesJuridicos()
        {
            return accesoDatos.listarClientesJuridicos();
        }

        public int insertaCliente(Cliente obj)
        {
            return accesoDatos.insertarCliente(obj);
        }

        public void modificaCliente(Cliente obj)
        {
            accesoDatos.modificaCliente(obj);
        }
    }
}