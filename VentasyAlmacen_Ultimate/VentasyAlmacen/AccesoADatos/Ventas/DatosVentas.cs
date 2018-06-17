using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace AccesoADatos.Ventas
{
    public class DatosVentas
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2b;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";

        public BindingList<Venta> listarVentas()
        {
            int id;
            Cliente cliente;
            String estado;
            DateTime fechaRegistro;
            BindingList<LineaProducto> productos = new BindingList<LineaProducto>();
            double descuento;
            string conceptodescuento;

            BindingList<Venta> lista = new BindingList<Venta>();
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "listar_ventas";
                cmd.Connection = con;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32("id");
                    cliente = null;
                    estado = rdr.GetString("estado");
                    fechaRegistro = rdr.GetDateTime("fecha_registro");
                    descuento = rdr.GetDouble("descuento");
                    conceptodescuento = rdr.GetString("concepto_descuento");
                    productos = null;
                    Venta ce = new Venta(id, cliente, estado, fechaRegistro, productos, descuento, conceptodescuento);
                    lista.Add(ce);
                }
                con.Close();
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
            return lista;
        }

        public int insertarVenta(Venta obj)
        {
            int id = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "insertar_venta";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("_id_cliente", MySqlDbType.Int32).Value = obj.Cliente.Id;
                cmd.Parameters.Add("_estado", MySqlDbType.VarChar).Value = obj.Estado;
                cmd.Parameters.Add("_descuento", MySqlDbType.Decimal).Value = obj.Descuento/100;
                cmd.Parameters.Add("_concepto_descuento", MySqlDbType.VarChar).Value = obj.Conceptodescuento;
                cmd.Parameters.Add("_fecha_registro", MySqlDbType.DateTime).Value = DateTime.Today;
                cmd.Parameters.Add("_id_user_registro", MySqlDbType.VarChar).Value = "admin";
                cmd.Parameters.Add("_es_activo", MySqlDbType.VarChar).Value = 1;
                cmd.Parameters.Add("_id_venta", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                id = Int32.Parse(cmd.Parameters["_id_venta"].Value.ToString());

                foreach (LineaProducto linea in obj.Productos)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandText = "insertar_linea_prod_venta";
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd2.Parameters.Add("_id_venta", MySqlDbType.Int32).Value = id;
                    cmd2.Parameters.Add("_id_producto", MySqlDbType.Int32).Value = linea.Producto.Id;
                    cmd2.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = linea.Cantidad;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                }

                con.Close();
            } catch (Exception e){
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
            return id;
        }

        public void modificarEstado(string estado, int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "modif_estado_venta";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("_estado", MySqlDbType.VarChar).Value = estado;
                cmd.Parameters.Add("_id_venta", MySqlDbType.Int32).Value = id;

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
        }

        public void anularVenta(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "anular_venta";
                cmd.Parameters.Add("_id_venta", MySqlDbType.Int32).Value = id;

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
        }

        public BindingList<LineaProducto> lineasVenta(int id)
        {
            int id_prod;
            int cantidad;
            BindingList<LineaProducto> lista = new BindingList<LineaProducto>();
            BindingList<Producto> productos;

            DatosProducto ProductoDA = new DatosProducto();
            productos = ProductoDA.listarProductos();

            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "obtener_lineas_de_venta";
                cmd.Connection = con;
                cmd.Parameters.Add("_id_venta", MySqlDbType.Int32).Value = id;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32("id");
                    id_prod = rdr.GetInt32("id_producto");
                    cantidad = rdr.GetInt32("cantidad");

                    foreach (Producto p in productos)
                    {
                        if (p.Id == id_prod)
                        {
                            Producto newprod = p;
                            LineaProducto lp = new LineaProducto(cantidad, newprod);
                            lista.Add(lp);
                            break;
                        }
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }

            return lista;
        }

    }
}