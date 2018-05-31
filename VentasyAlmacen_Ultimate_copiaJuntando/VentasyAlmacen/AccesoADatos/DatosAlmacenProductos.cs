using System;
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
    public class DatosAlmacenProductos
    {
        private String cadenaConexion;
        public DatosAlmacenProductos()
        {
            
            cadenaConexion = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g2;database=inf282g2;" +
                "port=3306;password=X7X2HA;SslMode=none;";
            

            /*
            cadenaConexion = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=a20151258;database=a20151258;" +
                "port=3306;password=HFzu0M;SslMode=none;";
            */
            
            /*
            cadenaConexion = "server=127.0.0.1;" +
                "user=root;database=inf282g2;" +
                "port=3306;password=;SslMode=none;";
                */
        }
        public BindingList<Producto> obtenerProductosEmpresa()
        {
            BindingList<Producto> productos = new BindingList<Producto>();

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "listar_productos_habilitados";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idProducto = reader.GetInt32("id_producto");//
                    //string codigo = reader.GetString("codigo_producto");//
                    string nombre = reader.GetString("nombre");//
                    string descripcion = reader.GetString("descripcion");
                    double precio = (double)reader.GetDecimal("precio_venta");
                    bool activo = reader.GetBoolean("activo");

                    Producto producto = new Producto();
                    producto.Id = idProducto;
                    producto.Nombre = nombre;
                    //producto.CodigoProducto = codigo;
                    producto.Descripcion = descripcion;
                    producto.Precio = precio;
                    producto.Habilitado = activo;

                    productos.Add(producto);
                }

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en productos Empresa");
            }

            return productos;
        }
        public BindingList<ProductoAlmacen> obtenerProductosAlmacen(int idAlmacen)
        {
            BindingList<ProductoAlmacen> resultado = new BindingList<ProductoAlmacen>();
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "listar_productos_almacen";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = con;
                comando.Parameters.Add("_idAlmacen", MySqlDbType.Int32).Value = idAlmacen;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idProducto = reader.GetInt32("id_producto");//
                    //string codigo = reader.GetString("codigo_producto");//
                    string nombre = reader.GetString("nombre");//
                    string descripcion = reader.GetString("descripcion");
                    int stock = reader.GetInt32("cantidadAlmacenada");
                    decimal precio = reader.GetDecimal("precio_venta");

                    Producto producto = new Producto();
                    producto.Id = idProducto;
                    producto.Nombre = nombre;
                    //producto.CodigoProducto = codigo;
                    producto.Descripcion = descripcion;
                    producto.Precio = (double)precio;

                    ProductoAlmacen productoAlmacen = new ProductoAlmacen();
                    productoAlmacen.ProductoAlmacenado = producto;
                    productoAlmacen.CantidadAlmacenada = stock;

                    resultado.Add(productoAlmacen);
                }

                con.Close();
            }
            catch (Exception e) {
                Console.WriteLine("Error en productoAlmacen");
            }

            return resultado;
        }

        public BindingList<Producto> obtenerProductosRegistrables(int idAlmacen)
        {
            BindingList<Producto> resultado = new BindingList<Producto>();

            try
            {
                BindingList<Producto> productos = new BindingList<Producto>();

                try
                {
                    MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                    con.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandText = "alm_listar_productos_registrables";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Connection = con;
                    comando.Parameters.Add("_idAlmacen", MySqlDbType.Int32).Value = idAlmacen;

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        int idProducto = reader.GetInt32("id_producto");//
                        //string codigo = reader.GetString("codigo_producto");//
                        string nombre = reader.GetString("nombre");//
                        string descripcion = reader.GetString("descripcion");
                        double precio = (double)reader.GetDecimal("precio_venta");
                        bool activo = reader.GetBoolean("activo");

                        Producto producto = new Producto();
                        producto.Id = idProducto;
                        producto.Nombre = nombre;
                        //producto.CodigoProducto = codigo;
                        producto.Descripcion = descripcion;
                        producto.Precio = precio;
                        producto.Habilitado = activo;

                        productos.Add(producto);
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                }

                return productos;
            }
            catch (Exception e) { }

            return resultado;
        }


        //UNICO FALTANTE
        public Producto obtenerProducto(int idProducto)
        {
            Producto resultado = null;

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM PRODUCTO " +
                    "WHERE HABILITADO = 1 AND IDPRODUCTO = " + idProducto.ToString();
                comando.Connection = con;

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                
                string codigo = reader.GetString("CODPRODUCTO");//
                string nombre = reader.GetString("NOMBRE");//
                string descripcion = reader.GetString("DESCRIPCIONPROD");

                resultado = new Producto();

                resultado.Id = idProducto;
                resultado.Nombre = nombre;
                resultado.CodigoProducto = codigo;
                resultado.Descripcion = descripcion;

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("AQUI");
            }
           

            return resultado;
        }

        public bool insertarProductoAlmacen(int idAlmacen,int idProducto,int stockInicial)
        {
            bool result = false;
            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_producto_almacen";
                comando.Connection = con;
                comando.Parameters.Add("_idProducto", MySqlDbType.Int32).Value = idProducto;
                comando.Parameters.Add("_idAlmacen", MySqlDbType.Int32).Value = idAlmacen;
                comando.Parameters.Add("_stockInicial", MySqlDbType.Int32).Value = stockInicial;

                comando.ExecuteNonQuery();
                con.Close();
                result = true;
            }
            catch(Exception e)
            {

            }
            return result;
        }
        public bool actualizarStock(int idAlmacen, int idProducto,int nuevoStock)
        {
            bool result = false;
            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_actualizar_stock";
                comando.Connection = con;
                comando.Parameters.Add("_idAlmacen", MySqlDbType.Int32).Value = idAlmacen;
                comando.Parameters.Add("_idProducto", MySqlDbType.Int32).Value = idProducto;
                comando.Parameters.Add("_nuevoStock", MySqlDbType.Int32).Value = nuevoStock;

                comando.ExecuteNonQuery();

                con.Close();
                result = true;
            }
            catch { }
            return result;
        }
    }
}
