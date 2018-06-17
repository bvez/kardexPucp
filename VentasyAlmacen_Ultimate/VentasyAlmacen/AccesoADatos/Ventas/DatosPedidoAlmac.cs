using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;

namespace AccesoADatos.Ventas
{
    public class DatosPedidoAlmac
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2b;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";

        public BindingList<Pedido> listarPedidos()
        {
            int id;
            int idVenta;
            string estado;
            BindingList<Pedido> lista = new BindingList<Pedido>();

            try
            {
                
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "listar_pedido_almacen_ventas";
                cmd.Connection = con;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32("ID_PEDIDO");
                    idVenta = rdr.GetInt32("ID_VENTA");
                    estado = rdr.GetString("ESTADO");
                    Pedido ped = new Pedido(id, idVenta, estado, null);
                    lista.Add(ped);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
            return lista;
        }

        public void modificarEstado(string estado, int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "modif_estado_pedido";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("_estado", MySqlDbType.VarChar).Value = estado;
                cmd.Parameters.Add("_id_pedido", MySqlDbType.Int32).Value = id;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
        }

        public void insertarPedido(Pedido obj, BindingList<Producto> prods)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                //llenar la info del pedido

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
        }
    }
}