using MySql.Data.MySqlClient;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class UsuarioDA
    {
        public UsuarioDA()
        {

        }

        public BindingList<Persona> listarUsarios()
        {
            try
            {
                BindingList<Persona> usuarios = new BindingList<Persona>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM n_usuarios";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                int tipo = 0;
                while (reader.Read())
                {
                    Persona usuario = null;
                    tipo = reader.GetInt32("tipoUsuario");
                    switch (tipo)
                    {
                        case 0:
                            usuario = new Administrador();
                            break;
                        case 1:
                            usuario = new Vendedor();
                            break;
                        case 2:
                            usuario = new Operario();
                            break;
                    }
                    usuario.IDUsuario1 = reader.GetString("IDusuario");
                    usuario.Dni = reader.GetString("dni_empleado");
                    usuario.Nombre = reader.GetString("nombre");
                    usuario.Apellido = reader.GetString("apellido_paterno");
                    usuario.Estado = reader.GetInt32("estado");
                    usuario.Fecha_ingreso = reader.GetDateTime("fecha_inicio");
                    usuario.Edad = reader.GetInt32("edad");
                    usuario.Direccion = reader.GetString("direccion");
                    usuario.Telefono = reader.GetInt32("telefono1");
                    usuario.Password = reader.GetString("contrasenia");
                    usuario.TipoUsuario = reader.GetInt32("tipoUsuario");
                    usuarios.Add(usuario);
                }
                conn.Close();
                return usuarios;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public BindingList<Persona> listarUsarios(string dni,string rol)
        {
            try
            {
                BindingList<Persona> usuarios = new BindingList<Persona>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = "";
                int idrol = -1;
                if (dni!="")
                {
                    sql= "SELECT * FROM n_usuarios where dni_empleado=" + dni.ToString();
                }else
                {
                    if (rol == "Administrador") idrol = 0;
                    else if (rol == "Vendedor") idrol = 1;
                    else if (rol == "Operario") idrol = 2;
                    sql = "SELECT * FROM n_usuarios where tipoUsuario=" + idrol.ToString();
                }
                 
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                int tipo = 0;
                while (reader.Read())
                {
                    Persona usuario = null;
                    tipo = reader.GetInt32("tipoUsuario");
                    switch (tipo)
                    {
                        case 0:
                            usuario = new Administrador();
                            break;
                        case 1:
                            usuario = new Vendedor();
                            break;
                        case 2:
                            usuario = new Operario();
                            break;
                    }
                    usuario.IDUsuario1 = reader.GetString("IDusuario");
                    usuario.Dni = reader.GetString("dni_empleado");
                    usuario.Nombre = reader.GetString("nombre");
                    usuario.Apellido = reader.GetString("apellido_paterno");
                    usuario.Estado = reader.GetInt32("estado");
                    usuario.Fecha_ingreso = reader.GetDateTime("fecha_inicio");
                    usuario.Edad = reader.GetInt32("edad");
                    usuario.Direccion = reader.GetString("direccion");
                    usuario.Telefono = reader.GetInt32("telefono1");
                    usuario.Password = reader.GetString("contrasenia");
                    usuario.TipoUsuario = reader.GetInt32("tipoUsuario");
                    usuarios.Add(usuario);
                }
                conn.Close();
                return usuarios;
            }
            catch
            {
                return null;
            }
        }

        public BindingList<Persona> listarVendedores()
        {
            try
            {
                BindingList<Persona> usuarios = new BindingList<Persona>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM n_usuarios where tipoUsuario=1";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                int tipo = 0;
                while (reader.Read())
                {
                    Persona usuario = new Vendedor();
                    usuario.Dni = reader.GetString("dni_empleado");
                    usuario.Nombre = reader.GetString("nombre");
                    usuarios.Add(usuario);
                }
                conn.Close();
                return usuarios;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
