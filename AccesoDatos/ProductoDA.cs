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
    public class ProductoDA
    {
        public ProductoDA()
        {

        }

        public BindingList<Producto> listar()
        {
            BindingList<Producto> lista = new BindingList<Producto> ();
            BindingList<Transportista> listaT = new BindingList<Transportista>();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT * FROM n_producto";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Codigo = reader.GetString("id_producto");
                producto.Nombre = reader.GetString("nombre");
                switch (reader.GetString("UnidMedida"))
                {
                    case ("UNIDAD"):
                        producto.Um = Medida.unidad;
                        break;
                    case ("CIENTO"):
                        producto.Um = Medida.ciento;
                        break;
                    case ("METRO"):
                        producto.Um = Medida.metro;
                        break;
                    case ("BOLSA"):
                        producto.Um = Medida.bolsa;
                        break;
                    case ("DOCENA"):
                        producto.Um = Medida.docena;
                        break;
                    case ("KILOGRAMO"):
                        producto.Um = Medida.kilogramo;
                        break;
                }
                producto.Precio = reader.GetDouble("precio");
                producto.Descripcion = reader.GetString("descripcion");

                lista.Add(producto);

            }

            conn.Close();
            return lista;
        }
    }
}
