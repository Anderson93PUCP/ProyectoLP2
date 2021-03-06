﻿using System;
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
        public BindingList<Pago> listar_todos_Pagos()
        {
            try
            {
                BindingList<Pago> listapagos = new BindingList<Pago>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "select id_facturas, a.ruc, a.nombre, montoPagoVendedor, estadoPagoVendedor from n_pedido p, n_factura_venta f, n_cliente a where p.id_pedido = f.id_pedido and f.estadoPagoVendedor = 0 and p.id_cliente = a.id_cliente ";
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



        public BindingList<Pago> listarPagos(string dni)
        {
            try
            {
                BindingList<Pago> listapagos = new BindingList<Pago>();
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "select id_facturas, a.ruc, a.nombre, montoPagoVendedor, estadoPagoVendedor from n_pedido p, n_factura_venta f, n_cliente a where p.id_pedido = f.id_pedido and f.estadoPagoVendedor = 0 and p.id_cliente = a.id_cliente and p.dni_vendedor =" + dni.ToString();
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

        public void insertarPago(BindingList<Pago> listapagos, String dni)
        {
           
            MySqlConnection conn = new MySqlConnection(DBManager.cadena);
            conn.Open();

            
            
            foreach (Pago p in listapagos){

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AGREGAR_PAGO";

                cmd.Parameters.Add("_DNI_EMPLEADO", MySqlDbType.String).Value = dni;
                cmd.Parameters.Add("_MONTO", MySqlDbType.Double).Value = p.Monto1;
                cmd.Parameters.Add("_ID_FACTURA", MySqlDbType.Int32).Value = p.ID_factura1;
                
                cmd.ExecuteNonQuery();
            }
               conn.Close();
          
        }



        public void cambiarEstado(BindingList<Pago> listapagos)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DBManager.cadena);
                conn.Open();

                

                foreach (Pago p in listapagos)
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CAMBIAR_ESTADO_PAGO";

                    cmd.Parameters.Add("_ID_FACTURA", MySqlDbType.String).Value = p.ID_factura1;


                    cmd.ExecuteNonQuery();

                }
                
                
                conn.Close();

            }
            catch { }
        }

        public double calcular_monto(BindingList<Pago> listapagos)
        {
            double monto_total = 0;
            foreach(Pago p in listapagos)
            {
                monto_total = monto_total + p.Monto1;
            }
            return monto_total;
        }
                
    }
}

