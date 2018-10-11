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
    public class PedidoDA
    {
       public PedidoDA()
        {

        }

        public int agregar(Pedido pedido)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "insertarPedido";

            cmd.Parameters.Add("_llegada", MySqlDbType.VarChar).Value =pedido.Direccion.DetalleDireccion;
            cmd.Parameters.Add("_dniVendedor", MySqlDbType.VarChar).Value = pedido.Cliente.Dni_vendedor;
            cmd.Parameters.Add("_idCliente", MySqlDbType.Int32).Value = pedido.Cliente.Id;
            cmd.Parameters.Add("_idAgencia", MySqlDbType.Int32).Value = pedido.Transportista.Id;
            cmd.Parameters.Add("_idDireccion", MySqlDbType.Int32).Value = pedido.Direccion.Id;
            cmd.Parameters.Add("_idPedido", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int idPedidoIngresado = Int32.Parse(cmd.Parameters["_idPedido"].Value.ToString());
            conn.Close();
            return idPedidoIngresado;
        }
        public void AgregarDetalle(int idPedido,DetallePedido detalle)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            String sql = "INSERT INTO n_detalle_pedido ( cantidad, descuento1, subtotal, id_pedido, id_producto, estado) values " +
                "("+detalle.Cantidad+","+detalle.Desc+","+detalle.Subtotal+","+idPedido+",'"+detalle.proCod+"',1)";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
