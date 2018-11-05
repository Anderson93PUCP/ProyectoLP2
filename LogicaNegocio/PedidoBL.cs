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
    public class PedidoBL
    {
        public PedidoBL()
        {

        }

        public void agregarPedido(Pedido pedidoAgregar)
        {
            PedidoDA pedido = new PedidoDA();
            int idPedido = pedido.agregar(pedidoAgregar); // agregarCabecera
            foreach (DetallePedido det in pedidoAgregar.DetallesPedido)
            {
                pedido.AgregarDetalle(idPedido, det);
            }
        }
        public BindingList<Pedido> listarPedidos()
        {
            PedidoDA p = new PedidoDA();
            return p.listarPedidos();
        }
        public BindingList<Pedido> listarPedidos(int tipo)
        {
            PedidoDA p = new PedidoDA();
            return p.listarPedidos(tipo);
        }


        public void eliminarPedido(int idPedido)
        {
            PedidoDA p = new PedidoDA();
            // se libera los productos
            p.eliminar(idPedido);
        }

        public BindingList<DetallePedido> listarDetalle(int id)
        {
            PedidoDA p = new PedidoDA();
            return p.listarDetallePedido(id);
        }
        public void generarFactura(Pedido pedido)
        {
            BindingList<DetallePedido> detallesPedidoAFacturar = new BindingList<DetallePedido>();
            detallesPedidoAFacturar = listarDetalle(pedido.IdVenta);
            double totalDescuento = 0;
            double totalImpuesto = 0;
            double totalValorNeto= 0;
            double netoApagar = 0;
            foreach(DetallePedido det in detallesPedidoAFacturar)
            {
                totalDescuento = totalDescuento + (det.Desc / 100) * (det.Cantidad * det.Producto.Precio);
                totalValorNeto += det.Subtotal;
            }
            totalImpuesto = 0.18 * (totalValorNeto);
            netoApagar = totalImpuesto + totalValorNeto;
            double montoPagoVendedor = totalValorNeto * (pedido.Vendedor.Comision / 100); 
            PedidoDA p = new PedidoDA();
            p.agregarFactura(pedido.IdVenta, totalDescuento, totalImpuesto, totalValorNeto, netoApagar,1,0,montoPagoVendedor);
            p.facturarPedido(pedido.IdVenta);
        }

    }
}
