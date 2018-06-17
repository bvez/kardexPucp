using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura : DocumentoDePago
    {
        private int numero;
        private int ruc;
        private double igv;
        private ClienteEmpresa cliente;

        public Factura() : base()
        {
            cliente = new ClienteEmpresa();
        }
        public Factura(ClienteEmpresa cliente) : base()
        {
            this.cliente = cliente;
        }
        public int Numero { get => numero; set => numero = value; }
        public int Ruc { get => ruc; set => ruc = value; }
        public double Igv { get => igv; set => igv = value; }
        public ClienteEmpresa Cliente { get => cliente; set => cliente = value; }
    }
}
