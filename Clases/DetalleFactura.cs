using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class DetalleFactura
    {
        private int idFactura;
        private Producto producto;
        private int cantidad;
        private double subtotal;
        private double desc;

        public DetalleFactura()
        {

        }

        public DetalleFactura(int idFactura, Producto producto, int cantidad, double subtotal, double desc)
        {
            this.IdFactura = idFactura;
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.Subtotal = subtotal;
            this.Desc = desc;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Desc { get => desc; set => desc = value; }
        public Producto Producto { get => producto; set => producto = value; }
    }
}
