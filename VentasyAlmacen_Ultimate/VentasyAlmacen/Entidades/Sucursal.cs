namespace Entidades
{
    using System.Collections.Generic;
    using System.ComponentModel;
    public class Sucursal
    {
        private string _codigoSucursal;
        private string _direccion;
        private string _telefono;
        private BindingList<Vehiculo> _vehiculos;
        private BindingList<Cliente> _clientes;
        private BindingList<Pedido> _pedidos;

        public string CodigoSucursal { get { return _codigoSucursal; } set { _codigoSucursal = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public BindingList<Vehiculo> Vehiculos { get { return _vehiculos; } set { _vehiculos = value; } }
        public BindingList<Cliente> Clientes { get { return _clientes; } set { _clientes = value; } }
        public BindingList<Pedido> Pedidos { get { return _pedidos; } set { _pedidos = value; } }

        public void anadirCliente(Cliente newCliente)
        {

        }

        public void anadirVehiculo(Vehiculo newVehiculo)
        {

        }

        public void anadirPedido(Pedido newPedido)
        {

        }

        public string hacerReportePedidos()
        {
            string resp = "";
            return resp;
        }
    }

}