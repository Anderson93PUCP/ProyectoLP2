using AccesoDatos;
using ProyectoLP2;
using System;
using System.Collections.Generic;
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
                //pedido.AgregarDetalle(idPedido, det);
            }
        }
    }
}
