using AccesoDatos;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class FacturaBL
    {
        private FacturaDA facturaDA;
        public FacturaBL()
        {
            facturaDA = new FacturaDA();
        }
        public BindingList<Factura> listarFacturas()
        {
            return facturaDA.listar();
        }
        public void eliminarFactura(Factura factura)
        {
            // se verifica q no se haya hecho nada mas q solo generar la factura 
            facturaDA.elimFact(factura.IdVenta,factura.Pedido.IdVenta);

        }
        public void pagoCliente(int idfactura)
        {
            facturaDA.pagoCliente(idfactura);
        }
    }
}
