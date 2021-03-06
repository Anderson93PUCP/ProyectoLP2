﻿using MySql.Data.MySqlClient;
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
                String sql = "SELECT * FROM n_usuarios where estado=1";
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
                    sql= "SELECT * FROM n_usuarios where estado=1 and  dni_empleado=" + dni.ToString();
                }else
                {
                    if (rol == "Administrador") idrol = 0;
                    else if (rol == "Vendedor") idrol = 1;
                    else if (rol == "Operario") idrol = 2;
                    sql = "SELECT * FROM n_usuarios where estado=1 and tipoUsuario=" + idrol.ToString();
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
                String sql = "SELECT * FROM n_usuarios where tipoUsuario=1 and estado=1";
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


        public bool registrarUsuario(Persona usuario,double salario,double comision)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();
                string fecha = usuario.Fecha_ingreso.Year + "-" + usuario.Fecha_ingreso.Month + "-" + usuario.Fecha_ingreso.Day;
                MySqlCommand cmd = new MySqlCommand();
                String sql = "INSERT INTO n_usuarios" +
                                "(dni_empleado,nombre,apellido_paterno,apellido_materno,estado,fecha_inicio," +
                                "fecha_fin,edad,direccion,telefono1,telefono2,IDusuario,contrasenia,respuestaConfirmacion," +
                                "tipoUsuario,salario,comision) " +
                                "VALUES('" +
                                usuario.Dni + "','" +
                               usuario.Nombre + "','" +
                                 usuario.Apellido + "','" +
                                " '," +
                                "1,'" +
                                fecha + "','" +
                                "'," +
                                usuario.Edad.ToString() + ",'" +
                                "'," +
                                usuario.Telefono.ToString() + ",'" +
                                "','" +
                                usuario.IDUsuario1 + "','" +
                                usuario.Password + "','" +
                                "'," +
                                usuario.TipoUsuario.ToString() + "," +
                                salario.ToString() + "," +
                                comision.ToString() + ")";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarUsuario(string dni)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "UPDATE n_usuarios " +
                                "SET " +
                                "estado = 0 " +
                                 "WHERE dni_empleado = " + dni;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
