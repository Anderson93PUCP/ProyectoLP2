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
    class PagoDA
    {
        //    public BindingList<Factura> listarfacturas()
        //    {
        //        try
        //        {
        //            BindingList<Factura> listfatcuras = new BindingList<Factura>();
        //            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
        //            conn.Open();

        //            MySqlCommand cmd = new MySqlCommand();
        //            String sql = "SELECT * FROM n_factura_venta where estadoPagoVendedor='1'";
        //            cmd.CommandText = sql;
        //            cmd.Connection = conn;
        //            MySqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                Factura fac = new Factura();

        //                fac.IdVenta = reader.GetInt32("id_facturas");
        //                fac.NPedido = reader.GetInt32("id_pedido");
        //                //fac.PagoVendedor = ;
        //                fac.Total_imp =reader.GetDouble("total_imp");
        //                fac.Valor_neto =reader.GetDouble("totalv_neto") ;
        //                //fac.Vendedor =;
        //                //fac.Transportista =;
        //                //fac.Fecha_e =;
        //                //fac.EstadoPagoVendedor =;
        //                //fac.Estado =;
        //                fac. =;
        //                //fac.DetallesFactura =;




        //                cliente.Id = reader.GetInt32("id_cliente");
        //                cliente.Ruc = reader.GetString("ruc");
        //                cliente.Nombre = reader.GetString("nombre");
        //                cliente.ApellidoPaterno = reader.GetString("apellido");
        //                cliente.Email = reader.GetString("correo_electronico");
        //                cliente.Telefono = reader.GetInt32("telefono");
        //                cliente.Dni_vendedor = reader.GetString("dni_vendedor");
        //                clientes.Add(cliente);
        //            }
        //            conn.Close();
        //            return clientes;
        //        }
        //        catch
        //        {
        //            return null;
        //        }
        //    }
        //}
    }
}
