using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class DetallePedido
    {
        private int idPedido;
        private String Idproducto;
        private int cantidad;
        private double subtotal;
        private double desc;


        public DetallePedido()
        {

        }

        public DetallePedido(int idPedido, string idproducto, int cantidad, double subtotal, double desc)
        {
            this.idPedido = idPedido;
            Idproducto = idproducto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
            this.desc = desc;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Idproducto1 { get => Idproducto; set => Idproducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Desc { get => desc; set => desc = value; }
    }
}
