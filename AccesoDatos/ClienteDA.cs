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
    public class ClienteDA
    {
        public ClienteDA()
        {

        }

        public BindingList<Cliente> listarClientes()
        {
            try
            {
                BindingList<Cliente> clientes = new BindingList<Cliente>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "select * from n_cliente c,n_usuarios u where  c.dni_vendedor=u.dni_empleado and c.estado='ACTIVO'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    Vendedor vendedor = new Vendedor();
                    //10
                    vendedor.Nombre = reader.GetString(10);
                    vendedor.Apellido = reader.GetString(11);
                    cliente.Vendedor = vendedor;
                    cliente.Id = reader.GetInt32("id_cliente");
                    cliente.Ruc= reader.GetString("ruc");
                    cliente.Nombre = reader.GetString("nombre");
                    cliente.ApellidoPaterno = reader.GetString("apellido");
                    cliente.Email = reader.GetString("correo_electronico");
                    cliente.Telefono = reader.GetInt32("telefono");
                    cliente.Dni_vendedor = reader.GetString("dni_vendedor");
                    clientes.Add(cliente);
                }
                conn.Close();
                return clientes;
            }
            catch
            {
                return null;
            }
        }

        public BindingList<Cliente> listarClientes(string ruc)
        {
            try
            {
                BindingList<Cliente> clientes = new BindingList<Cliente>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM n_cliente where estado='ACTIVO' and ruc=" + ruc.ToString();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32("id_cliente");
                    cliente.Ruc = reader.GetString("ruc");
                    cliente.Nombre = reader.GetString("nombre");
                    cliente.ApellidoPaterno = reader.GetString("apellido");
                    cliente.Email = reader.GetString("correo_electronico");
                    cliente.Telefono = reader.GetInt32("telefono");
                    cliente.Dni_vendedor = reader.GetString("dni_vendedor");
                    clientes.Add(cliente);
                }
                conn.Close();
                return clientes;
            }
            catch
            {
                return null;
            }
        }

        public int registrarCliente(Cliente cliente)
        {
            try
            {
                //BindingList<Cliente> clientes = new BindingList<Cliente>();
                //MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                //conn.Open();

                //MySqlCommand cmd = new MySqlCommand();
                //String sql = "INSERT INTO n_cliente" +
                //                "(ruc,nombre,apellido,correo_electronico,telefono,tipo,dni_vendedor)" +
                //                 "VALUES" + "('" +
                //                cliente.Ruc + "','" +
                //                cliente.Nombre + "','" +
                //                 "','" +
                //                cliente.Email + "'," +
                //                cliente.Telefono + "," +
                //                "1,'" +
                //                cliente.Dni_vendedor + "')";
                //cmd.CommandText = sql;
                //cmd.Connection = conn;
                //cmd.CommandText = sql;
                //cmd.ExecuteNonQuery();
                //conn.Close();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "INSERTAR_CLIENTE";

                cmd.Parameters.Add("_RUC", MySqlDbType.VarChar).Value = cliente.Ruc;
                cmd.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = cliente.Nombre;
                cmd.Parameters.Add("_EMAIL", MySqlDbType.VarChar).Value = cliente.Email;
                cmd.Parameters.Add("_TELEFONO", MySqlDbType.Int32).Value = cliente.Telefono;
                cmd.Parameters.Add("_APELLIDO", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("_TIPO", MySqlDbType.Int32).Value = 1;
                cmd.Parameters.Add("_DNIVENDEDOR", MySqlDbType.Int32).Value = cliente.Dni_vendedor;
                cmd.Parameters.Add("_IDCLIENTE", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int idCliente = Int32.Parse(cmd.Parameters["_IDCLIENTE"].Value.ToString());
                conn.Close();
                return idCliente;
            }
            catch
            {
                return 0;
            }
        }

        public void AgregarDirecciones(int idCliente, Direccion direccion, int principal)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            String sql = "INSERT INTO n_direccion_cli ( direccion, departamento, provincia, distrito, principal, id_cliente) values " +
                "('" + direccion.DetalleDireccion + "','" + direccion.Departamento + "','" + direccion.Provincia + "','" + direccion.Distrito + "'," +
                principal + ","+ idCliente+ ")";

            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool eliminarCliente(int id)
        {
            try
            {
                BindingList<Cliente> clientes = new BindingList<Cliente>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "UPDATE n_cliente " +
                            "SET " +
                             "estado = 'ELIMINADO' " +
                             "WHERE id_cliente =" + id.ToString();
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


        public void eliminarDirecciones(int id)
        {
            try
            {
                BindingList<Cliente> clientes = new BindingList<Cliente>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "DELETE FROM n_direccion_cli " +
                             "WHERE id_cliente =" + id.ToString();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
            }
        }

        public bool modificarCliente(Cliente cliente)
        {
            //try
            //{
            //    BindingList<Cliente> clientes = new BindingList<Cliente>();
            //    MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            //    conn.Open();

            //    MySqlCommand cmd = new MySqlCommand();
            //    String sql = "UPDATE n_cliente " +
            //                "SET " +
            //                 "ruc ='" + cliente.Ruc + "',"+
            //                "nombre = '" + cliente.Nombre + "'," +
            //                "apellido = '"  + "'," +
            //                "correo_electronico = '" + cliente.Email + "'," +
            //                "telefono =" + cliente.Telefono.ToString() + "," +
            //                "tipo=1 ," +
            //                "dni_vendedor =" + cliente.Dni_vendedor +
            //                  " WHERE id_cliente =" + cliente.Id.ToString();
            //    cmd.CommandText = sql;
            //    cmd.Connection = conn;
            //    cmd.CommandText = sql;
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}

            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "MODIFICAR_CLIENTE";

                cmd.Parameters.Add("_RUC", MySqlDbType.VarChar).Value = cliente.Ruc;
                cmd.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = cliente.Nombre;
                cmd.Parameters.Add("_EMAIL", MySqlDbType.VarChar).Value = cliente.Email;
                cmd.Parameters.Add("_TELEFONO", MySqlDbType.Int32).Value = cliente.Telefono;
                cmd.Parameters.Add("_APELLIDO", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("_TIPO", MySqlDbType.Int32).Value = 1;
                cmd.Parameters.Add("_DNIVENDEDOR", MySqlDbType.Int32).Value = cliente.Dni_vendedor;
                cmd.Parameters.Add("_IDCLIENTE", MySqlDbType.Int32).Value = cliente.Id;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }catch
            {
                return false;
            }
        }
    }
}
