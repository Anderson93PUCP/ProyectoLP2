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
    public class TransportistaDA
    {

        public BindingList<Transportista> listar()
        {
            BindingList<Transportista> listaT = new BindingList<Transportista>();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT * FROM n_agencia where estado=1";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Transportista t = new Transportista();
                t.Id = reader.GetInt32("id_agencia");
                t.Nombre = reader.GetString("nombre");
                t.Ruc = reader.GetString("RUC");
                t.Email = reader.GetString("Email");
                t.Telefono = reader.GetInt32("Telefono");
                t.Direccion = reader.GetString("direccion");
                listaT.Add(t);
            }
            reader.Close();

            conn.Close();
            return listaT;
        }

        public BindingList<Transportista> listar(string ruc)
        {
            BindingList<Transportista> listaT = new BindingList<Transportista>();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT * FROM n_agencia where estado=1 and RUC="+ruc.ToString() ;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Transportista t = new Transportista();
                t.Id = reader.GetInt32("id_agencia");
                t.Nombre = reader.GetString("nombre");
                t.Ruc = reader.GetString("RUC");
                t.Email = reader.GetString("Email");
                t.Telefono = reader.GetInt32("Telefono");
                t.Direccion = reader.GetString("direccion");
                listaT.Add(t);
            }
            reader.Close();

            conn.Close();
            return listaT;
        }

        public bool eliminarTransportista(int id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ELIMINAR_TRANSPORTISTA";
                cmd.Parameters.Add("_idAgencia", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }catch
            {
                return false;
            }
        }

        public bool agregarTransportista(Transportista t)
        {
            try
            {
                int alcance = 1;
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AGREGAR_TRANSPORTISTA";

                cmd.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = t.Direccion;
                cmd.Parameters.Add("_telefono", MySqlDbType.Int32).Value = t.Telefono;
                cmd.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = t.Nombre;
                cmd.Parameters.Add("_email", MySqlDbType.VarChar).Value = t.Email;
                if (t.Alcance == Alcance.nacional) alcance = 1;
                else alcance = 2;
                cmd.Parameters.Add("_alcance", MySqlDbType.Int32).Value = alcance;
                cmd.Parameters.Add("_ruc", MySqlDbType.VarChar).Value = t.Ruc;
                cmd.Parameters.Add("_estado", MySqlDbType.Int32).Value = 1;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }catch
            {
                return false;
            }
        }

        public bool modificarTransportista(Transportista t)
        {
            try
            {
                int alcance = 1;
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "MODIFICAR_TRANSPORTISTA";

                cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = t.Id;
                cmd.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = t.Direccion;
                cmd.Parameters.Add("_telefono", MySqlDbType.Int32).Value = t.Telefono;
                cmd.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = t.Nombre;
                cmd.Parameters.Add("_email", MySqlDbType.VarChar).Value = t.Email;
                if (t.Alcance == Alcance.nacional) alcance = 1;
                else alcance = 2;
                cmd.Parameters.Add("_alcance", MySqlDbType.Int32).Value = alcance;
                cmd.Parameters.Add("_ruc", MySqlDbType.VarChar).Value = t.Ruc;
                cmd.Parameters.Add("_estado", MySqlDbType.Int32).Value = 1;
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
