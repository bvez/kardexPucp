using System;
using System.Collections.Generic;
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
using System.ComponentModel;

namespace AccesoADatos
{
    public class DatosUsuarios
    {
        private string cadenaConexion;
        public DatosUsuarios()
        {
            
            cadenaConexion = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g2;database=inf282g2;" +
                "port=3306;password=X7X2HA;SslMode=none;";
            
            
            /*
            cadenaConexion = "server=127.0.0.1;" +
                "user=root;database=inf282g2;" +
                "port=3306;password=;SslMode=none;";
            */
        }

        public bool verificarUsuario(string usuario, string contrasena)
        {
            bool valido = false;
            try
            {

                valido = true;

            }
            catch (Exception e)
            {

            }
            return valido;
        }

        public bool verificarUsuario(string usuario, string contrasena, out BindingList<Almacen> _listaAlmacenes, out int _cantidadAlmacenes,out int _rol, out bool usuarioCorrecto)
        {
            bool conexionCorrecta = false;
            int cantidadAlmacenes = -1;
            int rol = -1;
            int ingresoCorrecto=0;

            BindingList<Almacen> listaAlmacenes = null;

            try
            {
                MySqlConnection con = new MySqlConnection(this.cadenaConexion);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "alm_loguear_usuario";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = con;
                comando.Parameters.Add("_usuario", MySqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("_contrasena", MySqlDbType.VarChar).Value = contrasena;

                comando.Parameters.Add("_ingresoCorrecto", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.Add("_rol", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.Add("_cantidadAlmacenes", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();

                ingresoCorrecto = (Int32)comando.Parameters["_ingresoCorrecto"].Value;
                rol = (Int32)comando.Parameters["_rol"].Value;
                cantidadAlmacenes = (Int32)comando.Parameters["_cantidadAlmacenes"].Value;

                //si se trata de un usuario comun(5)
                if(rol == 5 && cantidadAlmacenes>0)
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    listaAlmacenes = new BindingList<Almacen>();
                    while (reader.Read())
                    {
                        int idAlmacen = reader.GetInt32("idAlmacen");//
                        string direccion = reader.GetString("direccion");//
                        string telefono = reader.GetString("telefono");//

                        Almacen almacen= new Almacen();
                        almacen.IdAlmacen = idAlmacen;
                        almacen.Telefono = telefono;
                        almacen.Direccion = direccion;

                        listaAlmacenes.Add(almacen);
                    }
                }               

                con.Close();
                conexionCorrecta = true;
                
            }
            catch(Exception e)
            {

            }
            _cantidadAlmacenes = cantidadAlmacenes;
            _listaAlmacenes = listaAlmacenes;
            _rol = rol;
            if (ingresoCorrecto>0)
                usuarioCorrecto = true;
            else
                usuarioCorrecto = false;

            return conexionCorrecta;
        }
    }
}
