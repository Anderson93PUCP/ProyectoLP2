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
            cmd.Parameters.Add("_etapaPedido", MySqlDbType.Int32).Value = (int)pedido.Etapa;
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
        public BindingList<Pedido> listarPedidos()
        {
            BindingList<Pedido> lista = new BindingList<Pedido>();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();


            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT p.*,cli.ruc,cli.nombre nombrecli ,cli.apellido apelCli ,dircli.direccion direccion, user.nombre nombreVendedor,user.apellido_paterno apelVendedor,user.comision comision,agen.nombre nombreAgencia   FROM n_pedido p,n_cliente cli,n_usuarios user,n_direccion_cli dircli, n_agencia agen where p.id_cliente = cli.id_cliente and p.estado=1 and p.dni_vendedor = user.dni_empleado and p.id_direccion = dircli.id_direccion and p.id_agencia = agen.id_agencia and etapaProceso != 4;";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Ruc = reader.GetString("ruc");
                cliente.Nombre = reader.GetString("nombrecli");
                cliente.ApellidoPaterno = reader.GetString("apelCli");
                cliente.Dni_vendedor= reader.GetString("dni_vendedor");
                cliente.Id = reader.GetInt32("id_cliente");
                Vendedor vendedor = new Vendedor();
                vendedor.Dni = reader.GetString("dni_vendedor");
                vendedor.Nombre = reader.GetString("nombreVendedor");
                vendedor.Apellido = reader.GetString("apelVendedor");
                Transportista trans = new Transportista();
                trans.Nombre = reader.GetString("nombreAgencia");
                trans.Id = reader.GetInt32("id_agencia");
                Direccion direccion = new Direccion();
                direccion.Id = reader.GetInt32("id_agencia");
                direccion.DetalleDireccion = reader.GetString("direccion");
                Pedido pedido = new Pedido();

                pedido.IdVenta = reader.GetInt32("id_pedido");
                pedido.Cliente = cliente;
                pedido.Vendedor = vendedor;
                pedido.Transportista = trans;
                pedido.Direccion = direccion;
                pedido.Etapa = (EtapaPedido)reader.GetInt32("etapaProceso");

                pedido.Fecha_e = reader.GetDateTime("fecha_recepcion");
                
                //pedido.Etapa =
                pedido.Etapa = (EtapaPedido)reader.GetInt32("etapaProceso");
                
                        
                        
                lista.Add(pedido);
                
            }

            conn.Close();
            return lista;
        }
        public BindingList<Pedido> listarPedidos(int tipo)
        {
            BindingList<Pedido> lista = new BindingList<Pedido>();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();


            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT p.*,cli.ruc,cli.nombre nombrecli ,cli.apellido apelCli ,dircli.direccion direccion, user.nombre nombreVendedor,user.apellido_paterno apelVendedor,user.comision comision,agen.nombre nombreAgencia   FROM n_pedido p,n_cliente cli,n_usuarios user,n_direccion_cli dircli, n_agencia agen where p.id_cliente = cli.id_cliente and p.estado=1 and p.dni_vendedor = user.dni_empleado and p.id_direccion = dircli.id_direccion and p.id_agencia = agen.id_agencia and etapaProceso ="+tipo.ToString()+";";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Ruc = reader.GetString("ruc");
                cliente.Nombre = reader.GetString("nombrecli");
                cliente.ApellidoPaterno = reader.GetString("apelCli");
                cliente.Dni_vendedor = reader.GetString("dni_vendedor");
                cliente.Id = reader.GetInt32("id_cliente");
                Vendedor vendedor = new Vendedor();
                vendedor.Dni = reader.GetString("dni_vendedor");
                vendedor.Nombre = reader.GetString("nombreVendedor");
                vendedor.Apellido = reader.GetString("apelVendedor");
                vendedor.Comision = reader.GetDouble("comision");
                Transportista trans = new Transportista();
                trans.Nombre = reader.GetString("nombreAgencia");
                trans.Id = reader.GetInt32("id_agencia");
                Direccion direccion = new Direccion();
                direccion.Id = reader.GetInt32("id_agencia");
                direccion.DetalleDireccion = reader.GetString("direccion");
                Pedido pedido = new Pedido();

                pedido.IdVenta = reader.GetInt32("id_pedido");
                pedido.Cliente = cliente;
                pedido.Vendedor = vendedor;
                pedido.Transportista = trans;
                pedido.Direccion = direccion;
                pedido.Etapa = (EtapaPedido)reader.GetInt32("etapaProceso");

                pedido.Fecha_e = reader.GetDateTime("fecha_recepcion");

                //pedido.Etapa =
                pedido.Etapa = (EtapaPedido)reader.GetInt32("etapaProceso");



                lista.Add(pedido);

            }

            conn.Close();
            return lista;
        }
        public void eliminar(int id)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ELIMINAR_PEDIDO";
            cmd.Parameters.Add("_IDPEDIDO", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public BindingList<DetallePedido> listarDetallePedido(int id)
        {
            BindingList<DetallePedido> lista = new BindingList<DetallePedido>();
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "listarDetallesPedido";
            cmd.Parameters.Add("_idPedido", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Codigo = reader.GetString("id_producto");
                producto.Nombre = reader.GetString("nombre");
                switch (reader.GetString("UnidMedida"))
                {
                    case "UNIDAD":
                        producto.Um = Medida.unidad;
                        break;
                    case "CIENTO":
                        producto.Um = Medida.ciento;
                        break;
                    case "METRO":
                        producto.Um = Medida.metro;
                        break;
                    case "BOLSA":
                        producto.Um = Medida.bolsa;
                        break;
                    case "DOCENA":
                        producto.Um = Medida.docena;
                        break;
                    case "KILOGRAMO":
                        producto.Um = Medida.kilogramo;
                        break;
                }
                producto.Precio = reader.GetDouble("precio");
                producto.Descripcion = reader.GetString("descripcion");
                producto.Stock = reader.GetInt32("stock");
                //producto.MinimoStock = reader.GetInt32("stockMinimo");
                DetallePedido detallePedido = new DetallePedido();
                detallePedido.Producto = producto;
                detallePedido.Cantidad = reader.GetInt32("cantidad");
                detallePedido.Subtotal = reader.GetDouble("subtotal");
                detallePedido.Desc = reader.GetInt32("descuento1");
                lista.Add(detallePedido);
            }
            conn.Close();
            return lista;

        }
        public void agregarFactura(int idPedido,double totalDescuento, double totalImpuesto, double totalValorNeto, double netoApagar,int estadoVenta, int estadoPagoVendedor, double montoPagoVendedor)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "AGREGAR_FACTURA";

            cmd.Parameters.Add("_TOTALDESCUENTO", MySqlDbType.Double).Value = totalDescuento;
            cmd.Parameters.Add("_TOTALIMPUESTO", MySqlDbType.Double).Value = totalImpuesto;
            cmd.Parameters.Add("_TOTALVALORNETO", MySqlDbType.Double).Value = totalValorNeto;
            cmd.Parameters.Add("_NETOAPAGAR", MySqlDbType.Double).Value = netoApagar;
            cmd.Parameters.Add("_ESTADOVENTA", MySqlDbType.Int32).Value = estadoVenta;
            cmd.Parameters.Add("_ESTADOPAGOVENDEDOR", MySqlDbType.Int32).Value = estadoPagoVendedor;
            cmd.Parameters.Add("_MONTOPAGOVENDEDOR", MySqlDbType.Double).Value = montoPagoVendedor;
            cmd.Parameters.Add("_IDPEDIDO", MySqlDbType.Int32).Value = idPedido;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void facturarPedido(int idPedido)
        {
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "FACTURAR_PEDIDO";
            cmd.Parameters.Add("_IDPEDIDO", MySqlDbType.Int32).Value = idPedido;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }


}
