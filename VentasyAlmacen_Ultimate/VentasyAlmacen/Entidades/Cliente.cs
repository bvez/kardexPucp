namespace Entidades
{
    using System;
    [Serializable]
    public abstract class Cliente
    {
        private string _nombre;
        private DateTime _fechaRegistro;
        private string _direccion;
        private string _telefonoContacto;
        private string _email;

        public Cliente()
        {

        }

        public Cliente(string newNombre, string newDireccion, string newTelefono)
        {
            this.nombre = newNombre;
            this.direccion = newDireccion;
            this.telefonoContacto = newTelefono;
        }

        public string nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public DateTime fechaRegistro
        {
            get
            {
                return fechaRegistro;
            }
            set
            {
                this._fechaRegistro = value;
            }
        }

        public string direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {
                this._direccion = value;
            }
        }

        public string telefonoContacto
        {
            get
            {
                return _telefonoContacto;
            }
            set
            {
                this._telefonoContacto = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                this._email = value;
            }
        }

        public abstract string consultarDatosCliente();
    }
}