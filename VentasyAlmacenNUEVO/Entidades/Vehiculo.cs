namespace Entidades
{
    using System;
    public class Vehiculo
    {
        private DateTime _fechaAdquisicion;
        private string _nombre;
        private string _placa;
        private float _capacidadKG;
        private bool _enUso;
        private bool _disponible;



        public DateTime fechaAdquisicion
        {
            get
            {
                return this._fechaAdquisicion;
            }
            set
            {
                this._fechaAdquisicion = value;
            }
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

        public string placa
        {
            get
            {
                return this._placa;
            }
            set
            {
                this._placa = value;
            }
        }

        public float getCapacidadKG
        {
            get
            {
                return this._capacidadKG;
            }
            set
            {
                this._capacidadKG = value;
            }
        }


        public bool enUso
        {
            get
            {
                return this._enUso;
            }
            set
            {
                this._enUso = value;
            }
        }

        public bool disponible
        {
            get
            {
                return _disponible;
            }
            set
            {
                this._disponible = value;
            }
        }

    }
}