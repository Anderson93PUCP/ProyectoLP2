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
                String sql = "SELECT * FROM n_cliente";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32("id_cliente");
                    cliente.Ruc= reader.GetString("ruc");
                    cliente.Nombre = reader.GetString("nombre");
                    cliente.ApellidoPaterno = reader.GetString("apellido");
                    cliente.Email = reader.GetString("correo_electronico");
                    cliente.Telefono = reader.GetInt32("telefono");
                    cliente.Ruc_vendedor = reader.GetInt32("dni_vendedor");
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
                String sql = "SELECT * FROM n_cliente where ruc=" + ruc.ToString();
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
                    cliente.Ruc_vendedor = reader.GetInt32("dni_vendedor");
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
    }
}
