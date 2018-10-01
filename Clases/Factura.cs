using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Factura : Venta
    {

        private int nuGuia;
        private int nPedido;
        private double valor_neto;
        private double total_imp;
        private double pagoVendedor;
        private int estadoPagoVendedor;

        public Factura()
        {

        }

        public Factura(int nuGuia, int nPedido, double valor_neto, double total_imp, double pagoVendedor, int estadoPagoVendedor,
             string IDUsuario, int id, string ruc_cliente, DateTime fecha_e, int ldetalles, EstadoVenta estado) :
            base(IDUsuario, id, ruc_cliente, fecha_e, ldetalles, estado)
        {
            this.NuGuia = nuGuia;
            this.NPedido = nPedido;
            this.Valor_neto = valor_neto;
            this.Total_imp = total_imp;
            this.PagoVendedor = pagoVendedor;
            this.EstadoPagoVendedor = estadoPagoVendedor;
        }

        public int NuGuia { get => nuGuia; set => nuGuia = value; }
        public int NPedido { get => nPedido; set => nPedido = value; }
        public double Valor_neto { get => valor_neto; set => valor_neto = value; }
        public double Total_imp { get => total_imp; set => total_imp = value; }
        public double PagoVendedor { get => pagoVendedor; set => pagoVendedor = value; }
        public int EstadoPagoVendedor { get => estadoPagoVendedor; set => estadoPagoVendedor = value; }
    }
}
