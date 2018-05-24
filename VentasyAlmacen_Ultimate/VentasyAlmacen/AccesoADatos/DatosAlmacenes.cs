﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data;
using MySql.Data.EntityFramework;
using MySql.Data.EntityFrameworkCore;
using MySql.Web;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace AccesoADatos
{
    public class DatosAlmacenes
    {
        private String cadenaConexion;
        public DatosAlmacenes()
        {
            cadenaConexion = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=a20151258;database=a20151258;" +
                "port=3306;password=HFzu0M;SslMode=none;";
        }

        public Almacen obtenerAlmacen(int idAlmacen)
        {
            Almacen almacen = new Almacen();
            ///*
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT ALM_ALMACEN.IDALMACEN,LOCAL_idLOCAL,LOCAL.DIRECCIONLOCAL,LOCAL.TELEFONOLOCAL " +
                    "FROM ALM_ALMACEN INNER JOIN LOCAL ON ALM_ALMACEN.LOCAL_IDLOCAL = LOCAL.IDLOCAL " +
                    "WHERE ALM_ALMACEN.IDALMACEN = " + idAlmacen.ToString();
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();

                int idLocal = reader.GetInt32("LOCAL_idLOCAL");//
                string telefono = reader.GetString("TELEFONOLOCAL");//
                string direccion = reader.GetString("DIRECCIONLOCAL");//

                almacen.IdAlmacen = idAlmacen;
                almacen.IdLocal = idLocal;
                almacen.Telefono = telefono;
                almacen.Direccion = direccion;

                con.Close();
            }
            catch (Exception e)
            {

            }

            return almacen;
        }

        public BindingList<Almacen> obtenerAlmacenes()
        {
            
            BindingList<Almacen> almacenes = new BindingList<Almacen>();
            ///*
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT ALM_ALMACEN.IDALMACEN,LOCAL.DIRECCIONLOCAL,LOCAL.TELEFONOLOCAL " +
                    "FROM ALM_ALMACEN INNER JOIN LOCAL ON ALM_ALMACEN.LOCAL_IDLOCAL = LOCAL.IDLOCAL";
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idAlmacen = reader.GetInt32("IDALMACEN");//
                    string telefono = reader.GetString("TELEFONOLOCAL");//
                    string direccion = reader.GetString("DIRECCIONLOCAL");//

                    Almacen almacen= new Almacen();
                    almacen.IdAlmacen = idAlmacen;
                    almacen.Telefono = telefono;
                    almacen.Direccion = direccion;

                    almacenes.Add(almacen);

                    
                }

                con.Close();
            }
            catch(Exception e)
            {

            }
            //*/
            return almacenes;
        }

        public BindingList<Sucursal> listarSucursalesDisponible()
        {
            //Esta funcion devuelve los locales que están disponibles para ser habilitados como almacenes

            BindingList<Sucursal> sucursales = new BindingList<Sucursal>();
            
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM LOCAL WHERE IDLOCAL NOT IN (SELECT LOCAL_IDLOCAL FROM ALM_ALMACEN) ";
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idLocal = reader.GetInt32("IDLOCAL");
                    string telefono = reader.GetString("TELEFONOLOCAL");
                    string direccion = reader.GetString("DIRECCIONLOCAL");

                    Sucursal sucursal = new Sucursal();
                    sucursal.IdLocal = idLocal;
                    sucursal.Telefono = telefono;
                    sucursal.Direccion = direccion;

                    sucursales.Add(sucursal);
                }

                con.Close();
            }
            catch(Exception e)
            {

            }

            return sucursales;
        }

        public BindingList<Sucursal> listarLocales()
        {
            //Esta funcion lista todas los locales registrados

            BindingList<Sucursal> locales = new BindingList<Sucursal>();

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM LOCAL";
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idLocal = reader.GetInt32("IDLOCAL");
                    string telefono = reader.GetString("TELEFONOLOCAL");
                    string direccion = reader.GetString("DIRECCIONLOCAL");

                    Sucursal sucursal = new Sucursal();
                    sucursal.IdLocal = idLocal;
                    sucursal.Telefono = telefono;
                    sucursal.Direccion = direccion;

                    locales.Add(sucursal);
                }

                con.Close();
            }
            catch (Exception e)
            {

            }

            return locales;
        }

        public BindingList<SalidaProducto> listarEnviosPendientesAlmacen(int idLocalAlmacen)
        {
            BindingList<SalidaProducto> enviosPendientes = new BindingList<SalidaProducto>();

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM ALM_SALIDA_PRODUCTO WHERE estadoEnvio = 1 AND idLocalDestino = "+idLocalAlmacen.ToString();
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idSalidaProducto = reader.GetInt32("idSalidaProducto");
                    int idAlmacenEnvia = reader.GetInt32("Almacen_idAlmacen");
                    DateTime fechaSalida = reader.GetDateTime("fechaSalida");
                    string observaciones = reader.GetString("observaciones");

                    SalidaProducto salida= new SalidaProducto();
                    salida.IdSalidaProducto = idSalidaProducto;
                    salida.IdAlmacenEnvia = idAlmacenEnvia;
                    salida.FechaSalida = fechaSalida;
                    salida.Observaciones = observaciones;

                    enviosPendientes.Add(salida);
                }

                con.Close();
            }
            catch (Exception e)
            {

            }

            return enviosPendientes;
        }

        public BindingList<LineaIngresoSalidaProducto> listarProductosSalida(int idSalidaProductos)
        {
            BindingList<LineaIngresoSalidaProducto> productos = new BindingList<LineaIngresoSalidaProducto>();

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM ALM_LINEA_SALIDA_PRODUCTO WHERE SalidaProducto_idSalidaProducto = " + idSalidaProductos.ToString();
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idLineaSalidaProducto = reader.GetInt32("idLineaSalidaProducto");
                    int cantidadIngreso = reader.GetInt32("cantidadSalida");
                    string observaciones = reader.GetString("observaciones");

                    LineaIngresoSalidaProducto lineaSalidaProducto = new LineaIngresoSalidaProducto();
                    lineaSalidaProducto.IdLineaIngresoSalidaProducto = idLineaSalidaProducto;
                    lineaSalidaProducto.Producto = null;
                    lineaSalidaProducto.CantidadIngresoSalida= cantidadIngreso;
                    lineaSalidaProducto.Observaciones = observaciones;

                    productos.Add(lineaSalidaProducto);
                }

                con.Close();
            }
            catch (Exception e)
            {

            }

            return productos;
        }

        public BindingList<LineaIngresoSalidaProducto> listarProductosIngreso(int idIngresoProductos)
        {
            BindingList<LineaIngresoSalidaProducto> productos = new BindingList<LineaIngresoSalidaProducto>();

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM ALM_LINEA_INGRESO_PRODUCTO WHERE IngresoProducto_idIngresoProducto = " + idIngresoProductos.ToString();
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idLineaIngresoProducto = reader.GetInt32("idLineaIngresoProducto");
                    int cantidadIngreso = reader.GetInt32("cantidadSalida");
                    string observaciones = reader.GetString("observaciones");

                    LineaIngresoSalidaProducto lineaSalidaProducto = new LineaIngresoSalidaProducto();
                    lineaSalidaProducto.IdLineaIngresoSalidaProducto = idLineaIngresoProducto;
                    lineaSalidaProducto.Producto = null;
                    lineaSalidaProducto.CantidadIngresoSalida = cantidadIngreso;
                    lineaSalidaProducto.Observaciones = observaciones;

                    productos.Add(lineaSalidaProducto);
                }

                con.Close();
            }
            catch (Exception e)
            {

            }

            return productos;
        }
        /*
            BindingList<ProductoAlmacen> listaProductoAlmacen1 = new BindingList<ProductoAlmacen>();
            BindingList<ProductoAlmacen> listaProductoAlmacen2 = new BindingList<ProductoAlmacen>();
            BindingList<ProductoAlmacen> listaProductoAlmacen3 = new BindingList<ProductoAlmacen>();

            DatosAlmacenProductos accesoProductos = new DatosAlmacenProductos();
            BindingList<Producto> productos = accesoProductos.obtenerProductosEmpresa();

            ProductoAlmacen pack1_1 = new ProductoAlmacen();
            pack1_1.ProductoAlmacenado = productos.ElementAt(0);
            pack1_1.CantidadAlmacenada = 10;

            ProductoAlmacen pack1_2 = new ProductoAlmacen();
            pack1_2.ProductoAlmacenado = productos.ElementAt(1);
            pack1_2.CantidadAlmacenada = 10;

            ProductoAlmacen pack2_1 = new ProductoAlmacen();
            pack2_1.ProductoAlmacenado = productos.ElementAt(1);
            pack2_1.CantidadAlmacenada = 20;

            ProductoAlmacen pack2_2 = new ProductoAlmacen();
            pack2_2.ProductoAlmacenado = productos.ElementAt(2);
            pack2_2.CantidadAlmacenada = 20;

            ProductoAlmacen pack3 = new ProductoAlmacen();
            pack3.ProductoAlmacenado = productos.ElementAt(2);
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

            almacenes.Add(almacen1);
            almacenes.Add(almacen2);
            almacenes.Add(almacen3);
            
            */
    }
}