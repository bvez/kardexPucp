using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormulariosAlmacenes
{
    public partial class PantallaAdministradorAlmacén : Form
    {
        private BindingList<Almacen> listaAlmacenes = new BindingList<Almacen>();
        BindingList<Producto> listaProductosEmpresa = new BindingList<Producto>();
        public PantallaAdministradorAlmacén()
        {
            //consultar los datos de productos
            Producto producto1 = new Producto();
            producto1.Nombre = "PrimerProducto";
            producto1.Id = "X111AS";
            Producto producto2 = new Producto();
            producto2.Nombre = "Producto2";
            producto2.Id = "X111adsf";

            ProductoAlmacen pack1 = new ProductoAlmacen();
            pack1.ProductoAlmacenado = producto1;
            pack1.CantidadAlmacenada = 10;

            ProductoAlmacen pack2 = new ProductoAlmacen();
            pack2.ProductoAlmacenado = producto2;
            pack2.CantidadAlmacenada = 20;

            //listaProductoAlmacen.Add(pack1);
            //listaProductoAlmacen.Add(pack2);
            InitializeComponent();
        }
        public PantallaAdministradorAlmacén(string nombre)
        {
            BindingList<ProductoAlmacen> listaProductoAlmacen1 = new BindingList<ProductoAlmacen>();
            BindingList<ProductoAlmacen> listaProductoAlmacen2 = new BindingList<ProductoAlmacen>();
            BindingList<ProductoAlmacen> listaProductoAlmacen3= new BindingList<ProductoAlmacen>();

            //consultar los datos de productos
            Producto producto1 = new Producto();
            producto1.Nombre = "PrimerProducto";
            producto1.Id = "X111AS";
            Producto producto2 = new Producto();
            producto2.Nombre = "Producto2";
            producto2.Id = "X222adsf";
            Producto producto3 = new Producto();
            producto3.Nombre = "Producto3";
            producto3.Id = "X333adsf";

            ProductoAlmacen pack1_1 = new ProductoAlmacen();
            pack1_1.ProductoAlmacenado = producto1;
            pack1_1.CantidadAlmacenada = 10;

            ProductoAlmacen pack1_2 = new ProductoAlmacen();
            pack1_2.ProductoAlmacenado = producto2;
            pack1_2.CantidadAlmacenada = 10;

            ProductoAlmacen pack2_1 = new ProductoAlmacen();
            pack2_1.ProductoAlmacenado = producto2;
            pack2_1.CantidadAlmacenada = 20;

            ProductoAlmacen pack2_2 = new ProductoAlmacen();
            pack2_2.ProductoAlmacenado = producto3;
            pack2_2.CantidadAlmacenada = 20;

            ProductoAlmacen pack3 = new ProductoAlmacen();
            pack3.ProductoAlmacenado = producto3;
            pack3.CantidadAlmacenada = 30;

            listaProductoAlmacen1.Add(pack1_1);
            listaProductoAlmacen1.Add(pack1_2);

            listaProductoAlmacen2.Add(pack2_1);
            listaProductoAlmacen2.Add(pack2_2);

            listaProductoAlmacen3.Add(pack3);

            Almacen almacen1 = new Almacen();
            almacen1.CodigoAlmacen = "ALM01";
            almacen1.CodigoSucursal = "Sucursal 1";
            almacen1.Direccion = "Direccion de almacen 1";
            almacen1.Telefono = "111-1111";
            almacen1.Productos = listaProductoAlmacen1;

            Almacen almacen2 = new Almacen();
            almacen2.CodigoAlmacen = "ALM02";
            almacen2.CodigoSucursal = "Sucursal 2";
            almacen2.Direccion = "Direccion de almacen 2";
            almacen2.Telefono = "222-2222";
            almacen2.Productos = listaProductoAlmacen2;

            Almacen almacen3 = new Almacen();
            almacen3.CodigoAlmacen = "ALM03";
            almacen3.CodigoSucursal = "Sucursal 3";
            almacen3.Direccion = "Direccion de almacen 3";
            almacen3.Telefono = "333-3333";
            almacen3.Productos = listaProductoAlmacen3;

            listaAlmacenes.Add(almacen1);
            listaAlmacenes.Add(almacen2);
            listaAlmacenes.Add(almacen3);

            listaProductosEmpresa.Add(producto1);
            listaProductosEmpresa.Add(producto2);
            listaProductosEmpresa.Add(producto3);

            InitializeComponent();
            labelBienvenidaAdmin.Text = "Bienvenido " + nombre;
        }

        //lo que sucede cuando la pantalla de administrador se cierra
        private void PantallaAdministradorAlmacén_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Enabled = true;//el padre se activa
            this.Owner.Visible = true;
        }


        private void btnProductosDisponibles_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;
            Almacen almacenSeleccionado;

            //seleccion de almacen
            while (true)
            {
                pantallaAlmacenes = new PantallaSeleccionarAlmacen(listaAlmacenes);
                pantallaAlmacenes.ShowDialog();
                if (pantallaAlmacenes.AlmacenSeleccionado != null) break;
            }
            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            PantallaProductosAlmacen pantallaProductos = new PantallaProductosAlmacen(almacenSeleccionado);
            pantallaProductos.Owner = this;
            this.Visible = false;
            pantallaProductos.ShowDialog();
        }

        private void BtnAnadirProducto_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;
            Almacen almacenSeleccionado;

            //seleccion de almacen
            while (true)
            {
                pantallaAlmacenes = new PantallaSeleccionarAlmacen(listaAlmacenes);
                pantallaAlmacenes.ShowDialog();
                if (pantallaAlmacenes.AlmacenSeleccionado != null) break;
            }
            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            PantallaAnadirProducto pantallaAnadirProducto = new PantallaAnadirProducto(almacenSeleccionado.Productos,listaProductosEmpresa);
            pantallaAnadirProducto.Owner = this;
            this.Visible = false;
            pantallaAnadirProducto.ShowDialog();
        }

        private void btnActualizarAlmacenes_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaActualizarAlmacenes pantallaActualizarAlmacenes = new PantallaActualizarAlmacenes();
            pantallaActualizarAlmacenes.Owner = this;
            this.Visible = false;
            pantallaActualizarAlmacenes.ShowDialog();
        }

        private void btnModificarStock_MouseClick(object sender, MouseEventArgs e)
        {
            this.ModificarStock();
        }

        public void ModificarStock()
        {
            PantallaSeleccionarAlmacen pantallaAlmacenes;

            Almacen almacenSeleccionado;

            //seleccion de almacen
            while (true)
            {
                pantallaAlmacenes = new PantallaSeleccionarAlmacen(listaAlmacenes);
                pantallaAlmacenes.ShowDialog();
                if (pantallaAlmacenes.AlmacenSeleccionado != null) break;
            }

            almacenSeleccionado = pantallaAlmacenes.AlmacenSeleccionado;

            PantallaModificarStock pantallaStock = new PantallaModificarStock(almacenSeleccionado);
            pantallaStock.ShowDialog();
        }

        private void buttonCerrarSesion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
