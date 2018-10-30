using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Pedido : Venta
    {
        private DateTime horaFechaImp;
        private EtapaPedido etapa;
        private String patida;
         private String llegada;
        private BindingList<DetallePedido> detallesPedido;


        public Pedido()
        {
            etapa = EtapaPedido.pendiente;
            detallesPedido = new BindingList<DetallePedido>();

        }

        public Pedido(DateTime horaFechaImp, EtapaPedido etapa, string patida, string llegada, BindingList<DetallePedido> detallesPedido)
        {
            this.horaFechaImp = horaFechaImp;
            this.etapa = etapa;
            this.patida = patida;
            this.llegada = llegada;
            this.detallesPedido = detallesPedido;
        }

        public DateTime HoraFechaImp { get => horaFechaImp; set => horaFechaImp = value; }
        public EtapaPedido Etapa { get => etapa; set => etapa = value; }
        public string Patida { get => patida; set => patida = value; }
        public string Llegada { get => llegada; set => llegada = value; }
        public BindingList<DetallePedido> DetallesPedido { get => detallesPedido; set => detallesPedido = value; }
        public string NombreVendedor { get => Vendedor.Nombre + " " + Vendedor.Apellido; }
    }
}
