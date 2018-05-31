namespace Entidades
{
    using System;
    public class ClienteEmpresa : Cliente
    {
        private string _ruc;
        private string _giroNegocio;

        public ClienteEmpresa()
        {

        }

        public ClienteEmpresa(int id, string nombre, DateTime fechaRegistro, string direccion, string telefonoContacto, string email, string ruc, string giroNegocio) : base(id, nombre, fechaRegistro, direccion, telefonoContacto, email)
        {
            _ruc = ruc;
            _giroNegocio = giroNegocio;
        }

        public string ruc
        {
            get
            {
                return this._ruc;
            }
            set
            {
                this._ruc = value;
            }
        }

        public string giroNegocio
        {
            get
            {
                return this._giroNegocio;
            }
            set
            {
                this._giroNegocio = value;
            }
        }

        public override String consultarDatosCliente()
        {
            string resp = "";
            resp += this.ruc + " " + this.nombre + " " + this.telefonoContacto + " " + this.direccion;
            return resp;
        }
    }
}