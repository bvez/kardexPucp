using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boleta : DocumentoDePago
    {
        private int numero;
        private ClientePersona cliente;

        public Boleta() : base()
        {
            cliente = new ClientePersona();
        }
        public Boleta(ClientePersona cliente) : base()
        {
            this.cliente = cliente;
        }

        public int Numero { get => numero; set => numero = value; }
        public ClientePersona Cliente { get => cliente; set => cliente = value; }
    }
}
