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
    public class FacturaDA
    {
        public FacturaDA()
        {

        }

        public BindingList<Factura> listar()
        {
            BindingList<Pedido> listaPedidoFacturados = new BindingList<Pedido>();
            PedidoDA pedidoDA = new PedidoDA();
            listaPedidoFacturados = pedidoDA.listarPedidos(4);
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_FACTURAS";
            MySqlDataReader reader = cmd.ExecuteReader();
            BindingList<Factura> listaFacturas = new BindingList<Factura>();
            while (reader.Read())
            {
                Factura factura = new Factura();
                factura.Total_imp = reader.GetDouble("total_imp");
                factura.Valor_neto = reader.GetDouble("totalv_neto");
                factura.PagoVendedor = reader.GetDouble("montoPagoVendedor");
                factura.Neto_pagar = reader.GetDouble("neto_pagar");
                factura.Total_descuento = reader.GetDouble("total_desc");
                factura.IdVenta = reader.GetInt32("id_facturas");
                factura.EstadoPagoVendedor = reader.GetInt32("estadoPagoVendedor");
                factura.Estado = (EstadoVenta)1;
                factura.EstadoPagoCliente = (EstadoPagoCliente)reader.GetInt32("estadoVenta");
                foreach(Pedido p in listaPedidoFacturados)
                {
                    if(p.IdVenta == reader.GetInt32("id_pedido"))
                    {
                        Pedido pedidoF = new Pedido();
                        pedidoF = p;
                        factura.Pedido = pedidoF;
                        break;
                    }
                }
                listaFacturas.Add(factura);
            }
            conn.Close();
            return listaFacturas;

        }
        public void elimFact(int idFactura,int idPedido)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ELIMINAR_FACTURA";
            cmd.Parameters.Add("_IDFACTURA", MySqlDbType.Int32).Value = idFactura;
            cmd.Parameters.Add("_IDPEDIDO", MySqlDbType.Int32).Value = idPedido;
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
