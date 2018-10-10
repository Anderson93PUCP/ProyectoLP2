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
        private List<DetalleFactura> detallesFactura;

        public Factura()
        {

        }

        public Factura(int nuGuia, int nPedido, double valor_neto, double total_imp, double pagoVendedor, int estadoPagoVendedor, List<DetalleFactura> detallesFactura,
             Vendedor vendedor, int id, Cliente cliente, DateTime fecha_e, int ldetalles, EstadoVenta estado, Transportista transportista) :
            base(vendedor, id, cliente, fecha_e, ldetalles, estado, transportista)
        {
            this.NuGuia = nuGuia;
            this.NPedido = nPedido;
            this.Valor_neto = valor_neto;
            this.Total_imp = total_imp;
            this.PagoVendedor = pagoVendedor;
            this.EstadoPagoVendedor = estadoPagoVendedor;
            this.DetallesFactura = detallesFactura;
        }

        public int NuGuia { get => nuGuia; set => nuGuia = value; }
        public int NPedido { get => nPedido; set => nPedido = value; }
        public double Valor_neto { get => valor_neto; set => valor_neto = value; }
        public double Total_imp { get => total_imp; set => total_imp = value; }
        public double PagoVendedor { get => pagoVendedor; set => pagoVendedor = value; }
        public int EstadoPagoVendedor { get => estadoPagoVendedor; set => estadoPagoVendedor = value; }
        public List<DetalleFactura> DetallesFactura { get => detallesFactura; set => detallesFactura = value; }
    }
}
