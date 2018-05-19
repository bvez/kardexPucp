using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos
{
    public class DatosAlmacenProductos
    {
        public BindingList<Producto> obtenerProductosEmpresa()
        {
            BindingList<Producto> productos = new BindingList<Producto>();

            Producto producto1 = new Producto();
            producto1.Nombre = "PrimerProducto";
            producto1.Id = "X111AS";
            Producto producto2 = new Producto();
            producto2.Nombre = "Producto2";
            producto2.Id = "X222adsf";
            Producto producto3 = new Producto();
            producto3.Nombre = "Producto3";
            producto3.Id = "X333adsf";

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);

            return productos;
        }
    }
}
