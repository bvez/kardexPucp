namespace Entidades
{
    using System;
    [Serializable]
    public abstract class Cliente
    {
        private int id;
        protected string _nombre;
        private DateTime _fechaRegistro;
        private string _direccion;
        private string _telefonoContacto;
        private string _email;

        public Cliente()
        {

        }

        protected Cliente(int id, string nombre, DateTime fechaRegistro, string direccion, string telefonoContacto, string email)
        {
            this.id = id;
            _nombre = nombre;
            _fechaRegistro = fechaRegistro;
            _direccion = direccion;
            _telefonoContacto = telefonoContacto;
            _email = email;
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

        public int Id { get => id; set => id = value; }

        public abstract string consultarDatosCliente();
    }
}