using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AccesoADatos.Ventas
{
    public class DatosClientes
    {
        string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2b;"
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
            try { 
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "listar_clientes_naturales";
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
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
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
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "listar_clientes_juridicos";
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
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
            return lista;
        }

        public int insertarCliente(Cliente obj)
        {
            int id = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                if (obj is ClientePersona)
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "insertar_cliente_natural";
                    cmd.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = ((ClientePersona)obj).nombre;
                    cmd.Parameters.Add("_apellido_p", MySqlDbType.VarChar).Value = ((ClientePersona)obj).Apellido_P;
                    cmd.Parameters.Add("_apellido_m", MySqlDbType.VarChar).Value = ((ClientePersona)obj).Apellido_M;
                    cmd.Parameters.Add("_dni", MySqlDbType.Int32).Value = Int32.Parse(((ClientePersona)obj).dni);
                    if (((ClientePersona)obj).sexo == Sexo.Hombre) cmd.Parameters.Add("_sexo", MySqlDbType.Int32).Value = 1;
                    else cmd.Parameters.Add("_sexo", MySqlDbType.Int32).Value = 0;
                    cmd.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = ((ClientePersona)obj).direccion;
                    cmd.Parameters.Add("_telefono", MySqlDbType.Int32).Value = Int32.Parse(((ClientePersona)obj).telefonoContacto);
                    cmd.Parameters.Add("_correo", MySqlDbType.VarChar).Value = ((ClientePersona)obj).email;
                    cmd.Parameters.Add("_fecha_registro", MySqlDbType.DateTime).Value = ((ClientePersona)obj).fechaRegistro;
                    cmd.Parameters.Add("_activo", MySqlDbType.Int32).Value = 1;
                    cmd.Parameters.Add("_usuario_registro", MySqlDbType.VarChar).Value = "admin";
                    cmd.Parameters.Add("_id_cliente", MySqlDbType.DateTime).Direction = System.Data.ParameterDirection.Output;
                }
                else if (obj is ClienteEmpresa)
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "insertar_cliente_juridico";
                    cmd.Parameters.Add("_razon_social", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).nombre;
                    cmd.Parameters.Add("_ruc", MySqlDbType.Int32).Value = Int32.Parse(((ClienteEmpresa)obj).ruc);
                    cmd.Parameters.Add("_giro_negocio", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).giroNegocio;
                    cmd.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).direccion;
                    cmd.Parameters.Add("_telefono", MySqlDbType.Int32).Value = Int32.Parse(((ClienteEmpresa)obj).telefonoContacto);
                    cmd.Parameters.Add("_correo", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).email;
                    cmd.Parameters.Add("_activo", MySqlDbType.Int32).Value = 1;
                    cmd.Parameters.Add("_usuario_registro", MySqlDbType.VarChar).Value = "admin";
                    cmd.Parameters.Add("_fecha_registro", MySqlDbType.DateTime).Value = ((ClienteEmpresa)obj).fechaRegistro;
                    cmd.Parameters.Add("_id_cliente", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                }
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                id = Int32.Parse(cmd.Parameters["_id_cliente"].Value.ToString());
                con.Close();
            } catch (Exception e)
            {
            }
            
            return id;
        }

        public void modificaCliente(Cliente obj)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                if (obj is ClientePersona)
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "modificar_cliente_natural";
                    cmd.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = ((ClientePersona)obj).nombre;
                    cmd.Parameters.Add("_apellido_paterno", MySqlDbType.VarChar).Value = ((ClientePersona)obj).Apellido_P;
                    cmd.Parameters.Add("_apellido_materno", MySqlDbType.VarChar).Value = ((ClientePersona)obj).Apellido_M;
                    cmd.Parameters.Add("_dni", MySqlDbType.Int32).Value = Int32.Parse(((ClientePersona)obj).dni);
                    if (((ClientePersona)obj).sexo == Sexo.Hombre) cmd.Parameters.Add("_sexo", MySqlDbType.Int32).Value = 1;
                    else cmd.Parameters.Add("_sexo", MySqlDbType.Int32).Value = 0;
                    cmd.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = ((ClientePersona)obj).direccion;
                    cmd.Parameters.Add("_telefono", MySqlDbType.Int32).Value = Int32.Parse(((ClientePersona)obj).telefonoContacto);
                    cmd.Parameters.Add("_correo", MySqlDbType.VarChar).Value = ((ClientePersona)obj).email;
                    cmd.Parameters.Add("_fecha_registro", MySqlDbType.DateTime).Value = ((ClientePersona)obj).fechaRegistro;
                    cmd.Parameters.Add("_activo", MySqlDbType.Int32).Value = 1;
                    cmd.Parameters.Add("_usuario_registro", MySqlDbType.VarChar).Value = "admin";
                    cmd.Parameters.Add("_id_cliente", MySqlDbType.DateTime).Direction = System.Data.ParameterDirection.Output;
                }
                else if (obj is ClienteEmpresa)
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "modificar_cliente_juridico";
                    cmd.Parameters.Add("_razon_social", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).nombre;
                    cmd.Parameters.Add("_ruc", MySqlDbType.Int32).Value = Int32.Parse(((ClienteEmpresa)obj).ruc);
                    cmd.Parameters.Add("_giro_negocio", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).giroNegocio;
                    cmd.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).direccion;
                    cmd.Parameters.Add("_telefono", MySqlDbType.Int32).Value = Int32.Parse(((ClienteEmpresa)obj).telefonoContacto);
                    cmd.Parameters.Add("_correo", MySqlDbType.VarChar).Value = ((ClienteEmpresa)obj).email;
                    cmd.Parameters.Add("_activo", MySqlDbType.Int32).Value = 1;
                    cmd.Parameters.Add("_usuario_registro", MySqlDbType.VarChar).Value = "admin";
                    cmd.Parameters.Add("_fecha_registro", MySqlDbType.DateTime).Value = ((ClienteEmpresa)obj).fechaRegistro;
                    cmd.Parameters.Add("_id_cliente", MySqlDbType.DateTime).Direction = System.Data.ParameterDirection.Output;
                }

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido una excepción durante la ejecución de la accion SQL: " + e.Message);
            }
        }
    }
}