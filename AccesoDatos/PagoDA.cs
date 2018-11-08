using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                String sql = "select id_facturas, a.ruc, a.nombre, montoPagoVendedor, estadoPagoVendedor from n_pedido p, n_factura_venta f, n_cliente a where p.id_pedido = f.id_pedido and f.estadoPagoVendedor = 1 and p.id_cliente = a.id_cliente and p.dni_vendedor =" + dni.ToString();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pago p = new Pago();
                    p.ID_factura1 = reader.GetInt32("id_facturas");
                    p.RUC1 = reader.GetString("ruc");
                    p.Nombre1 = reader.GetString("nombre");
                    p.Monto1 = reader.GetDouble("montoPagoVendedor");
                    p.EstadoPago1 = reader.GetInt32("estadoPagoVendedor");

                    listapagos.Add(p);
                                      
                }
                conn.Close();
                return listapagos;
            }
            catch
            {
                MessageBox.Show("Erreur");
                return null;
            }


        }

        public void insertarPago(BindingList<Pago> listapagos)
        {
           
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();

            

            foreach (Pago p in listapagos){

                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AGREGAR_PAGO";

                //cmd.Parameters.Add("_DNI_EMPLEADO", MySqlDbType.String).Value = p.RUC1;
                cmd.Parameters.Add("_MONTO", MySqlDbType.Double).Value = p.Monto1;
                cmd.Parameters.Add("_ID_FACTURA", MySqlDbType.Int32).Value = p.ID_factura1;

                //cmd.CommandText = "INSERT INTO n_pago_vendedor(id_factura) values(1)";
                //string sql = "INSERT INTO n_pago_vendedor" + "(id_factura,monto)" + "values" + "('" +
                //p.ID_factura1 + "','" + p.Monto1 + "')";


                //cmd.CommandText = sql;


                cmd.ExecuteNonQuery();
            }
                                              
                
                conn.Close();
                
           
        }

        public void insertarPagop(Pago p)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                                            
                
                    //cmd.CommandText = "INSERT INTO n_pago_vendedor(id_factura) values(1)";
                    string sql = "INSERT INTO n_pago_vendedor" + "(id_factura,monto)" + "values" + "('" +
                    p.ID_factura1 + "','" + p.Monto1 + "')";

                    cmd.Connection = conn;
                    cmd.CommandText = sql;


                    cmd.ExecuteNonQuery();
            


                conn.Close();

            }
            catch { }

        }




        public void cambiarEstado(string dni)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "UPDATE n_pago_vendedor SET estadoPagoVendedor = '0' "+ "WHERE "+ "dni_vendedor =" + dni.ToString();
                
                cmd.ExecuteNonQuery();
                
                conn.Close();

            }
            catch { }
        }
                
    }
}

