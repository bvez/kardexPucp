using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AccesoADatos.Ventas
{
    public class DatosVentas
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";

        public BindingList<Venta> listarVentas()
        {
            // variables que tienen datos

            BindingList<Venta> lista = new BindingList<Venta>();
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM ven_ventas";
            cmd.Connection = con;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //lectura de datos
                Venta ce = new Venta(/*datos*/);
                lista.Add(ce);
            }
            return lista;
        }

        public int insertarVenta(Venta obj)
        {
            int id = -1;
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            
            

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return id;
        }
        public bool asignarCliente(int idVenta, int idCliente)
        {
            bool exito = true;
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ASIGNAR_CLIENTE";
            cmd.Parameters.Add("_id_cliente", MySqlDbType.Int32).Value = idCliente;
            cmd.Parameters.Add("_id_venta", MySqlDbType.Int32).Value = idVenta;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return exito;
        }
    }
}