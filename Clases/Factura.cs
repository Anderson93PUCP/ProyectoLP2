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
        private Pedido pedido;
        private double valor_neto;
        private double total_imp;
        private double neto_pagar;
        private double total_descuento; 
        private double pagoVendedor;
        private int estadoPagoVendedor;
        private List<DetalleFactura> detallesFactura;

        public Factura()
        {
            pedido = new Pedido();
            detallesFactura = new List<DetalleFactura>();
        }

        public Factura(int nuGuia, int nPedido, double valor_neto, double total_imp, double pagoVendedor, int estadoPagoVendedor, List<DetalleFactura> detallesFactura)
        {
            this.nuGuia = nuGuia;
            this.nPedido = nPedido;
            this.valor_neto = valor_neto;
            this.total_imp = total_imp;
            this.pagoVendedor = pagoVendedor;
            this.estadoPagoVendedor = estadoPagoVendedor;
            this.detallesFactura = detallesFactura;
        }

        public int NuGuia { get => nuGuia; set => nuGuia = value; }
        public int NPedido { get => nPedido; set => nPedido = value; }
        public double Valor_neto { get => valor_neto; set => valor_neto = value; }
        public double Total_imp { get => total_imp; set => total_imp = value; }
        public double PagoVendedor { get => pagoVendedor; set => pagoVendedor = value; }
        public int EstadoPagoVendedor { get => estadoPagoVendedor; set => estadoPagoVendedor = value; }
        public List<DetalleFactura> DetallesFactura { get => detallesFactura; set => detallesFactura = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }
        public double Neto_pagar { get => neto_pagar; set => neto_pagar = value; }
        public double Total_descuento { get => total_descuento; set => total_descuento = value; }
        public string RUC { get => pedido.ClienteRUC; }
        public string ClienteFactura { get => pedido.ClienteNombre; }
        public string VendedorFactura { get => pedido.NombreVendedor; }
        public DateTime FechaEmisionF { get => pedido.Fecha_e; }
        public EstadoVenta EstadoFactura { get => pedido.Estado; }
    }
}
