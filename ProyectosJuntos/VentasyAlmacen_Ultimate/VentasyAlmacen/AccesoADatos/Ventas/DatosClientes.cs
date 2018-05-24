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
    public class DatosClientes
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";
        public BindingList<ClientePersona> listarClientesNaturales()
        {
            int id_cliente;
            string nombre;
            string apellido_p;
            string apellido_m;
            int dni;
            Sexo sexo;
            string direccion;
            int telefono;
            string correo;
            DateTime fecharegistro;


            BindingList<ClientePersona> lista = new BindingList<ClientePersona>();
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "LISTAR_CLIENTES_NATURALES";
            cmd.Connection = con;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                id_cliente = rdr.GetInt32("ID_CLIENTE");
                nombre = rdr.GetString("NOMBRE");
                apellido_p = rdr.GetString("APELLIDO_P");
                apellido_m = rdr.GetString("APELLIDO_M");
                dni = rdr.GetInt32("DNI");
                if (rdr.GetInt32("SEXO") == 1) sexo = Sexo.Hombre;
                else sexo = Sexo.Mujer;
                direccion = rdr.GetString("DIRECCION");
                telefono = rdr.GetInt32("TELEFONO");
                correo = rdr.GetString("CORREO");
                fecharegistro = rdr.GetDateTime("FECHA_REGISTRO");
                ClientePersona cp = new ClientePersona(id_cliente, nombre, fecharegistro, direccion, telefono.ToString(), correo, dni.ToString(), apellido_p, apellido_m, sexo);
                lista.Add(cp);
            }
            return lista;
        }

        public BindingList<ClienteEmpresa> listarClientesJuridicos()
        {
            int id_cliente;
            string nombre;
            string direccion;
            int telefono;
            string correo;
            DateTime fecharegistro;
            int ruc;
            string gironegocio;

            BindingList<ClienteEmpresa> lista = new BindingList<ClienteEmpresa>();
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "LISTAR_CLIENTES_JURIDICOS";
            cmd.Connection = con;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //lectura de datos
                id_cliente = rdr.GetInt32("ID_CLIENTE");
                nombre = rdr.GetString("RAZON_SOCIAL");
                ruc = rdr.GetInt32("RUC");
                gironegocio = rdr.GetString("GIRO_NEGOCIO");
                direccion = rdr.GetString("DIRECCION");
                telefono = rdr.GetInt32("TELEFONO");
                correo = rdr.GetString("CORREO");
                fecharegistro = rdr.GetDateTime("FECHA_REGISTRO");
                ClienteEmpresa ce = new ClienteEmpresa(id_cliente, nombre, fecharegistro, direccion, telefono.ToString(), correo, ruc.ToString(), gironegocio);
                lista.Add(ce);
            }
            return lista;
        }

        public int insertarCliente(Cliente obj)
        {
            int id = -1;
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            if (obj is ClientePersona)
            {
                //llenar por cliente persona
            } else if (obj is ClienteEmpresa)
            {
                //lenar por cliente empresa
            }
            
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return id;
        }

        public void modificaCliente(Cliente obj)
        {
            MySqlConnection con = new MySqlConnection(cadConn);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            if (obj is ClientePersona)
            {
                //llenar por cliente persona
            }
            else if (obj is ClienteEmpresa)
            {
                //lenar por cliente empresa
            }

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}