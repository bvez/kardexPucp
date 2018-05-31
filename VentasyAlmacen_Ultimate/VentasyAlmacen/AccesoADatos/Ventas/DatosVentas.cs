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
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2;"
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
                    conceptodescuento = rdr.GetString("id_concepto_descuento");
                    productos = null;
                    Venta ce = new Venta(id, cliente, estado, fechaRegistro, productos, descuento, conceptodescuento);
                    lista.Add(ce);
                }
                con.Close();
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL.");
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
                cmd.CommandText = "_____________";


                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            } catch (Exception e){
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL.");
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
                cmd.CommandText = "_____________";


                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL.");
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
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL.");
            }
        }

    }
}