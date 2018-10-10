using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using ProyectoLP2;

namespace AccesoDatos
{
    class PagoDA
    {
        MySqlConnection con = new MySqlConnection("SERVER=50.62.209.39;DATABASE=a20186335; UID=a20186335;PWD=GJjEv1");

        public BindingList<Factura> ListarFacturas()
        {
            try
            {
              
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                this.con.Open();

                MySqlCommand cmd = new MySqlCommand();
                String sql = "SELECT * FROM n_factura_venta where estadoPagoVendedor='1'";
                cmd.CommandText = sql;
                cmd.Connection = con;
                MySqlDataReader reader = cmd.ExecuteReader();
                
                BindingList<Factura> facturas = new BindingList<Factura>();

                while (reader.Read())
                {
                    Factura f1 = new Factura();

                    f1.NPedido = reader.GetInt32("id_pedido");
                    f1.IdVenta = reader.GetInt32("id_facturas");
                    



                    p1.ApellidoMaterno = reader.GetString("APELLIDO_MATERNO");
                    p1.Apellido_Paterno = reader.GetString("APELLIDO_PATERNO");
                    p1.DNI = reader.GetString("DNI");
                    p1.Nombres = reader.GetString("NOMBRES");
                    Pacientes.Add(p1);

                }

                // Fermeture de la connexion
                con.Close();
                return Pacientes;
            }
            catch
            {
                // Gestion des erreurs :
                return null;
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }
    }
}
