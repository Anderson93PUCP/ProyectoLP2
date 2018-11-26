using MySql.Data.MySqlClient;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String sql = "SELECT * FROM n_producto where estado = 1 and almacenado = 1";
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
                producto.Stock = reader.GetInt32("stock");
                producto.MinimoStock = reader.GetInt32("stokcMinimo");
                lista.Add(producto);

            }

            conn.Close();
            return lista;
        }

        public void agregarStock(string codProducto, int cantidad)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SELECCIONAR_PRODUCTO";
            cmd.Parameters.Add("_IDPRODUCTO", MySqlDbType.VarChar).Value = codProducto;
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            int cantidadP = 0;
            if (reader.Read())
            {
                cantidadP = reader.GetInt32("stock");
            }
            reader.Close(); 
            conn.Close();
            incrementarStock(codProducto, cantidad, cantidadP);
            
            
           
        }

        private void incrementarStock(string codProducto, int cantidad,int cantidadP)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "incrementarStock";
            cmd.Parameters.Add("_id_producto", MySqlDbType.VarChar).Value = codProducto;
            cmd.Parameters.Add("_stock", MySqlDbType.Int32).Value = cantidad + cantidadP;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            conn.Close();
        }
    }
}
