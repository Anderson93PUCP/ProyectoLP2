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
        private float Monto;
        private int ID_factura;

        public Pago() { }

        public string RUC1 { get => RUC; set => RUC = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public float Monto1 { get => Monto; set => Monto = value; }
        public int ID_factura1 { get => ID_factura; set => ID_factura = value; }
    }
}
