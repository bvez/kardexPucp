using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace AccesoADatos.Ventas
{
    public class DatosPedidoAlmac
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";

        public BindingList<Pedido> listarPedidos()
        {
            int id;
            int idVenta;
            string estado;

            BindingList<Pedido> lista = new BindingList<Pedido>();
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
                Pedido ped = new Pedido(id,idVenta,estado);
                lista.Add(ped);
            }
            return lista;
        }

        public void modificarEstado(string Estado, int id)
        {
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE BLABLABLA";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void insertarPedido(Pedido obj, BindingList<Producto> prods)
        {
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            //llenar la info del pedido

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}