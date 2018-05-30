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
        }
        public bool verificarUsuario(string usuario,string contrasena)
        {
            bool valido = false;
            BindingList<Almacen> listaAlmacenes = new BindingList<Almacen>();
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

                int ingresoCorrecto = (Int32)comando.Parameters["_ingresoCorrecto"].Value;
                int rol = (Int32)comando.Parameters["_rol"].Value;
                int cantidadAlmacenes = (Int32)comando.Parameters["_cantidadAlmacenes"].Value;

                if(rol == 5 && cantidadAlmacenes>0)
                {
                    MySqlDataReader reader = comando.ExecuteReader();
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
                valido = true;
                
            }
            catch(Exception e)
            {

            }
            return valido;
        }
    }
}
