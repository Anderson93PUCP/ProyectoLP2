using System;
using System.Collections.Generic;
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
        private List<DetallePedido> detallesPedido;

        public Pedido()
        {

        }

        public Pedido(DateTime hora, EtapaPedido etapa, string patida, string llegada, List<DetallePedido> detallesPedido,
            Vendedor vendedor, int id, Cliente cliente, DateTime fecha_e, int ldetalles, EstadoVenta estado, Transportista transportista) :
            base( vendedor,  id,  cliente,  fecha_e,  ldetalles,  estado,  transportista)
        {
            this.HoraFechaImp = hora;
            this.Etapa = etapa;
            this.Patida = patida;
            this.Llegada = llegada;
            this.DetallesPedido = detallesPedido;
        }

        public DateTime HoraFechaImp { get => horaFechaImp; set => horaFechaImp = value; }
        public EtapaPedido Etapa { get => etapa; set => etapa = value; }
        public string Patida { get => patida; set => patida = value; }
        public string Llegada { get => llegada; set => llegada = value; }
        public List<DetallePedido> DetallesPedido { get => detallesPedido; set => detallesPedido = value; }
    }
}
