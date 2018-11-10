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
            String sql = "SELECT * FROM n_agencia";
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
                listaT.Add(t);
            }
            reader.Close();

            conn.Close();
            return listaT;
        }

        public void eliminarTransportista(int id)
        {
            //MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            //conn.Open();
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandText = "ELIMINAR_TRANSPORTISTA";
            //cmd.Parameters.Add("_IDTRANSPORTISTA", MySqlDbType.Int32).Value = id;
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }
        public void modificarTransportista(Transportista t)
        {
            //MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            //conn.Open();
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandText = "ELIMINAR_PEDIDO";
            //cmd.Parameters.Add("_IDPEDIDO", MySqlDbType.Int32).Value = id;
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }

    }
}
