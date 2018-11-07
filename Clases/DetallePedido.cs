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
        private Producto producto;
        private int cantidad;
        private double subtotal;
        private double desc;


        public DetallePedido()
        {
            producto = new Producto();
        }

        public DetallePedido(int idPedido, Producto producto, int cantidad, double subtotal, double desc)
        {
            this.idPedido = idPedido;
            this.Producto = producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
            this.desc = desc;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Desc { get => desc; set => desc = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public string proCod { get => producto.Codigo; }
        public string proNomb { get => producto.Nombre; }
        public string proDesc { get => producto.Descripcion; }
        public double proPre { get => producto.Precio; }
        
         
    }
}
