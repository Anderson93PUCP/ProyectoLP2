using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using MySql.Data.MySqlClient;
using ProyectoLP2;

namespace AccesoDatos
{
   public class PagoDA
    {
        public BindingList<Pago> listarPagos(string dni)
        {
            try
            {
                BindingList<Pago> listapagos = new BindingList<Pago>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "select id_facturas, a.ruc, a.nombre, montoPagoVendedor from n_pedido p, n_factura_venta f, n_cliente a where p.id_pedido = f.id_pedido and f.estadoPagoVendedor = 1 and p.id_cliente = a.id_cliente and p.dni_vendedor =" + dni.ToString();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pago p = new Pago();

                    p.ID_factura1 = reader.GetInt32("id_facturas");
                    p.RUC1 = reader.GetString("ruc");
                    p.Nombre1 = reader.GetString("nombre");
                    p.Monto1 = reader.GetFloat("montoPagoVendedor");

                    listapagos.Add(p);
                                       
                }
                conn.Close();
                return listapagos;
            }
            catch
            {
                return null;
            }
        }
    }
}

