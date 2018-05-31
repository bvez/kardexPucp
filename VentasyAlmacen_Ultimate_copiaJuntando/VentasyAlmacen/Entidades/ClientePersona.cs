namespace Entidades
{
    using System;
    [Serializable]
    public class ClientePersona : Cliente
    {
        private string _dni;
        private string _apellido_P;
        private string _apellido_M;
        private Sexo _sexo;

        public ClientePersona()
        {

        }

        public ClientePersona(int id, string nombre, DateTime fechaRegistro, string direccion, string telefonoContacto, string email, string dni, string apellido_P, string apellido_M, Sexo sexo) : base(id, nombre, fechaRegistro, direccion, telefonoContacto, email)
        {
            _dni = dni;
            _apellido_P = apellido_P;
            _apellido_M = apellido_M;
            _sexo = sexo;
        }

        public new string nombre
        {
            get
            {
                return this._nombre + ' ' + this._apellido_P + ' ' + this._apellido_M;
            }
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

        public string Apellido_P { get => _apellido_P; set => _apellido_P = value; }
        public string Apellido_M { get => _apellido_M; set => _apellido_M = value; }

        public override string consultarDatosCliente()
        {
            string resp = "";
            resp += this.dni + " " + this.nombre + " " + this.telefonoContacto + " " + this.direccion;
            return resp;
        }
    }
}