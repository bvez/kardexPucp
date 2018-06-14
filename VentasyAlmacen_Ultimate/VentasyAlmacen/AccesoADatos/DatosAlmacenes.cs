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
    public class DatosAlmacenes
    {
        private String cadenaConexion;
        public DatosAlmacenes()
        {
            
            cadenaConexion = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g2;database=inf282g2b;" +
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

        public Almacen obtenerAlmacen(int idAlmacen)
        {
            Almacen almacen = new Almacen();
            ///*
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_obtenerAlmacen";
                comando.Connection = con;
                comando.Parameters.Add("_idAlmacen", MySqlDbType.Int32).Value = idAlmacen;

                MySqlDataReader reader = comando.ExecuteReader();

                reader.Read();
                //int idLocal = reader.GetInt32("LOCAL_idLOCAL");//
                string telefono = reader.GetString("telefono");//
                string direccion = reader.GetString("direccion");//
                bool habilitado = reader.GetBoolean("habilitado");

                almacen.IdAlmacen = idAlmacen;
                almacen.Telefono = telefono;
                almacen.Direccion = direccion;
                almacen.Habilitado = habilitado;

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return almacen;
        }
        
        public BindingList<Almacen> obtenerAlmacenesTodos()
        {
            BindingList<Almacen> almacenes = new BindingList<Almacen>();
            ///*
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "listar_almacenes_todos";
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idAlmacen = reader.GetInt32("idAlmacen");//
                    string telefono = reader.GetString("telefono");//
                    string direccion = reader.GetString("direccion");//
                    bool habilitado = reader.GetBoolean("habilitado");

                    Almacen almacen= new Almacen();
                    almacen.IdAlmacen = idAlmacen;
                    almacen.Telefono = telefono;
                    almacen.Direccion = direccion;
                    almacen.Habilitado = habilitado;

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

        public BindingList<Almacen> obtenerAlmacenesHabilitados()
        {

            BindingList<Almacen> almacenes = new BindingList<Almacen>();
            ///*
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "listar_almacenes_habilitados";
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idAlmacen = reader.GetInt32("idAlmacen");//
                    string telefono = reader.GetString("telefono");//
                    string direccion = reader.GetString("direccion");//
                    bool habilitado = reader.GetBoolean("habilitado");

                    Almacen almacen = new Almacen();
                    almacen.IdAlmacen = idAlmacen;
                    almacen.Telefono = telefono;
                    almacen.Direccion = direccion;
                    almacen.Habilitado = habilitado;

                    almacenes.Add(almacen);


                }

                con.Close();
            }
            catch (Exception e)
            {

            }
            //*/
            return almacenes;
        }
        
        public bool actualizarAlmacenHabilitado(int id,bool habilitado)
        {
            bool exito = false;
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_actualizar_habilitado";
                comando.Connection = con;
                comando.Parameters.Add("_id_almacen", MySqlDbType.Int32).Value = id;
                comando.Parameters.Add("_nuevo_habilitado", MySqlDbType.Int32).Value = Convert.ToInt32(habilitado);

                MySqlDataReader reader = comando.ExecuteReader();

                con.Close();
                exito = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return exito;
        }
        public BindingList<Area> listarAreas()
        {
            BindingList<Area> areas = new BindingList<Area>();
            ///*
            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "listar_areas";
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idArea = reader.GetInt32("id_area");//
                    string nombre = reader.GetString("nombre");//

                    Area area = new Area();
                    area.IdArea = idArea;
                    area.Nombre = nombre;

                    areas.Add(area);
                }

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine("Error en listar");
            }
            //*/
            return areas;
        }

        public BindingList<IngresoSalidaProducto> listarEnviosPendientesAlmacen(int idLocalAlmacen)
        {
            BindingList<IngresoSalidaProducto> enviosPendientes = new BindingList<IngresoSalidaProducto>();

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

                    IngresoSalidaProducto salida= new IngresoSalidaProducto();
                    salida.IdIngresoSalidaProducto = idSalidaProducto;
                    salida.IdSedeOrigen = idAlmacenEnvia;
                    salida.FechaSalida = fechaSalida;
                    salida.Observaciones = observaciones;

                    enviosPendientes.Add(salida);
                }

                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return enviosPendientes;
        }

        public BindingList<LineaIngresoSalidaProducto> listarProductosSalida(int idSalidaProductos)
        {
            BindingList<LineaIngresoSalidaProducto> productos = new BindingList<LineaIngresoSalidaProducto>();
            DatosAlmacenProductos dataAlmacenProd = new DatosAlmacenProductos();

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
                    int idProducto = reader.GetInt32("Producto_idProducto");

                    LineaIngresoSalidaProducto lineaSalidaProducto = new LineaIngresoSalidaProducto();
                    lineaSalidaProducto.IdLineaIngresoSalidaProducto = idLineaSalidaProducto;
                    lineaSalidaProducto.Producto = dataAlmacenProd.obtenerProducto(idProducto);
                    lineaSalidaProducto.CantidadIngresoSalida= cantidadIngreso;
                    lineaSalidaProducto.Observaciones = observaciones;

                    productos.Add(lineaSalidaProducto);

                }

                con.Close();
            }
            catch (Exception e)
            {

            }

            if (productos.Count > 0)
                return productos;
            else return null;
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

        public int insertarSalidaProductos(int idAlmacen, int idAreaDestino,int idSedeDestino, string observaciones)
        {
            int idSalida =-1;

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_salida_producto";
                comando.Connection = con;
                comando.Parameters.Add("_id_almacen_origen", MySqlDbType.Int32).Value = idAlmacen;
                comando.Parameters.Add("_id_area_destino", MySqlDbType.Int32).Value = idAreaDestino;
                comando.Parameters.Add("_id_sede_destino", MySqlDbType.Int32).Value = idSedeDestino;
                comando.Parameters.Add("_observaciones", MySqlDbType.VarChar).Value = observaciones;
                comando.Parameters.Add("_id_salida", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                idSalida = (int)comando.Parameters["_id_salida"].Value;

                con.Close();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            return idSalida;
        }

        public int insertarLineaSalidaProductos(int idSalidaProductos,int idProducto,int cantidad,string observaciones)
        {
            int idLineaSalida = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_linea_salida";
                comando.Connection = con;
                comando.Parameters.Add("_id_salida", MySqlDbType.Int32).Value = idSalidaProductos;
                comando.Parameters.Add("_id_producto", MySqlDbType.Int32).Value = idProducto;
                comando.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = cantidad;
                comando.Parameters.Add("_observaciones", MySqlDbType.VarChar).Value = observaciones;
                comando.Parameters.Add("_id_linea_salida", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                idLineaSalida = (int)comando.Parameters["_id_linea_salida"].Value;

                con.Close();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            return idLineaSalida;
        }

        public int insertarIngresoProductos(int idAlmacen, int idAreaOrigen,int idSedeOrigen, string observaciones)
        {
            int idIngreso = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_ingreso_producto";
                comando.Connection = con;
                comando.Parameters.Add("_id_area_origen", MySqlDbType.Int32).Value = idAreaOrigen;
                comando.Parameters.Add("_id_sede_origen", MySqlDbType.Int32).Value = idSedeOrigen;
                comando.Parameters.Add("_id_almacen_destino", MySqlDbType.Int32).Value = idAlmacen;
                comando.Parameters.Add("_observaciones", MySqlDbType.VarChar).Value = observaciones;
                comando.Parameters.Add("_id_ingreso", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                idIngreso = (int)comando.Parameters["_id_ingreso"].Value;

                con.Close();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            return idIngreso;
        }

        public int insertarLineaIngresoProductos(int idIngresoProductos, int idProducto, int cantidad, string observaciones)
        {
            int idLineaIngreso = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_linea_ingreso";
                comando.Connection = con;
                comando.Parameters.Add("_id_ingreso_producto", MySqlDbType.Int32).Value = idIngresoProductos;
                comando.Parameters.Add("_id_producto", MySqlDbType.Int32).Value = idProducto;
                comando.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = cantidad;
                comando.Parameters.Add("_observaciones", MySqlDbType.VarChar).Value = observaciones;
                comando.Parameters.Add("_id_linea_ingreso", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                idLineaIngreso = (int)comando.Parameters["_id_linea_ingreso"].Value;

                con.Close();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }

            return idLineaIngreso;
        }

        public int insertarPedidoProduccion(int idAlmacen,out bool registroCorrecto)
        {
            int idPedido = -1;
            bool correcto = false;

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_pedido_produccion";
                comando.Connection = con;
                comando.Parameters.Add("_id_almacen", MySqlDbType.Int32).Value = idAlmacen;
                comando.Parameters.Add("id_pedido", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                idPedido = (int)comando.Parameters["id_pedido"].Value;

                con.Close();
                correcto = true;
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            registroCorrecto = correcto;
            return idPedido;
        }

        public int insertarLineaPedidoProduccion(int idPedidoProduccion,int idProducto,int cantidad,string observaciones,out bool registroCorrecto)
        {
            int idLineaPedido=0;
            bool correcto = false;

            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "alm_registrar_detalle_pedido_produccion";
                comando.Connection = con;
                comando.Parameters.Add("_id_pedido_produccion", MySqlDbType.Int32).Value = idPedidoProduccion;
                comando.Parameters.Add("_id_producto", MySqlDbType.Int32).Value = idProducto;
                comando.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = cantidad;
                comando.Parameters.Add("_observaciones", MySqlDbType.VarChar).Value = observaciones;
                comando.Parameters.Add("_id_detalle_pedido", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                idLineaPedido = (int)comando.Parameters["_id_detalle_pedido"].Value;

                con.Close();
                correcto = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            registroCorrecto = correcto;
            return idLineaPedido;
        }
    }
}
