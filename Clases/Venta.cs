using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Venta
    {
        private Vendedor vendedor;
        private int idVenta;
        private Cliente cliente;
        private Transportista transportista;
        private DateTime fecha_e;
        private EstadoVenta estado;

        public Venta()
        {

        }
    
        public Venta(Vendedor vendedor, int id, Cliente cliente, DateTime fecha_e, int ldetalles, EstadoVenta estado,Transportista transportista)
        {
            this.Vendedor = vendedor;
            this.IdVenta = id;
            this.Cliente = cliente;
            this.Fecha_e = fecha_e;
            this.Estado = estado;
            this.transportista = transportista;
        }

         public int IdVenta { get => idVenta; set => idVenta = value; }
         public DateTime Fecha_e { get => fecha_e; set => fecha_e = value; }
        public EstadoVenta Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Transportista Transportista { get => transportista; set => transportista = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
    }
}
