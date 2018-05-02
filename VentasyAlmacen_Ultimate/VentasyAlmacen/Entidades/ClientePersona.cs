namespace Entidades
{
    using System;
    [Serializable]
    public class ClientePersona : Cliente
    {
        private string _dni;
        private DateTime _fechaNacimiento;
        private Sexo _sexo;

        public ClientePersona()
        {

        }

        public ClientePersona(string newNombre, string newDireccion, string newTelefono, string newDni) :
            base(newNombre, newDireccion, newTelefono)
        {
            this.dni = newDni;
        }

        public string dni
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }

        public DateTime fechaNacimiento
        {
            get
            {
                return this._fechaNacimiento;
            }
            set
            {
                this._fechaNacimiento = value;
            }
        }

        public Sexo sexo
        {
            get
            {
                return this._sexo;
            }
            set
            {
                this._sexo = value;
            }
        }

        public override string consultarDatosCliente()
        {
            string resp = "";
            resp += this.dni + " " + this.nombre + " " + this.telefonoContacto + " " + this.direccion;
            return resp;
        }
    }
}