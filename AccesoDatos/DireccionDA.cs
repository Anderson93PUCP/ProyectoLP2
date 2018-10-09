using Clases;
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
    public class DireccionDA
    {
        public DireccionDA()
        {

        }

        public BindingList<Region> listarDepartamentos()
        {
            try
            {
                BindingList<Region> departamentos = new BindingList<Region>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM regions";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Region departamento = new Region();
                    departamento.Id = reader.GetString("id");
                    departamento.Name = reader.GetString("name");
                    departamentos.Add(departamento);
                }
                conn.Close();
                return departamentos;
            }
            catch
            {
                return null;
            }
        }

        public BindingList<Provincia> listarProvincias(string idDepart)
        {
            try
            {
                BindingList<Provincia> provincias = new BindingList<Provincia>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM provinces where region_id=" + idDepart.ToString();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Provincia provincia = new Provincia();
                    provincia.Id = reader.GetString("id");
                    provincia.Name = reader.GetString("name");
                    provincias.Add(provincia);
                }
                conn.Close();
                return provincias;
            }
            catch
            {
                return null;
            }
        }

        public BindingList<Distrito> listarDistritos(string idDepart,string idProv)
        {
            try
            {
                BindingList<Distrito> distritos = new BindingList<Distrito>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM districts where region_id=" + idDepart.ToString() + " and province_id=" + idProv.ToString();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Distrito distrito = new Distrito();
                    distrito.Id = reader.GetString("id");
                    distrito.Name = reader.GetString("name");
                    distrito.Idprovince = reader.GetString("province_id");
                    distrito.Idregion = reader.GetString("region_id");
                    distritos.Add(distrito);
                }
                conn.Close();
                return distritos;
            }
            catch
            {
                return null;
            }
        }

        public BindingList<Direccion> listarDireccionCliente(int idCliente)
        {
            BindingList<Direccion> lista = new BindingList<Direccion> ();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            String sql = "select * from n_direccion_cli where id_cliente= "+idCliente;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Direccion direccion = new Direccion();
                direccion.Id = reader.GetInt32("id_direccion");
                direccion.DetalleDireccion = reader.GetString("direccion");
                direccion.Departamento = reader.GetString("departamento");
                direccion.Provincia = reader.GetString("provincia");
                direccion.Distrito = reader.GetString("distrito");
                lista.Add(direccion);
            }


            conn.Close();
            return lista;

        }
    }
}
