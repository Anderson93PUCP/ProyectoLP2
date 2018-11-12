using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pago
    {
        private string RUC;
        private string Nombre;
        private double Monto;
        private int ID_factura;
        private int EstadoPago;
        
        

        public Pago() { }

        public Pago(string rUC, string nombre, double monto, int iD_factura, int estadoPago)
        {
            RUC = rUC;
            Nombre = nombre;
            Monto = monto;
            ID_factura = iD_factura;
            EstadoPago = estadoPago;
        }

        public string RUC1 { get => RUC; set => RUC = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public double Monto1 { get => Monto; set => Monto = value; }
        public int ID_factura1 { get => ID_factura; set => ID_factura = value; }
        public int EstadoPago1 { get => EstadoPago; set => EstadoPago = value; }
    }
}
