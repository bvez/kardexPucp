using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoADatos.Ventas
{
    public class DatosProducto
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";
        public BindingList<Producto> listarProductos()
        {
            string nombre;
            int id;
            string codigoProducto;
            bool habilitado;
            string descripcion;
            double precio;

        BindingList<Producto> lista = new BindingList<Producto>();
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "listar_productos_habilitados";
            cmd.Connection = con;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                id = rdr.GetInt32("ID_PRODUCTO");
                codigoProducto = rdr.GetInt32("ID_PRODUCTO").ToString();
                habilitado = (rdr.GetInt32("ACTIVO") != 0);
                descripcion = rdr.GetString("DESCRIPCION");
                nombre = rdr.GetString("NOMBRE");
                precio = rdr.GetDouble("PRECIO_VENTA");
                Producto p = new Producto(nombre, id, codigoProducto, habilitado, descripcion, precio);
                lista.Add(p);
            }
            return lista;
        }
    }
}