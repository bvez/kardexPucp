using AccesoADatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class DocumentoDePagoBL
    {
        private DocumentoDePagoDA accesoDatos;

        public DocumentoDePagoBL()
        {
            accesoDatos = new DocumentoDePagoDA();
        }

        public bool insertarBoleta(Boleta boleta)
        {
            return accesoDatos.insertarBoleta(boleta);
        }

        public bool ImprimirFactura(Factura factura, String nombreArchivo)
        {
            return accesoDatos.ImprimirFactura(factura, nombreArchivo);
        }

        public bool ImprimirBoleta(Boleta boleta, String nombreArchivo)
        {
            return accesoDatos.ImprimirBoleta(boleta, nombreArchivo);
        }
    }
}
