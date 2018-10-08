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
                listaT.Add(t);
            }
            reader.Close();

            conn.Close();
            return listaT;
        }

    }
}
